using System;
using System.Globalization;
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

        private bool ValidarIngresoDatos()
        {
            if (txtPrecioCompra.Text.ToString() == "" ||
                txtPrecioReembolso.Text.ToString() == "" ||
                txtCostoUtilidad.Text.ToString() == "" ||
                txtDemandaAnteriorInicial.Text.ToString() == "" ||
                txtVentasPerdidas.Text.ToString() == "" ||
                txtTiempoTotalSimulacion.Text.ToString() == "" ||
                txtDesde.Text.ToString() == "" ||
                txtDiasAMostrar.Text.ToString() == "")
            {
                MessageBox.Show("Por favor, verifique el ingreso de todos los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void OnClickIniciarSimulacion(object sender, EventArgs e)
        {          
            bool puedeIniciar = ValidarIngresoDatos();

            if (!puedeIniciar) return;

            tabControl.Visible = false;
            //dataGridViewSimulacion.Visible = false;
            //dataGridViewGrilla.Visible = false;

            progressBar.Visible = true;
            progressBar.Minimum = 1;
            // Set Maximum to the total number of files to copy.           
            // Set the initial value of the ProgressBar.
            progressBar.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar.Step = 1;

            // Limpiar tablas
            dataGridViewSimulacion.Rows.Clear();
            dataGridViewGrilla.Rows.Clear();

            // Tomar datos de input
            double precioCompra = double.Parse(txtPrecioCompra.Text.ToString());
            double precioReembolso = double.Parse(txtPrecioReembolso.Text.ToString());
            double costoUtilidad = double.Parse(txtCostoUtilidad.Text.ToString());

            double demandaAnterior = double.Parse(txtDemandaAnteriorInicial.Text.ToString());
            double ventasPerdidas = double.Parse(txtVentasPerdidas.Text.ToString());

            double diasTiempoTotal = double.Parse(txtTiempoTotalSimulacion.Text.ToString());

            double desde = double.Parse(txtDesde.Text.ToString());
            double diasAMostrar = double.Parse(txtDiasAMostrar.Text.ToString());
            double hasta = desde + diasAMostrar;

            progressBar.Maximum = (int)diasTiempoTotal;

            int dia = 0;
            int idx = 0;
            DataGridViewRow row = new DataGridViewRow();
            double costoPromedio = 0;
            double costo = 0;

            int nroFilaAnterior = 0;
            var rowBefore = new DataGridViewRow();
            double cantidadAPedir = 0;

            double randomCantidadOrden = 0;
            double randomDemanda = 0;

            double demandaDiaAnterior = 0;
            double ventasPerdidasDiaAnterior = 0;

            double demanda = 0;

            double costoReembolso = 0;
            double costoUtilidadDia = 0;

            double ventasPerdidasEnElDia = 0;

            double costoCompraAcumulado = 0;
            double costoReembolsoAcumulado = 0;
            double costoUtilidadAcumulado = 0;
            double costoDiario = 0;
            double costoDiarioAcumulado = 0;
            double promedioDiaAnterior = 0;

            Random random = new Random();

            // 46.46 segundos los 200.000 dias con while
            // Mas de 2 minutos con 30 segundos los 200.000 dias con for
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
                    row.Cells["CostoCompraAcumulado"].Value = 0;
                    row.Cells["Reembolso"].Value = 0;
                    row.Cells["ReembolsoAcumulado"].Value = 0;
                    row.Cells["CostoUtilidad"].Value = 0;
                    row.Cells["CostoUtilidadAcumulado"].Value = 0;
                    row.Cells["CostoDiarioAcumulado"].Value = 0;
                    row.Cells["CostoPromedio"].Value = 0;

                    // si el filtro 'desde' incluye el primer dia
                    if (desde <= dia)
                    {
                        // Se agregan los datos a la fila nueva en la Grilla
                        var nr = dataGridViewGrilla.Rows.Add();
                        var rowGrilla = dataGridViewGrilla.Rows[nr];
                        rowGrilla.Cells["NDiaGrilla"].Value = dia;
                        //rowGrilla.Cells["CantidadOrdenGrilla"].Value = cantidadAPedir;
                        //rowGrilla.Cells["RandomDemandaGrilla"].Value = Math.Round(rnd, 5);
                        rowGrilla.Cells["DemandaGrilla"].Value = demandaAnterior;
                        //rowGrilla.Cells["PrecioCompraGrilla"].Value = Math.Round(costo, 5);
                        rowGrilla.Cells["CostoCompraAcumuladoGrilla"].Value = 0;
                        rowGrilla.Cells["VentasPerdidasGrilla"].Value = ventasPerdidas;
                        rowGrilla.Cells["ReembolsoGrilla"].Value = 0;
                        rowGrilla.Cells["ReembolsoAcumuladoGrilla"].Value = 0;
                        rowGrilla.Cells["CostoUtilidadGrilla"].Value = 0;
                        rowGrilla.Cells["CostoUtilidadAcumuladoGrilla"].Value = 0;
                        rowGrilla.Cells["CostoDiarioGrilla"].Value = 0;
                        rowGrilla.Cells["CostoDiarioAcumuladoGrilla"].Value = 0;
                        rowGrilla.Cells["CostoPromedioGrilla"].Value = 0;
                    }

                    dia++;
                    continue;
                }

                // Se calcula la cantidad a pedir en la orden
                nroFilaAnterior = dia - 1;
                rowBefore = dataGridViewSimulacion.Rows[nroFilaAnterior];
                
                if (opPoliticaA.Checked)
                {
                    // POLITICA A:                
                    demandaDiaAnterior = double.Parse(rowBefore.Cells["Demanda"].Value.ToString());
                    ventasPerdidasDiaAnterior = double.Parse(rowBefore.Cells["VentasPerdidas"].Value.ToString());

                    cantidadAPedir = demandaDiaAnterior + ventasPerdidasDiaAnterior;
                } else
                {
                    // POLITICA B:
                    // La cantidad a pedir puede ser 21 22 23 o 24 

                    // Genero otro random
                    randomCantidadOrden = random.NextDouble();
                    // AGREGAR A LA TABLA ESTE RANDOM
                    dataGridViewSimulacion.Columns["RandomCantidadOrden"].Visible = true;
                    dataGridViewGrilla.Columns["RandomCantidadOrdenGrilla"].Visible = true;

                    if (opNormal.Checked)
                    {
                        cantidadAPedir = (int)GenerarNumeroDistNormal(randomCantidadOrden, (decimal)22.5, (decimal)1.118033);
                    }
                    if (opUniforme.Checked)
                    {
                        cantidadAPedir = (int)GenerarNumeroDistUniforme(randomCantidadOrden, 21, 24);
                    }
                    if (opExponencial.Checked)
                    {
                        cantidadAPedir = (int)GenerarNumeroDistExponencial(randomCantidadOrden, (decimal)22.5);
                    }
                    //cantidadAPedir = GetCantidadOrdenPorFrecuencia(rand);
                }

                // Se calcula la demanda y las ventas perdidas
                randomDemanda = random.NextDouble();

                demanda = GetDemandaPorFrecuencia(randomDemanda);

                costo = precioCompra * demanda;

                // demanda por frecuencia

                // Se determinan faltantes
                //var ventasPerdidasEnElDia = cantidadAPedir >= demanda ? cantidadAPedir - demanda : demanda - cantidadAPedir;

                // Si la cantidad es positiva, tengo que devolver
                // Si es negativa, tengo costo de utilidad
                // Si es cero, no tengo costo
               
                ventasPerdidasEnElDia = cantidadAPedir - demanda;

                if (ventasPerdidasEnElDia > 0)
                {
                    costoReembolso = precioReembolso * ventasPerdidasEnElDia;
                }
                if (ventasPerdidasEnElDia < 0)
                {
                    costoUtilidadDia = costoUtilidad * -(ventasPerdidasEnElDia);
                }

                // Acumulado = este + el anterior
                //costoCompraAcumulado = double.Parse(rowBefore.Cells["CostoCompraAcumulado"].Value.ToString()) + costo;
                costoCompraAcumulado = Convert.ToDouble(rowBefore.Cells["CostoCompraAcumulado"].Value.ToString().Replace("$ ", "")) + costo;
                costoReembolsoAcumulado = double.Parse(rowBefore.Cells["ReembolsoAcumulado"].Value.ToString().Replace("$ ", "")) + costoReembolso;
                costoUtilidadAcumulado = double.Parse(rowBefore.Cells["CostoUtilidadAcumulado"].Value.ToString().Replace("$ ", "")) + costoUtilidadDia;
                

                costoDiario = -costo + costoReembolso - costoUtilidadDia;
                costoDiarioAcumulado = double.Parse(rowBefore.Cells["CostoDiarioAcumulado"].Value.ToString().Replace("$ ", "")) + costoDiario;

                // Se calcula la demanda por día y el costo

                // Costo promedio diario
                // promedio = (1/n) * [ (n-1) * promedio fila anterior + valor costo diario actual ]
                promedioDiaAnterior = double.Parse(rowBefore.Cells["CostoPromedio"].Value.ToString().Replace("$ ", ""));

                costoPromedio = (((dia - 1) * promedioDiaAnterior) + costoDiario) / dia;

                // Se agregan los datos a la fila nueva
                idx = dataGridViewSimulacion.Rows.Add();
                row = dataGridViewSimulacion.Rows[idx];
                row.Cells["NroDia"].Value = dia;
                row.Cells["RandomCantidadOrden"].Value = randomCantidadOrden;
                row.Cells["CantidadOrden"].Value = cantidadAPedir;
                row.Cells["RandomDemanda"].Value = Math.Round(randomDemanda, 5);
                row.Cells["Demanda"].Value = demanda;
                row.Cells["PrecioCompra"].Value = Math.Round(costo, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["CostoCompraAcumulado"].Value = Math.Round(costoCompraAcumulado, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["VentasPerdidas"].Value = ventasPerdidasEnElDia;
                row.Cells["Reembolso"].Value = Math.Round(costoReembolso, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["ReembolsoAcumulado"].Value = Math.Round(costoReembolsoAcumulado, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["CostoUtilidad"].Value = Math.Round(costoUtilidadDia, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["CostoUtilidadAcumulado"].Value = Math.Round(costoUtilidadAcumulado, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["CostoDiario"].Value = Math.Round(costoDiario, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["CostoDiarioAcumulado"].Value = Math.Round(costoDiarioAcumulado, 5).ToString("C3", CultureInfo.CurrentCulture);
                row.Cells["CostoPromedio"].Value = Math.Round(costoPromedio, 5).ToString("C3", CultureInfo.CurrentCulture);

                if (desde <= dia && dia <= hasta )
                {
                    // Se agregan los datos a la fila nueva en la Grilla
                    var nr = dataGridViewGrilla.Rows.Add();
                    var rowGrilla = dataGridViewGrilla.Rows[nr];
                    rowGrilla.Cells["NDiaGrilla"].Value = dia;
                    rowGrilla.Cells["RandomCantidadOrdenGrilla"].Value = randomCantidadOrden;
                    rowGrilla.Cells["CantidadOrdenGrilla"].Value = cantidadAPedir;
                    rowGrilla.Cells["RandomDemandaGrilla"].Value = Math.Round(randomDemanda, 5);
                    rowGrilla.Cells["DemandaGrilla"].Value = demanda;
                    rowGrilla.Cells["PrecioCompraGrilla"].Value = Math.Round(costo, 5);
                    rowGrilla.Cells["CostoCompraAcumuladoGrilla"].Value = Math.Round(costoCompraAcumulado, 5);
                    rowGrilla.Cells["VentasPerdidasGrilla"].Value = ventasPerdidasEnElDia;
                    rowGrilla.Cells["ReembolsoGrilla"].Value = Math.Round(costoReembolso, 5);
                    rowGrilla.Cells["ReembolsoAcumuladoGrilla"].Value = Math.Round(costoReembolsoAcumulado, 5);
                    rowGrilla.Cells["CostoUtilidadGrilla"].Value = Math.Round(costoUtilidadDia, 5);
                    rowGrilla.Cells["CostoUtilidadAcumuladoGrilla"].Value = Math.Round(costoUtilidadAcumulado, 5);
                    rowGrilla.Cells["CostoDiarioGrilla"].Value = Math.Round(costoDiario, 5);
                    rowGrilla.Cells["CostoDiarioAcumuladoGrilla"].Value = Math.Round(costoDiarioAcumulado, 5);
                    rowGrilla.Cells["CostoPromedioGrilla"].Value = Math.Round(costoPromedio, 5);
                }

                if (dia+1 == diasTiempoTotal && !(hasta >= diasTiempoTotal) )
                {
                    // Agrego el ultimo dia a la tabla
                    var nr = dataGridViewGrilla.Rows.Add();
                    var rowGrilla = dataGridViewGrilla.Rows[nr];
                    rowGrilla.Cells["NDiaGrilla"].Value = dia;
                    rowGrilla.Cells["RandomCantidadOrdenGrilla"].Value = randomCantidadOrden;
                    rowGrilla.Cells["CantidadOrdenGrilla"].Value = cantidadAPedir;
                    rowGrilla.Cells["RandomDemandaGrilla"].Value = Math.Round(randomDemanda, 5);
                    rowGrilla.Cells["DemandaGrilla"].Value = demanda;
                    rowGrilla.Cells["PrecioCompraGrilla"].Value = Math.Round(costo, 5);
                    rowGrilla.Cells["CostoCompraAcumuladoGrilla"].Value = Math.Round(costoCompraAcumulado, 5);
                    rowGrilla.Cells["VentasPerdidasGrilla"].Value = ventasPerdidasEnElDia;
                    rowGrilla.Cells["ReembolsoGrilla"].Value = Math.Round(costoReembolso, 5);
                    rowGrilla.Cells["ReembolsoAcumuladoGrilla"].Value = Math.Round(costoReembolsoAcumulado, 5);
                    rowGrilla.Cells["CostoUtilidadGrilla"].Value = Math.Round(costoUtilidadDia, 5);
                    rowGrilla.Cells["CostoUtilidadAcumuladoGrilla"].Value = Math.Round(costoUtilidadAcumulado, 5);
                    rowGrilla.Cells["CostoDiarioGrilla"].Value = Math.Round(costoDiario, 5);
                    rowGrilla.Cells["CostoDiarioAcumuladoGrilla"].Value = Math.Round(costoDiarioAcumulado, 5);
                    rowGrilla.Cells["CostoPromedioGrilla"].Value = Math.Round(costoPromedio, 5);
                }

                dia++;

                progressBar.PerformStep();

            }

            // Agrego los resultados a la tabla de Resultados
            int n = dataGridViewResultados.Rows.Add();
            var fila = dataGridViewResultados.Rows[n];
            fila.Cells["N"].Value = n+1;
            fila.Cells["FechaHora"].Value = DateTime.Now;
            fila.Cells["Politica"].Value = opPoliticaA.Checked ? "Politica A" : "Politica B";
            fila.Cells["CantidadDias"].Value = diasTiempoTotal;
            
            fila.Cells["PrecioCompraPolitica"].Value = precioCompra;
            fila.Cells["PrecioReembolsoPolitica"].Value = precioReembolso;
            fila.Cells["CostoUtilidadPolitica"].Value = costoUtilidad;

            fila.Cells["CostoPromedioPolitica"].Value = costoPromedio;

            progressBar.Visible = false ;
            //dataGridViewSimulacion.Visible = true;
            //dataGridViewGrilla.Visible = true;
            tabControl.Visible = true;
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

        public int GetCantidadOrdenPorFrecuencia(double frecuencia)
        {
            int demanda = 0;

            if (0 <= frecuencia && frecuencia < 0.25)
            {
                demanda = 21;
            }

            if (0.25 <= frecuencia && frecuencia < 0.5)
            {
                demanda = 22;
            }

            if (0.5 <= frecuencia && frecuencia < 0.75)
            {
                demanda = 23;
            }

            if (0.75 <= frecuencia && frecuencia < 1)
            {
                demanda = 24;
            }

            return demanda;
        }

        public Decimal GenerarNumeroDistUniforme(double rnd, Decimal a, Decimal b)
        {
            Decimal nro = Convert.ToDecimal(rnd);
            Decimal nroAleat = a + (nro * (b - a));                
            return nroAleat;
        }

        public Decimal GenerarNumeroDistNormal(double rnd, Decimal media, Decimal desviacion)
        {
            //Método de convolución
            Decimal suma = 0;
            for (int j = 0; j < 12; j++)
            {
                Decimal aleat = Convert.ToDecimal(rnd);
                suma = suma + aleat;
            }
            Decimal z = ((suma - 6) * desviacion) + media;        
            return z;
        }


        public Decimal GenerarNumeroDistExponencial(double rnd, Decimal media)
        {
            Decimal nro = Convert.ToDecimal(rnd);
            Decimal lambda = 1 / media;
            Decimal log = Convert.ToDecimal(Math.Log(Convert.ToDouble(1 - nro)));
            Decimal nroAleat = (-1 / lambda) * log;
            return nroAleat;
        }

        public Decimal GenerarNumeroDistPoisson(double rnd, Decimal lambda)
        {              
            Double a = Math.Pow((Math.E), Convert.ToDouble(-lambda));
            Double b = 1;
            Decimal i = -1;
            do
            {
                Double xi = rnd;
                b = b * xi;
                i = i + 1;

            } while (b > a);
                
            return i;
        }

        private void opPoliticaB_CheckedChanged(object sender, EventArgs e)
        {
            if (!opPoliticaB.Checked)
            {
                groupBoxDistribucion.Visible = false;
                return;
            }

            groupBoxDistribucion.Visible = true;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtVentasPerdidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void opExponencial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opUniforme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }

}
