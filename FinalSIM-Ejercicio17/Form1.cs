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

        public int GetDemandaPorFrecuencia(double frecuencia)
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
            //double precioCompra = double.Parse(txtPrecioCompra.Text.ToString());
            //double precioReembolso = double.Parse(txtPrecioReembolso.Text.ToString());
            //double costoUtilidad = double.Parse(txtCostoUtilidad.Text.ToString());

            //int demandaAnterior = int.Parse(txtDemandaAnteriorInicial.Text.ToString());
            //int ventasPerdidas = int.Parse(txtVentasPerdidas.Text.ToString());

            int diasTiempoTotal = int.Parse(txtTiempoTotalSimulacion.Text.ToString());

            int dia = 0;

            // 46.46 segundos los 200.000 dias con while

            // Mas de 2 minutos con 30 segundos los 200.000 dias con for

            while (dia < diasTiempoTotal)
            {
                if (dia == 0)
                {
                    // Condicion Inicial

                    //var demanda = demandaAnterior;
                    //var cantVentasPerdidas = ventasPerdidas;


                }

                // Se calcula la demanda y las ventas perdidas
                double rnd = random.NextDouble();

                int demanda = GetDemandaPorFrecuencia(rnd);

                // demanda por frecuencia


                // Se calcula la demanda por día y el costo


                // Se determinan faltantes

                // Se agregan los datos a la fila nueva
                int idx = dataGridViewSimulacion.Rows.Add();
                DataGridViewRow row = dataGridViewSimulacion.Rows[idx];
                row.Cells["NroDia"].Value = dia;
                row.Cells["RandomDemanda"].Value = Math.Round(rnd, 5);
                row.Cells["Demanda"].Value = demanda;

                dia++;

            }



        }
    }
}
