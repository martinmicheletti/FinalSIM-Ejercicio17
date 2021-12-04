
namespace FinalSIM_Ejercicio17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewSimulacion = new System.Windows.Forms.DataGridView();
            this.NroDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoCompraAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReembolsoAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDiarioAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioReembolso = new System.Windows.Forms.TextBox();
            this.txtCostoUtilidad = new System.Windows.Forms.TextBox();
            this.txtDemandaAnteriorInicial = new System.Windows.Forms.TextBox();
            this.txtTiempoTotalSimulacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVentasPerdidas = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewGrilla = new System.Windows.Forms.DataGridView();
            this.NDiaGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrdenGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemandaGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandaGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoCompraAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReembolsoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReembolsoAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDiarioGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDiarioAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPromedioGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Politica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReembolsoPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPromedioPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.opPoliticaA = new System.Windows.Forms.RadioButton();
            this.opPoliticaB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxDistribucion = new System.Windows.Forms.GroupBox();
            this.opExponencial = new System.Windows.Forms.RadioButton();
            this.opNormal = new System.Windows.Forms.RadioButton();
            this.opUniforme = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasAMostrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrilla)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxDistribucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSimulacion
            // 
            this.dataGridViewSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDia,
            this.CantidadOrden,
            this.RandomDemanda,
            this.Demanda,
            this.VentasPerdidas,
            this.PrecioCompra,
            this.CostoCompraAcumulado,
            this.Reembolso,
            this.ReembolsoAcumulado,
            this.CostoUtilidad,
            this.CostoUtilidadAcumulado,
            this.CostoDiario,
            this.CostoDiarioAcumulado,
            this.CostoPromedio});
            this.dataGridViewSimulacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSimulacion.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSimulacion.Name = "dataGridViewSimulacion";
            this.dataGridViewSimulacion.RowTemplate.Height = 25;
            this.dataGridViewSimulacion.Size = new System.Drawing.Size(1399, 547);
            this.dataGridViewSimulacion.TabIndex = 0;
            // 
            // NroDia
            // 
            this.NroDia.HeaderText = "N° Dia";
            this.NroDia.Name = "NroDia";
            // 
            // CantidadOrden
            // 
            this.CantidadOrden.HeaderText = "Cantidad de Orden";
            this.CantidadOrden.Name = "CantidadOrden";
            // 
            // RandomDemanda
            // 
            this.RandomDemanda.HeaderText = "Random Demanda";
            this.RandomDemanda.Name = "RandomDemanda";
            // 
            // Demanda
            // 
            this.Demanda.HeaderText = "Demanda";
            this.Demanda.Name = "Demanda";
            // 
            // VentasPerdidas
            // 
            this.VentasPerdidas.HeaderText = "Ventas Perdidas";
            this.VentasPerdidas.Name = "VentasPerdidas";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // CostoCompraAcumulado
            // 
            this.CostoCompraAcumulado.HeaderText = "Costo de Compra Acumulado";
            this.CostoCompraAcumulado.Name = "CostoCompraAcumulado";
            // 
            // Reembolso
            // 
            this.Reembolso.HeaderText = "Reembolso";
            this.Reembolso.Name = "Reembolso";
            // 
            // ReembolsoAcumulado
            // 
            this.ReembolsoAcumulado.HeaderText = "Reembolso Acumulado";
            this.ReembolsoAcumulado.Name = "ReembolsoAcumulado";
            // 
            // CostoUtilidad
            // 
            this.CostoUtilidad.HeaderText = "Costo de Utilidad";
            this.CostoUtilidad.Name = "CostoUtilidad";
            // 
            // CostoUtilidadAcumulado
            // 
            this.CostoUtilidadAcumulado.HeaderText = "Costo Utilidad Acumulado";
            this.CostoUtilidadAcumulado.Name = "CostoUtilidadAcumulado";
            // 
            // CostoDiario
            // 
            this.CostoDiario.HeaderText = "Costo Diario";
            this.CostoDiario.Name = "CostoDiario";
            // 
            // CostoDiarioAcumulado
            // 
            this.CostoDiarioAcumulado.HeaderText = "Costo Diario Acumulado";
            this.CostoDiarioAcumulado.Name = "CostoDiarioAcumulado";
            // 
            // CostoPromedio
            // 
            this.CostoPromedio.HeaderText = "Costo Promedio";
            this.CostoPromedio.Name = "CostoPromedio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1257, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar Simulacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickIniciarSimulacion);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(12, 27);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(84, 23);
            this.txtPrecioCompra.TabIndex = 2;
            this.txtPrecioCompra.Text = "0,8";
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrecioReembolso
            // 
            this.txtPrecioReembolso.Location = new System.Drawing.Point(122, 27);
            this.txtPrecioReembolso.MaxLength = 10;
            this.txtPrecioReembolso.Name = "txtPrecioReembolso";
            this.txtPrecioReembolso.Size = new System.Drawing.Size(99, 23);
            this.txtPrecioReembolso.TabIndex = 3;
            this.txtPrecioReembolso.Text = "0,20";
            this.txtPrecioReembolso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtCostoUtilidad
            // 
            this.txtCostoUtilidad.Location = new System.Drawing.Point(250, 27);
            this.txtCostoUtilidad.MaxLength = 10;
            this.txtCostoUtilidad.Name = "txtCostoUtilidad";
            this.txtCostoUtilidad.Size = new System.Drawing.Size(81, 23);
            this.txtCostoUtilidad.TabIndex = 4;
            this.txtCostoUtilidad.Text = "0,4";
            this.txtCostoUtilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtDemandaAnteriorInicial
            // 
            this.txtDemandaAnteriorInicial.Location = new System.Drawing.Point(28, 44);
            this.txtDemandaAnteriorInicial.MaxLength = 10;
            this.txtDemandaAnteriorInicial.Name = "txtDemandaAnteriorInicial";
            this.txtDemandaAnteriorInicial.Size = new System.Drawing.Size(102, 23);
            this.txtDemandaAnteriorInicial.TabIndex = 5;
            this.txtDemandaAnteriorInicial.Text = "20";
            this.txtDemandaAnteriorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtTiempoTotalSimulacion
            // 
            this.txtTiempoTotalSimulacion.Location = new System.Drawing.Point(1014, 51);
            this.txtTiempoTotalSimulacion.MaxLength = 6;
            this.txtTiempoTotalSimulacion.Name = "txtTiempoTotalSimulacion";
            this.txtTiempoTotalSimulacion.Size = new System.Drawing.Size(74, 23);
            this.txtTiempoTotalSimulacion.TabIndex = 6;
            this.txtTiempoTotalSimulacion.Text = "200";
            this.txtTiempoTotalSimulacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Costo utilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Demanda anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ventas perdidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio reembolso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1014, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiempo total";
            // 
            // txtVentasPerdidas
            // 
            this.txtVentasPerdidas.Location = new System.Drawing.Point(157, 44);
            this.txtVentasPerdidas.MaxLength = 10;
            this.txtVentasPerdidas.Name = "txtVentasPerdidas";
            this.txtVentasPerdidas.Size = new System.Drawing.Size(89, 23);
            this.txtVentasPerdidas.TabIndex = 13;
            this.txtVentasPerdidas.Text = "3";
            this.txtVentasPerdidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 119);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1413, 581);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSimulacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1405, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewGrilla);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1405, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grilla Presentación";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGrilla
            // 
            this.dataGridViewGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NDiaGrilla,
            this.CantidadOrdenGrilla,
            this.RandomDemandaGrilla,
            this.DemandaGrilla,
            this.VentasPerdidasGrilla,
            this.PrecioCompraGrilla,
            this.CostoCompraAcumuladoGrilla,
            this.ReembolsoGrilla,
            this.ReembolsoAcumuladoGrilla,
            this.CostoUtilidadGrilla,
            this.CostoUtilidadAcumuladoGrilla,
            this.CostoDiarioGrilla,
            this.CostoDiarioAcumuladoGrilla,
            this.CostoPromedioGrilla});
            this.dataGridViewGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGrilla.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGrilla.Name = "dataGridViewGrilla";
            this.dataGridViewGrilla.RowTemplate.Height = 25;
            this.dataGridViewGrilla.Size = new System.Drawing.Size(1405, 553);
            this.dataGridViewGrilla.TabIndex = 1;
            // 
            // NDiaGrilla
            // 
            this.NDiaGrilla.HeaderText = "N° Dia";
            this.NDiaGrilla.Name = "NDiaGrilla";
            // 
            // CantidadOrdenGrilla
            // 
            this.CantidadOrdenGrilla.HeaderText = "Cantidad de Orden";
            this.CantidadOrdenGrilla.Name = "CantidadOrdenGrilla";
            // 
            // RandomDemandaGrilla
            // 
            this.RandomDemandaGrilla.HeaderText = "Random Demanda";
            this.RandomDemandaGrilla.Name = "RandomDemandaGrilla";
            // 
            // DemandaGrilla
            // 
            this.DemandaGrilla.HeaderText = "Demanda";
            this.DemandaGrilla.Name = "DemandaGrilla";
            // 
            // VentasPerdidasGrilla
            // 
            this.VentasPerdidasGrilla.HeaderText = "Ventas Perdidas";
            this.VentasPerdidasGrilla.Name = "VentasPerdidasGrilla";
            // 
            // PrecioCompraGrilla
            // 
            this.PrecioCompraGrilla.HeaderText = "Precio Compra";
            this.PrecioCompraGrilla.Name = "PrecioCompraGrilla";
            // 
            // CostoCompraAcumuladoGrilla
            // 
            this.CostoCompraAcumuladoGrilla.HeaderText = "Costo de Compra Acumulado";
            this.CostoCompraAcumuladoGrilla.Name = "CostoCompraAcumuladoGrilla";
            // 
            // ReembolsoGrilla
            // 
            this.ReembolsoGrilla.HeaderText = "Reembolso";
            this.ReembolsoGrilla.Name = "ReembolsoGrilla";
            // 
            // ReembolsoAcumuladoGrilla
            // 
            this.ReembolsoAcumuladoGrilla.HeaderText = "Reembolso Acumulado";
            this.ReembolsoAcumuladoGrilla.Name = "ReembolsoAcumuladoGrilla";
            // 
            // CostoUtilidadGrilla
            // 
            this.CostoUtilidadGrilla.HeaderText = "Costo de Utilidad";
            this.CostoUtilidadGrilla.Name = "CostoUtilidadGrilla";
            // 
            // CostoUtilidadAcumuladoGrilla
            // 
            this.CostoUtilidadAcumuladoGrilla.HeaderText = "Costo Utilidad Acumulado";
            this.CostoUtilidadAcumuladoGrilla.Name = "CostoUtilidadAcumuladoGrilla";
            // 
            // CostoDiarioGrilla
            // 
            this.CostoDiarioGrilla.HeaderText = "Costo Diario";
            this.CostoDiarioGrilla.Name = "CostoDiarioGrilla";
            // 
            // CostoDiarioAcumuladoGrilla
            // 
            this.CostoDiarioAcumuladoGrilla.HeaderText = "Costo Diario Acumulado";
            this.CostoDiarioAcumuladoGrilla.Name = "CostoDiarioAcumuladoGrilla";
            // 
            // CostoPromedioGrilla
            // 
            this.CostoPromedioGrilla.HeaderText = "Costo Promedio";
            this.CostoPromedioGrilla.Name = "CostoPromedioGrilla";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1405, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.FechaHora,
            this.Politica,
            this.CantidadDias,
            this.PrecioCompraPolitica,
            this.PrecioReembolsoPolitica,
            this.CostoUtilidadPolitica,
            this.CostoPromedioPolitica});
            this.dataGridViewResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultados.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowTemplate.Height = 25;
            this.dataGridViewResultados.Size = new System.Drawing.Size(1399, 547);
            this.dataGridViewResultados.TabIndex = 0;
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.Name = "N";
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "Fecha y hora";
            this.FechaHora.Name = "FechaHora";
            // 
            // Politica
            // 
            this.Politica.HeaderText = "Politica";
            this.Politica.Name = "Politica";
            // 
            // CantidadDias
            // 
            this.CantidadDias.HeaderText = "Cantidad de Dias";
            this.CantidadDias.Name = "CantidadDias";
            // 
            // PrecioCompraPolitica
            // 
            this.PrecioCompraPolitica.HeaderText = "Precio de Compra";
            this.PrecioCompraPolitica.Name = "PrecioCompraPolitica";
            // 
            // PrecioReembolsoPolitica
            // 
            this.PrecioReembolsoPolitica.HeaderText = "Precio de Reembolso";
            this.PrecioReembolsoPolitica.Name = "PrecioReembolsoPolitica";
            // 
            // CostoUtilidadPolitica
            // 
            this.CostoUtilidadPolitica.HeaderText = "Costo de Utilidad";
            this.CostoUtilidadPolitica.Name = "CostoUtilidadPolitica";
            // 
            // CostoPromedioPolitica
            // 
            this.CostoPromedioPolitica.HeaderText = "Costo Promedio";
            this.CostoPromedioPolitica.Name = "CostoPromedioPolitica";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(321, 337);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(767, 24);
            this.progressBar.TabIndex = 1;
            // 
            // opPoliticaA
            // 
            this.opPoliticaA.AutoSize = true;
            this.opPoliticaA.Checked = true;
            this.opPoliticaA.Location = new System.Drawing.Point(27, 29);
            this.opPoliticaA.Name = "opPoliticaA";
            this.opPoliticaA.Size = new System.Drawing.Size(75, 19);
            this.opPoliticaA.TabIndex = 17;
            this.opPoliticaA.TabStop = true;
            this.opPoliticaA.Text = "Politica A";
            this.opPoliticaA.UseVisualStyleBackColor = true;
            // 
            // opPoliticaB
            // 
            this.opPoliticaB.AutoSize = true;
            this.opPoliticaB.Location = new System.Drawing.Point(27, 54);
            this.opPoliticaB.Name = "opPoliticaB";
            this.opPoliticaB.Size = new System.Drawing.Size(74, 19);
            this.opPoliticaB.TabIndex = 18;
            this.opPoliticaB.Text = "Politica B";
            this.opPoliticaB.UseVisualStyleBackColor = true;
            this.opPoliticaB.CheckedChanged += new System.EventHandler(this.opPoliticaB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDemandaAnteriorInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVentasPerdidas);
            this.groupBox1.Location = new System.Drawing.Point(368, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiciones Iniciales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opPoliticaA);
            this.groupBox2.Controls.Add(this.opPoliticaB);
            this.groupBox2.Location = new System.Drawing.Point(655, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 88);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Políticas de pedidos";
            // 
            // groupBoxDistribucion
            // 
            this.groupBoxDistribucion.Controls.Add(this.opExponencial);
            this.groupBoxDistribucion.Controls.Add(this.opNormal);
            this.groupBoxDistribucion.Controls.Add(this.opUniforme);
            this.groupBoxDistribucion.Location = new System.Drawing.Point(815, 12);
            this.groupBoxDistribucion.Name = "groupBoxDistribucion";
            this.groupBoxDistribucion.Size = new System.Drawing.Size(174, 88);
            this.groupBoxDistribucion.TabIndex = 21;
            this.groupBoxDistribucion.TabStop = false;
            this.groupBoxDistribucion.Text = "Distribucion cantidad orden";
            this.groupBoxDistribucion.Visible = false;
            // 
            // opExponencial
            // 
            this.opExponencial.AutoSize = true;
            this.opExponencial.Location = new System.Drawing.Point(27, 62);
            this.opExponencial.Name = "opExponencial";
            this.opExponencial.Size = new System.Drawing.Size(89, 19);
            this.opExponencial.TabIndex = 19;
            this.opExponencial.Text = "Exponencial";
            this.opExponencial.UseVisualStyleBackColor = true;
            // 
            // opNormal
            // 
            this.opNormal.AutoSize = true;
            this.opNormal.Checked = true;
            this.opNormal.Location = new System.Drawing.Point(27, 19);
            this.opNormal.Name = "opNormal";
            this.opNormal.Size = new System.Drawing.Size(65, 19);
            this.opNormal.TabIndex = 17;
            this.opNormal.TabStop = true;
            this.opNormal.Text = "Normal";
            this.opNormal.UseVisualStyleBackColor = true;
            // 
            // opUniforme
            // 
            this.opUniforme.AutoSize = true;
            this.opUniforme.Location = new System.Drawing.Point(27, 41);
            this.opUniforme.Name = "opUniforme";
            this.opUniforme.Size = new System.Drawing.Size(75, 19);
            this.opUniforme.TabIndex = 18;
            this.opUniforme.Text = "Uniforme";
            this.opUniforme.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1114, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Desde";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(1114, 52);
            this.txtDesde.MaxLength = 6;
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(39, 23);
            this.txtDesde.TabIndex = 22;
            this.txtDesde.Text = "0";
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1170, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mostrar";
            // 
            // txtDiasAMostrar
            // 
            this.txtDiasAMostrar.Location = new System.Drawing.Point(1170, 52);
            this.txtDiasAMostrar.MaxLength = 6;
            this.txtDiasAMostrar.Name = "txtDiasAMostrar";
            this.txtDiasAMostrar.Size = new System.Drawing.Size(37, 23);
            this.txtDiasAMostrar.TabIndex = 24;
            this.txtDiasAMostrar.Text = "200";
            this.txtDiasAMostrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 712);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtDiasAMostrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.groupBoxDistribucion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempoTotalSimulacion);
            this.Controls.Add(this.txtCostoUtilidad);
            this.Controls.Add(this.txtPrecioReembolso);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoadEjercicio17);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrilla)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDistribucion.ResumeLayout(false);
            this.groupBoxDistribucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSimulacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioReembolso;
        private System.Windows.Forms.TextBox txtCostoUtilidad;
        private System.Windows.Forms.TextBox txtDemandaAnteriorInicial;
        private System.Windows.Forms.TextBox txtTiempoTotalSimulacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVentasPerdidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoCompraAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReembolsoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiarioAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedio;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton opPoliticaA;
        private System.Windows.Forms.RadioButton opPoliticaB;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Politica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReembolsoPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedioPolitica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxDistribucion;
        private System.Windows.Forms.RadioButton opExponencial;
        private System.Windows.Forms.RadioButton opNormal;
        private System.Windows.Forms.RadioButton opUniforme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiasAMostrar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDiaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrdenGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemandaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoCompraAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReembolsoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReembolsoAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiarioGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiarioAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedioGrilla;
    }
}

