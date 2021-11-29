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

        public double GetFrecuenciaPorDemanda(int demanda)
        {
            double freq = 0;
            switch (demanda)
            {
                case 20:
                    freq = 0.30;
                    break;
                case 21:
                    freq = 0.25;
                    break;
                case 22:
                    freq = 0.20;
                    break;
                case 23:
                    freq = 0.05;
                    break;
                case 24:
                    freq = 0.10;
                    break;
                case 25:
                    freq = 0.10;
                    break;
                default: break;
            }
            return freq;
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

            while (dia < diasTiempoTotal)
            {
                if (dia == 0)
                {
                    // Condicion Inicial

                    //var demanda = demandaAnterior;
                    //var cantVentasPerdidas = ventasPerdidas;


                }

                // Se calcula la demanda y las ventas perdidas


                // Se calcula la demanda por día y el costo


                // Se determinan faltantes
                
                // Se agregan los datos a la fila nueva
                int idx = dataGridViewSimulacion.Rows.Add();
                DataGridViewRow row = dataGridViewSimulacion.Rows[idx];
                row.Cells["NroDia"].Value = dia;

                dia++;

            }

        }
    }
}
