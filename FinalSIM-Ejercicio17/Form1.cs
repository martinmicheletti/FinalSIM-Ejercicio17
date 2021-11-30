using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSIM_Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnLoadEjercicio17(object sender, EventArgs e)
        {

        }

        public double GetDemandaPorFrecuencia(double frecuencia)
        {
            int demanda = 0;

            if (0 <= frecuencia && frecuencia < 0.30)
            {
                demanda = 20;
            }

            if (0.30 <= frecuencia && frecuencia < 0.55)
            {
                demanda = 21;
            }

            if (0.55 <= frecuencia && frecuencia < 0.75)
            {
                demanda = 22;
            }

            if (0.75 <= frecuencia && frecuencia < 0.80)
            {
                demanda = 23;
            }

            if (0.80 <= frecuencia && frecuencia < 0.90)
            {
                demanda = 24;
            }

            if (0.90 <= frecuencia && frecuencia < 1)
            {
                demanda = 25;
            }

            return demanda;
        }

        private bool ValidarIngresoDatos()
        {
            return true;
        }

        private void OnClickIniciarSimulacion(object sender, EventArgs e)
        {          
            bool puedeIniciar = ValidarIngresoDatos();    

            if (!puedeIniciar)
            {
                MessageBox.Show("Por favor, verifique el ingreso de todos los datos");
                return;
            }

            // Limpiar tablas
            dataGridViewSimulacion.Rows.Clear();

            Random random = new Random();

            // Tomar datos de input
            double precioCompra = double.Parse(txtPrecioCompra.Text.ToString());
            double precioReembolso = double.Parse(txtPrecioReembolso.Text.ToString());
            double costoUtilidad = double.Parse(txtCostoUtilidad.Text.ToString());

            int demandaAnterior = int.Parse(txtDemandaAnteriorInicial.Text.ToString());
            int ventasPerdidas = int.Parse(txtVentasPerdidas.Text.ToString());

            int diasTiempoTotal = int.Parse(txtTiempoTotalSimulacion.Text.ToString());

            int dia = 0;

            // 46.46 segundos los 200.000 dias con while

            // Mas de 2 minutos con 30 segundos los 200.000 dias con for

            int idx = 0;
            DataGridViewRow row = new DataGridViewRow();   

            while (dia < diasTiempoTotal)
            {
                if (dia == 0)
                {
                    // Condicion Inicial

                    //var demanda = demandaAnterior;
                    //var cantVentasPerdidas = ventasPerdidas;

                    // Se agregan los datos a la fila nueva
                    idx = dataGridViewSimulacion.Rows.Add();
                    row = dataGridViewSimulacion.Rows[idx];
                    row.Cells["NroDia"].Value = dia;
                    //row.Cells["CantidadOrden"].Value = cantidadAPedir;
                    //row.Cells["RandomDemanda"].Value = Math.Round(rnd, 5);
                    row.Cells["Demanda"].Value = demandaAnterior;
                    row.Cells["VentasPerdidas"].Value = ventasPerdidas;
                    //row.Cells["PrecioCompra"].Value = Math.Round(costo, 5);
                    row.Cells["Reembolso"].Value = 0;
                    row.Cells["ReembolsoAcumulado"].Value = 0;
                    row.Cells["CostoUtilidad"].Value = 0;
                    row.Cells["CostoUtilidadAcumulado"].Value = 0;

                    dia++;
                    continue;
                }

                // Se calcula la cantidad a pedir en la orden
                // POLITICA A:

                // Demanda del dia anterior
                int nroFilaAnterior = dia - 1;
                var rowBefore = dataGridViewSimulacion.Rows[nroFilaAnterior];

                var demandaDiaAnterior = int.Parse(rowBefore.Cells["Demanda"].Value.ToString());
                var ventasPerdidasDiaAnterior = int.Parse(rowBefore.Cells["VentasPerdidas"].Value.ToString());

                int cantidadAPedir = demandaDiaAnterior + ventasPerdidasDiaAnterior;

                // POLITICA B:
                //

                // Se calcula la demanda y las ventas perdidas
                double rnd = random.NextDouble();

                double demanda = GetDemandaPorFrecuencia(rnd);

                double costo = precioCompra * demanda;

                // demanda por frecuencia

                // Se determinan faltantes
                //var ventasPerdidasEnElDia = cantidadAPedir >= demanda ? cantidadAPedir - demanda : demanda - cantidadAPedir;

                // Si la cantidad es positiva, tengo que devolver
                // Si es negativa, tengo costo de utilidad
                // Si es cero, no tengo costo
                double costoReembolso = 0;
                double costoUtilidadDia = 0;

                var ventasPerdidasEnElDia = cantidadAPedir - demanda;

                if (ventasPerdidasEnElDia > 0)
                {
                    costoReembolso = precioReembolso * ventasPerdidasEnElDia;
                }
                if (ventasPerdidasEnElDia < 0)
                {
                    costoUtilidadDia = costoUtilidad * -(ventasPerdidasEnElDia);
                }

                // Acumulado = este + el anterior
                var costoReembolsoAcumulado = double.Parse(rowBefore.Cells["ReembolsoAcumulado"].Value.ToString()) + costoReembolso;
                var costoUtilidadAcumulado = double.Parse(rowBefore.Cells["CostoUtilidadAcumulado"].Value.ToString()) + costoUtilidadDia;

                // Se calcula la demanda por día y el costo

                // Se agregan los datos a la fila nueva
                idx = dataGridViewSimulacion.Rows.Add();
                row = dataGridViewSimulacion.Rows[idx];
                row.Cells["NroDia"].Value = dia;
                row.Cells["CantidadOrden"].Value = cantidadAPedir;
                row.Cells["RandomDemanda"].Value = Math.Round(rnd, 5);
                row.Cells["Demanda"].Value = demanda;
                row.Cells["PrecioCompra"].Value = Math.Round(costo, 5);
                row.Cells["VentasPerdidas"].Value = ventasPerdidasEnElDia;
                row.Cells["Reembolso"].Value = costoReembolso;
                row.Cells["ReembolsoAcumulado"].Value = costoReembolsoAcumulado;
                row.Cells["CostoUtilidad"].Value = costoUtilidadDia;
                row.Cells["CostoUtilidadAcumulado"].Value = costoUtilidadAcumulado;

                dia++;

            }



        }
    }
}
