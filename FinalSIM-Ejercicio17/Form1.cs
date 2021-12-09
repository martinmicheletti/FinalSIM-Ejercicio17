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
                (txtCantidadOrden.Visible == true && radioButtonCantidadFija.Checked == true && txtCantidadOrden.Text.ToString() == "") ||
                (txtA.Visible == true && radioButtonDemandaUniforme.Checked == true && txtA.Text.ToString() == "") ||
                (txtB.Visible == true && radioButtonDemandaUniforme.Checked == true && txtB.Text.ToString() == "") ||
                (txtMediaN.Visible == true && radioButtonDemandaNormal.Checked == true && txtMediaN.Text.ToString() == "") ||
                (txtDesvN.Visible == true && radioButtonDemandaNormal.Checked == true && txtDesvN.Text.ToString() == "") ||
                (txtMediaExp.Visible == true && (radioButtonDemandaExp.Checked == true || radioButtonDemandaPoisson.Checked) && txtMediaExp.Text.ToString() == "") ||
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

            // Progress Bar
            progressBar.Visible = true;
            progressBar.Minimum = 1;                     
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

            double aDemanda = double.Parse(txtA.Text.ToString());
            double bDemanda = double.Parse(txtB.Text.ToString());

            double mediaNormal = double.Parse(txtMediaN.Text.ToString());
            double desvNormal = double.Parse(txtDesvN.Text.ToString());

            double mediaExp = double.Parse(txtMediaExp.Text.ToString());

            double diasTiempoTotal = double.Parse(txtTiempoTotalSimulacion.Text.ToString());

            double desde = double.Parse(txtDesde.Text.ToString());
            double diasAMostrar = double.Parse(txtDiasAMostrar.Text.ToString());
            double hasta = desde + diasAMostrar;

            // Set Maximum to the total number of files to copy.
            progressBar.Maximum = (int)diasTiempoTotal;

            int dia = 0;
            int idx = 0;
            DataGridViewRow row = new DataGridViewRow();
            double costoPromedio = 0;
            double costo = 0;

            int nroFilaAnterior = 0;
            var rowBefore = new DataGridViewRow();
            double cantidadAPedir = 0;
            double cantidadOrdenAcumulado = 0;

            double randomCantidadOrden = 0;
            double randomDemanda = 0;

            double demandaDiaAnterior = 0;
            double ventasPerdidasDiaAnterior = 0;

            double demanda = 0;
            double demandaAcumulada = 0;
            string distribucionDemanda = "";

            double costoReembolso = 0;
            double costoUtilidadDia = 0;

            double ventasPerdidasEnElDia = 0;
            double ventasPerdidasReembolso = 0;
            double ventasPerdidasUtilidad = 0;

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
                // Condicion Inicial
                if (dia == 0)
                {
                    //var demanda = demandaAnterior;
                    //var cantVentasPerdidas = ventasPerdidas;

                    // Se agregan los datos a la primera fila
                    idx = dataGridViewSimulacion.Rows.Add();
                    row = dataGridViewSimulacion.Rows[idx];
                    row.Cells["NroDia"].Value = dia;
                    //row.Cells["CantidadOrden"].Value = cantidadAPedir;
                    //row.Cells["RandomDemanda"].Value = Math.Round(rnd, 5);
                    row.Cells["Demanda"].Value = demandaAnterior;
                    
                    row.Cells["VentasPerdidas"].Value = ventasPerdidas;


                    // SE CONTABILIZA EL DIA CERO EN LAS ESTADISTICAS?
                    //if (checkBoxDia0.Checked)
                    //{
                        //cantidadAPedir = demandaAnterior + ventasPerdidas;

                        //row.Cells["CantidadOrden"].Value = cantidadAPedir;

                        //costo = cantidadAPedir * precioCompra;

                        //if (() > 0)
                        //{
                        //    // Si la cantidad es positiva, tengo que devolver periodicos
                        //    //ventasPerdidasReembolso+=Math.Abs(ventasPerdidasEnElDia);

                        //    ventasPerdidasReembolso = double.Parse(rowBefore.Cells["VentasPerdidasReembolso"].Value.ToString()) + Math.Abs(ventasPerdidasEnElDia);

                        //    // el costo reembolso, es positivo ya que es un ingreso
                        //    costoReembolso = precioReembolso * Math.Abs(ventasPerdidasEnElDia);
                        //}
                        //if (ventasPerdidasEnElDia < 0)
                        //{
                        //    // Si es negativa, tengo costo de utilidad (costo de oportunidad)
                        //    // el costo de utilidad es negativo, ya que es perdida
                        //    //ventasPerdidasUtilidad+= Math.Abs(ventasPerdidasEnElDia);
                        //    ventasPerdidasUtilidad = double.Parse(rowBefore.Cells["VentasPerdidasUtilidad"].Value.ToString()) + Math.Abs(ventasPerdidasEnElDia);

                        //    costoUtilidadDia = -(costoUtilidad * Math.Abs(ventasPerdidasEnElDia));
                        //}
                        //if (ventasPerdidasEnElDia == 0)
                        //{
                        //    // Si es cero, no tengo costo 
                        //}

                        //row.Cells["PrecioCompra"].Value = Math.Round(costo, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["CostoCompraAcumulado"].Value = Math.Round(costo, 5).ToString("C", CultureInfo.CurrentCulture);
                        
                        //row.Cells["VentasPerdidasReembolso"].Value = Math.Abs(ventasPerdidasReembolso);
                        //row.Cells["VentasPerdidasUtilidad"].Value = Math.Abs(ventasPerdidasUtilidad);
                        //row.Cells["Reembolso"].Value = Math.Round(costoReembolso, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["ReembolsoAcumulado"].Value = Math.Round(costoReembolsoAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["CostoUtilidad"].Value = Math.Round(costoUtilidadDia, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["CostoUtilidadAcumulado"].Value = Math.Round(costoUtilidadAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["CostoDiario"].Value = Math.Round(costoDiario, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["CostoDiarioAcumulado"].Value = Math.Round(costoDiarioAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                        //row.Cells["CostoPromedio"].Value = Math.Round(costoPromedio, 5).ToString("C", CultureInfo.CurrentCulture);

                        //row.Cells["CantidadOrdenAcumulado"].Value = 0;
                        //row.Cells["DemandaAcumulada"].Value = 0;
                        //row.Cells["VentasPerdidasReembolso"].Value = 0;
                        //row.Cells["VentasPerdidasUtilidad"].Value = 0;
                        //row.Cells["CostoCompraAcumulado"].Value = 0;
                        //row.Cells["Reembolso"].Value = 0;
                        //row.Cells["ReembolsoAcumulado"].Value = 0;
                        //row.Cells["CostoUtilidad"].Value = 0;
                        //row.Cells["CostoUtilidadAcumulado"].Value = 0;
                        //row.Cells["CostoDiarioAcumulado"].Value = 0;
                        //row.Cells["CostoPromedio"].Value = 0;
                    //} else
                    //{
                        row.Cells["CantidadOrdenAcumulado"].Value = 0;
                        row.Cells["DemandaAcumulada"].Value = 0;
                        row.Cells["VentasPerdidasReembolso"].Value = 0;
                        row.Cells["VentasPerdidasUtilidad"].Value = 0;
                        row.Cells["CostoCompraAcumulado"].Value = 0;
                        row.Cells["Reembolso"].Value = 0;
                        row.Cells["ReembolsoAcumulado"].Value = 0;
                        row.Cells["CostoUtilidad"].Value = 0;
                        row.Cells["CostoUtilidadAcumulado"].Value = 0;
                        row.Cells["CostoDiarioAcumulado"].Value = 0;
                        row.Cells["CostoPromedio"].Value = 0;
                    //}
                    
                    // si el filtro 'desde' incluye el dia cero
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
                        rowGrilla.Cells["CantidadOrdenAcumGrilla"].Value = 0;
                        rowGrilla.Cells["DemandaAcumGrilla"].Value = 0;
                        rowGrilla.Cells["VentasPerdidasReembolsoGrilla"].Value = 0;
                        rowGrilla.Cells["VentasPerdidasUtilidadGrilla"].Value = 0;
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
                    if (radioButtonCantidadAleatoria.Checked)
                    {
                        // Genero otro random
                        randomCantidadOrden = random.NextDouble();
                        dataGridViewSimulacion.Columns["RandomCantidadOrden"].Visible = true;
                        dataGridViewGrilla.Columns["RandomCantidadOrdenGrilla"].Visible = true;

                        // REVISAR SI VA O NO
                        //if (opNormal.Checked)
                        //{
                        //    cantidadAPedir = (int)GenerarNumeroDistNormal(randomCantidadOrden, (decimal)22.5, (decimal)1.118033);
                        //}
                        //if (opUniforme.Checked)
                        //{
                        //    cantidadAPedir = (int)GenerarNumeroDistUniforme(randomCantidadOrden, 21, 24);
                        //}
                        //if (opExponencial.Checked)
                        //{
                        //    cantidadAPedir = (int)GenerarNumeroDistExponencial(randomCantidadOrden, (decimal)22.5);
                        //}
                        cantidadAPedir = GetCantidadOrdenPorFrecuencia(randomCantidadOrden);
                    }
                    else
                    {
                        dataGridViewSimulacion.Columns["RandomCantidadOrden"].Visible = false;
                        dataGridViewGrilla.Columns["RandomCantidadOrdenGrilla"].Visible = false;
                        cantidadAPedir = double.Parse(txtCantidadOrden.Text.ToString());
                    }
                    
                }

                // Se calcula la demanda y las ventas perdidas
                randomDemanda = random.NextDouble();

                // demanda por frecuencia
                if (radioButtonTablaEnunciado.Checked)
                {
                    distribucionDemanda = "Tabla enunciado";
                    demanda = GetDemandaPorFrecuencia(randomDemanda);
                }
                if (radioButtonDemandaUniforme.Checked)
                {
                    distribucionDemanda = "Uniforme ( "+aDemanda+ ";" + bDemanda + " )";
                    demanda = Math.Round(GenerarNumeroDistUniforme(randomDemanda, double.Parse(txtA.Text), double.Parse(txtB.Text)));
                }
                if (radioButtonDemandaNormal.Checked)
                {
                    distribucionDemanda = "Normal ( " + mediaNormal + ";" + desvNormal + " )";
                    do
                    {
                        randomDemanda = random.NextDouble();
                        demanda = Math.Round(GenerarNumeroDistNormal(randomDemanda, double.Parse(txtMediaN.Text), double.Parse(txtDesvN.Text)));
                    } while (demanda < 0);
                    
                }
                if (radioButtonDemandaExp.Checked)
                {
                    distribucionDemanda = "Exponencial Negativa ( u =" + mediaExp + " )";
                    demanda = Math.Round(GenerarNumeroDistExponencial(randomDemanda, double.Parse(txtMediaExp.Text)));
                }
                if (radioButtonDemandaPoisson.Checked)
                {
                    distribucionDemanda = "Exponencial Poisson ( u =" + mediaExp + " )";
                    demanda = Math.Round(GenerarNumeroDistPoisson(randomDemanda, double.Parse(txtMediaExp.Text)));
                }

                // EL COSTO ES SOBRE LA CANTIDAD DE ORDEN, NO DE LA DEMANDA
                // como es costo, es negativo
                costo = - (precioCompra * cantidadAPedir);
                //costo = precioCompra * demanda;

                //var ventasPerdidasEnElDia = cantidadAPedir >= demanda ? cantidadAPedir - demanda : demanda - cantidadAPedir;

                ventasPerdidasEnElDia = cantidadAPedir - demanda;


                costoReembolso = 0;
                costoUtilidadDia = 0;

                if (ventasPerdidasEnElDia > 0)
                {
                    // Si la cantidad es positiva, tengo que devolver periodicos
                    //ventasPerdidasReembolso+=Math.Abs(ventasPerdidasEnElDia);

                    ventasPerdidasReembolso = double.Parse(rowBefore.Cells["VentasPerdidasReembolso"].Value.ToString()) + Math.Abs(ventasPerdidasEnElDia);

                    // el costo reembolso, es positivo ya que es un ingreso
                    costoReembolso = precioReembolso * Math.Abs(ventasPerdidasEnElDia);
                }
                if (ventasPerdidasEnElDia < 0)
                {
                    // Si es negativa, tengo costo de utilidad (costo de oportunidad)
                    // el costo de utilidad es negativo, ya que es perdida
                    //ventasPerdidasUtilidad+= Math.Abs(ventasPerdidasEnElDia);
                    ventasPerdidasUtilidad = double.Parse(rowBefore.Cells["VentasPerdidasUtilidad"].Value.ToString()) + Math.Abs(ventasPerdidasEnElDia);

                    costoUtilidadDia = -(costoUtilidad * Math.Abs(ventasPerdidasEnElDia));
                }
                if (ventasPerdidasEnElDia == 0)
                {
                    // Si es cero, no tengo costo 
                }

                // Acumulado = este + el anterior

                cantidadOrdenAcumulado = double.Parse(rowBefore.Cells["CantidadOrdenAcumulado"].Value.ToString()) + cantidadAPedir;
                demandaAcumulada = double.Parse(rowBefore.Cells["DemandaAcumulada"].Value.ToString()) + demanda;

                //costoCompraAcumulado = double.Parse(rowBefore.Cells["CostoCompraAcumulado"].Value.ToString()) + costo;
                costoCompraAcumulado = Convert.ToDouble(rowBefore.Cells["CostoCompraAcumulado"].Value.ToString().Replace("$ ", "")) + costo;
                costoReembolsoAcumulado = double.Parse(rowBefore.Cells["ReembolsoAcumulado"].Value.ToString().Replace("$ ", "")) + costoReembolso;
                costoUtilidadAcumulado = double.Parse(rowBefore.Cells["CostoUtilidadAcumulado"].Value.ToString().Replace("$ ", "")) + costoUtilidadDia;
                
                costoDiario = costo + costoReembolso + costoUtilidadDia;
                costoDiarioAcumulado = double.Parse(rowBefore.Cells["CostoDiarioAcumulado"].Value.ToString().Replace("$ ", "")) + costoDiario;

                // Costo promedio diario
                // promedio = (1/n) * [ (n-1) * promedio fila anterior + valor costo diario actual ]
                promedioDiaAnterior = double.Parse(rowBefore.Cells["CostoPromedio"].Value.ToString().Replace("$ ", ""));
                costoPromedio = (((dia - 1) * promedioDiaAnterior) + costoDiario) / dia;

                // Se agregan los datos a la fila nueva
                idx = dataGridViewSimulacion.Rows.Add();
                row = dataGridViewSimulacion.Rows[idx];
                row.Cells["NroDia"].Value = dia;
                row.Cells["RandomCantidadOrden"].Value = Math.Round(randomCantidadOrden, 5);
                row.Cells["CantidadOrden"].Value = cantidadAPedir;
                row.Cells["CantidadOrdenAcumulado"].Value = cantidadOrdenAcumulado;              
                row.Cells["RandomDemanda"].Value = Math.Round(randomDemanda, 5);
                row.Cells["Demanda"].Value = demanda;
                row.Cells["DemandaAcumulada"].Value = demandaAcumulada;
                row.Cells["PrecioCompra"].Value = Math.Round(costo, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["CostoCompraAcumulado"].Value = Math.Round(costoCompraAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["VentasPerdidas"].Value = Math.Abs(ventasPerdidasEnElDia);
                row.Cells["VentasPerdidasReembolso"].Value = Math.Abs(ventasPerdidasReembolso);
                row.Cells["VentasPerdidasUtilidad"].Value = Math.Abs(ventasPerdidasUtilidad);
                row.Cells["Reembolso"].Value = Math.Round(costoReembolso, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["ReembolsoAcumulado"].Value = Math.Round(costoReembolsoAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["CostoUtilidad"].Value = Math.Round(costoUtilidadDia, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["CostoUtilidadAcumulado"].Value = Math.Round(costoUtilidadAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["CostoDiario"].Value = Math.Round(costoDiario, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["CostoDiarioAcumulado"].Value = Math.Round(costoDiarioAcumulado, 5).ToString("C", CultureInfo.CurrentCulture);
                row.Cells["CostoPromedio"].Value = Math.Round(costoPromedio, 5).ToString("C", CultureInfo.CurrentCulture);

                if (desde <= dia && dia <= hasta )
                {
                    // Se agregan los datos a la fila nueva en la Grilla
                    var nr = dataGridViewGrilla.Rows.Add();
                    var rowGrilla = dataGridViewGrilla.Rows[nr];
                    rowGrilla.Cells["NDiaGrilla"].Value = dia;
                    rowGrilla.Cells["RandomCantidadOrdenGrilla"].Value = Math.Round(randomCantidadOrden, 5);
                    rowGrilla.Cells["CantidadOrdenGrilla"].Value = cantidadAPedir;
                    rowGrilla.Cells["CantidadOrdenAcumGrilla"].Value = cantidadOrdenAcumulado;
                    rowGrilla.Cells["RandomDemandaGrilla"].Value = Math.Round(randomDemanda, 5);
                    rowGrilla.Cells["DemandaGrilla"].Value = demanda;
                    rowGrilla.Cells["DemandaAcumGrilla"].Value = demandaAcumulada;
                    rowGrilla.Cells["PrecioCompraGrilla"].Value = Math.Round(costo, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoCompraAcumuladoGrilla"].Value = Math.Round(costoCompraAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["VentasPerdidasGrilla"].Value = Math.Abs(ventasPerdidasEnElDia);
                    rowGrilla.Cells["VentasPerdidasReembolsoGrilla"].Value = Math.Abs(ventasPerdidasReembolso);
                    rowGrilla.Cells["VentasPerdidasUtilidadGrilla"].Value = Math.Abs(ventasPerdidasUtilidad);
                    rowGrilla.Cells["ReembolsoGrilla"].Value = Math.Round(costoReembolso, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["ReembolsoAcumuladoGrilla"].Value = Math.Round(costoReembolsoAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoUtilidadGrilla"].Value = Math.Round(costoUtilidadDia, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoUtilidadAcumuladoGrilla"].Value = Math.Round(costoUtilidadAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoDiarioGrilla"].Value = Math.Round(costoDiario, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoDiarioAcumuladoGrilla"].Value = Math.Round(costoDiarioAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoPromedioGrilla"].Value = Math.Round(costoPromedio, 5).ToString("C", CultureInfo.CurrentCulture); ;
                }

                if (dia+1 == diasTiempoTotal && !(hasta >= diasTiempoTotal) )
                {
                    // Agrego el ultimo dia a la tabla
                    var nr = dataGridViewGrilla.Rows.Add();
                    var rowGrilla = dataGridViewGrilla.Rows[nr];
                    rowGrilla.Cells["NDiaGrilla"].Value = dia;
                    rowGrilla.Cells["RandomCantidadOrdenGrilla"].Value = Math.Round(randomCantidadOrden, 5);
                    rowGrilla.Cells["CantidadOrdenGrilla"].Value = cantidadAPedir;
                    rowGrilla.Cells["CantidadOrdenAcumGrilla"].Value = cantidadOrdenAcumulado;
                    rowGrilla.Cells["RandomDemandaGrilla"].Value = Math.Round(randomDemanda, 5);
                    rowGrilla.Cells["DemandaGrilla"].Value = demanda;
                    rowGrilla.Cells["DemandaAcumGrilla"].Value = demandaAcumulada;
                    rowGrilla.Cells["PrecioCompraGrilla"].Value = Math.Round(costo, 5).ToString("C", CultureInfo.CurrentCulture);
                    rowGrilla.Cells["CostoCompraAcumuladoGrilla"].Value = Math.Round(costoCompraAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["VentasPerdidasGrilla"].Value = Math.Abs(ventasPerdidasEnElDia);
                    rowGrilla.Cells["VentasPerdidasReembolsoGrilla"].Value = Math.Abs(ventasPerdidasReembolso);
                    rowGrilla.Cells["VentasPerdidasUtilidadGrilla"].Value = Math.Abs(ventasPerdidasUtilidad);
                    rowGrilla.Cells["ReembolsoGrilla"].Value = Math.Round(costoReembolso, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["ReembolsoAcumuladoGrilla"].Value = Math.Round(costoReembolsoAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoUtilidadGrilla"].Value = Math.Round(costoUtilidadDia, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoUtilidadAcumuladoGrilla"].Value = Math.Round(costoUtilidadAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoDiarioGrilla"].Value = Math.Round(costoDiario, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoDiarioAcumuladoGrilla"].Value = Math.Round(costoDiarioAcumulado, 5).ToString("C", CultureInfo.CurrentCulture); ;
                    rowGrilla.Cells["CostoPromedioGrilla"].Value = Math.Round(costoPromedio, 5).ToString("C", CultureInfo.CurrentCulture); ;
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

            fila.Cells["OrdenesTotales"].Value = cantidadOrdenAcumulado;

            fila.Cells["DistribucionDemanda"].Value = distribucionDemanda;
            fila.Cells["DemandaTotal"].Value = demandaAcumulada;

            fila.Cells["DemandaInicialPolitica"].Value = demandaAnterior;
            fila.Cells["VentasPerdidasInicialPolitica"].Value = ventasPerdidas;

            fila.Cells["VentasTotalesPerdidasReembolso"].Value = ventasPerdidasReembolso;
            fila.Cells["VentasTotalesPerdidasUtilidad"].Value = ventasPerdidasUtilidad;

            fila.Cells["PrecioCompraPolitica"].Value = precioCompra.ToString("C", CultureInfo.CurrentCulture);
            fila.Cells["PrecioReembolsoPolitica"].Value = precioReembolso.ToString("C", CultureInfo.CurrentCulture);
            fila.Cells["CostoUtilidadPolitica"].Value = costoUtilidad.ToString("C", CultureInfo.CurrentCulture);

            fila.Cells["CostoPromedioPolitica"].Value = costoPromedio.ToString("C", CultureInfo.CurrentCulture);
            fila.Cells["CostoTotalPolitica"].Value = costoDiarioAcumulado.ToString("C", CultureInfo.CurrentCulture); ;

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

        public double GenerarNumeroDistUniforme(double rnd, double a, double b)
        {
            double nro = Convert.ToDouble(rnd);
            double nroAleat = a + (nro * (b - a));                
            return nroAleat;
        }

        public double GenerarNumeroDistNormal(double rnd, double media, double desviacion)
        {
            //Método de convolución
            double suma = 0;
            for (int j = 0; j < 12; j++)
            {
                double aleat = Convert.ToDouble(rnd);
                suma += aleat;
            }
            double z = ((suma - 6) * desviacion) + media;        
            return z;
        }


        public double GenerarNumeroDistExponencial(double rnd, double media)
        {
            double nro = (rnd);
            double lambda = 1 / media;
            double log = (Math.Log(Convert.ToDouble(1 - nro)));
            double nroAleat = (-1 / lambda) * log;
            return nroAleat;
        }

        public double GenerarNumeroDistPoisson(double rnd, double lambda)
        {   // Media = Lambda           
            double a = Math.Pow((Math.E), (-lambda));
            double b = 1;
            double i = -1;
            do
            {
                double xi = rnd;
                b *= xi;
                i++;

            } while (b > a);
                
            return i;
        }

        private void opPoliticaB_CheckedChanged(object sender, EventArgs e)
        {
            if (!opPoliticaB.Checked)
            {
                //groupBoxDistribucion.Visible = false;
                groupBoxOrden.Visible = false;
                return;
            }

            //groupBoxDistribucion.Visible = true;
            groupBoxOrden.Visible = true;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDemandaUniforme_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDemandaUniforme.Checked) { 
            
            }


            if (!radioButtonDemandaUniforme.Checked)
            {
                labelA.Visible = false;
                txtA.Visible = false;
                labelB.Visible = false;
                txtB.Visible = false;
            } else
            {
                labelA.Visible = true;
                txtA.Visible = true;
                labelB.Visible = true;
                txtB.Visible = true;
            }

            if (!radioButtonDemandaNormal.Checked)
            {
                labelMediaN.Visible = false;
                txtMediaN.Visible = false;
                labelDesvN.Visible = false;
                txtDesvN.Visible = false;
            }
            else
            {
                labelMediaN.Visible = true;
                txtMediaN.Visible = true;
                labelDesvN.Visible = true;
                txtDesvN.Visible = true;
            }

            if (!(radioButtonDemandaPoisson.Checked || radioButtonDemandaExp.Checked))
            {
                labelMediaExp.Visible = false;
                txtMediaExp.Visible = false;
            }
            else
            {
                labelMediaExp.Visible = true;
                txtMediaExp.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            txtPrecioCompra.Text = "";
            txtPrecioReembolso.Text = "";
            txtCostoUtilidad.Text = "";
            txtDemandaAnteriorInicial.Text = "";
            txtVentasPerdidas.Text = "";
            txtCantidadOrden.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtMediaN.Text = "";
            txtDesvN.Text = "";
            txtMediaExp.Text = "";
            txtTiempoTotalSimulacion.Text = "";
            txtDesde.Text = "";
            txtDiasAMostrar.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPrecioCompra.Text = "0,8";
            txtPrecioReembolso.Text = "0,2";
            txtCostoUtilidad.Text = "0,4";
            txtDemandaAnteriorInicial.Text = "20";
            txtVentasPerdidas.Text = "3";
            txtCantidadOrden.Text = "21";
            txtA.Text = "10";
            txtB.Text = "30";
            txtMediaN.Text = "20";
            txtDesvN.Text = "5";
            txtMediaExp.Text = "5";
            txtTiempoTotalSimulacion.Text = "200";
            txtDesde.Text = "0";
            txtDiasAMostrar.Text = "200";
        }
    }

}
