
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewSimulacion = new System.Windows.Forms.DataGridView();
            this.NroDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomCantidadOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrdenAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandaAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasReembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewGrilla = new System.Windows.Forms.DataGridView();
            this.NDiaGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomCantidadOrdenGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrdenGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrdenAcumGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemandaGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandaGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandaAcumGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasReembolsoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasUtilidadGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoCompraAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReembolsoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReembolsoAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDiarioGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoDiarioAcumuladoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPromedioGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Politica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenesTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistribucionDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandaInicialPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidasInicialPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasTotalesPerdidasReembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasTotalesPerdidasUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompraPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReembolsoPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUtilidadPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPromedioPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotalPolitica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opPoliticaA = new System.Windows.Forms.RadioButton();
            this.opPoliticaB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxOrden = new System.Windows.Forms.GroupBox();
            this.txtCantidadOrden = new System.Windows.Forms.TextBox();
            this.radioButtonCantidadFija = new System.Windows.Forms.RadioButton();
            this.radioButtonCantidadAleatoria = new System.Windows.Forms.RadioButton();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiasAMostrar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelMediaExp = new System.Windows.Forms.Label();
            this.labelDesvN = new System.Windows.Forms.Label();
            this.labelMediaN = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.txtMediaExp = new System.Windows.Forms.TextBox();
            this.txtDesvN = new System.Windows.Forms.TextBox();
            this.txtMediaN = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.radioButtonDemandaPoisson = new System.Windows.Forms.RadioButton();
            this.radioButtonDemandaNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonDemandaExp = new System.Windows.Forms.RadioButton();
            this.radioButtonTablaEnunciado = new System.Windows.Forms.RadioButton();
            this.radioButtonDemandaUniforme = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrilla)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxOrden.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSimulacion
            // 
            this.dataGridViewSimulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDia,
            this.RandomCantidadOrden,
            this.CantidadOrden,
            this.CantidadOrdenAcumulado,
            this.RandomDemanda,
            this.Demanda,
            this.DemandaAcumulada,
            this.VentasPerdidas,
            this.VentasPerdidasReembolso,
            this.VentasPerdidasUtilidad,
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
            this.dataGridViewSimulacion.Size = new System.Drawing.Size(1793, 584);
            this.dataGridViewSimulacion.TabIndex = 0;
            // 
            // NroDia
            // 
            this.NroDia.HeaderText = "N° Dia";
            this.NroDia.Name = "NroDia";
            // 
            // RandomCantidadOrden
            // 
            this.RandomCantidadOrden.HeaderText = "Random Cantidad Orden";
            this.RandomCantidadOrden.Name = "RandomCantidadOrden";
            this.RandomCantidadOrden.Visible = false;
            // 
            // CantidadOrden
            // 
            this.CantidadOrden.HeaderText = "Cantidad de Orden";
            this.CantidadOrden.Name = "CantidadOrden";
            // 
            // CantidadOrdenAcumulado
            // 
            this.CantidadOrdenAcumulado.HeaderText = "Cantidad de Orden Acumulado";
            this.CantidadOrdenAcumulado.Name = "CantidadOrdenAcumulado";
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
            // DemandaAcumulada
            // 
            this.DemandaAcumulada.HeaderText = "Demanda Acumulada";
            this.DemandaAcumulada.Name = "DemandaAcumulada";
            // 
            // VentasPerdidas
            // 
            this.VentasPerdidas.HeaderText = "Ventas Perdidas";
            this.VentasPerdidas.Name = "VentasPerdidas";
            // 
            // VentasPerdidasReembolso
            // 
            this.VentasPerdidasReembolso.HeaderText = "Ventas Perdidas Reembolso";
            this.VentasPerdidasReembolso.Name = "VentasPerdidasReembolso";
            // 
            // VentasPerdidasUtilidad
            // 
            this.VentasPerdidasUtilidad.HeaderText = "Ventas Perdidas Utilidad";
            this.VentasPerdidasUtilidad.Name = "VentasPerdidasUtilidad";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Costo Compra";
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
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1602, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "SIMULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickIniciarSimulacion);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(160, 25);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(45, 26);
            this.txtPrecioCompra.TabIndex = 2;
            this.txtPrecioCompra.Text = "0,8";
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtPrecioReembolso
            // 
            this.txtPrecioReembolso.Location = new System.Drawing.Point(160, 56);
            this.txtPrecioReembolso.MaxLength = 10;
            this.txtPrecioReembolso.Name = "txtPrecioReembolso";
            this.txtPrecioReembolso.Size = new System.Drawing.Size(45, 26);
            this.txtPrecioReembolso.TabIndex = 3;
            this.txtPrecioReembolso.Text = "0,20";
            this.txtPrecioReembolso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtCostoUtilidad
            // 
            this.txtCostoUtilidad.Location = new System.Drawing.Point(160, 86);
            this.txtCostoUtilidad.MaxLength = 10;
            this.txtCostoUtilidad.Name = "txtCostoUtilidad";
            this.txtCostoUtilidad.Size = new System.Drawing.Size(45, 26);
            this.txtCostoUtilidad.TabIndex = 4;
            this.txtCostoUtilidad.Text = "0,4";
            this.txtCostoUtilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtDemandaAnteriorInicial
            // 
            this.txtDemandaAnteriorInicial.Location = new System.Drawing.Point(141, 30);
            this.txtDemandaAnteriorInicial.MaxLength = 10;
            this.txtDemandaAnteriorInicial.Name = "txtDemandaAnteriorInicial";
            this.txtDemandaAnteriorInicial.Size = new System.Drawing.Size(45, 26);
            this.txtDemandaAnteriorInicial.TabIndex = 5;
            this.txtDemandaAnteriorInicial.Text = "20";
            this.txtDemandaAnteriorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // txtTiempoTotalSimulacion
            // 
            this.txtTiempoTotalSimulacion.Location = new System.Drawing.Point(159, 20);
            this.txtTiempoTotalSimulacion.MaxLength = 6;
            this.txtTiempoTotalSimulacion.Name = "txtTiempoTotalSimulacion";
            this.txtTiempoTotalSimulacion.Size = new System.Drawing.Size(39, 26);
            this.txtTiempoTotalSimulacion.TabIndex = 6;
            this.txtTiempoTotalSimulacion.Text = "200";
            this.txtTiempoTotalSimulacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Costo utilidad   $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Demanda inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad de\r\nventas perdidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio reembolso   $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio compra   $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Días a simular";
            // 
            // txtVentasPerdidas
            // 
            this.txtVentasPerdidas.Location = new System.Drawing.Point(141, 62);
            this.txtVentasPerdidas.MaxLength = 10;
            this.txtVentasPerdidas.Name = "txtVentasPerdidas";
            this.txtVentasPerdidas.Size = new System.Drawing.Size(45, 26);
            this.txtVentasPerdidas.TabIndex = 13;
            this.txtVentasPerdidas.Text = "3";
            this.txtVentasPerdidas.TextChanged += new System.EventHandler(this.txtVentasPerdidas_TextChanged);
            this.txtVentasPerdidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(0, 211);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1807, 618);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewGrilla);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1799, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grilla Presentación";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGrilla
            // 
            this.dataGridViewGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NDiaGrilla,
            this.RandomCantidadOrdenGrilla,
            this.CantidadOrdenGrilla,
            this.CantidadOrdenAcumGrilla,
            this.RandomDemandaGrilla,
            this.DemandaGrilla,
            this.DemandaAcumGrilla,
            this.VentasPerdidasGrilla,
            this.VentasPerdidasReembolsoGrilla,
            this.VentasPerdidasUtilidadGrilla,
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
            this.dataGridViewGrilla.Size = new System.Drawing.Size(1799, 590);
            this.dataGridViewGrilla.TabIndex = 1;
            // 
            // NDiaGrilla
            // 
            this.NDiaGrilla.HeaderText = "N° Dia";
            this.NDiaGrilla.Name = "NDiaGrilla";
            // 
            // RandomCantidadOrdenGrilla
            // 
            this.RandomCantidadOrdenGrilla.HeaderText = "Random Cantidad Orden";
            this.RandomCantidadOrdenGrilla.Name = "RandomCantidadOrdenGrilla";
            this.RandomCantidadOrdenGrilla.Visible = false;
            // 
            // CantidadOrdenGrilla
            // 
            this.CantidadOrdenGrilla.HeaderText = "Cantidad de Orden";
            this.CantidadOrdenGrilla.Name = "CantidadOrdenGrilla";
            // 
            // CantidadOrdenAcumGrilla
            // 
            this.CantidadOrdenAcumGrilla.HeaderText = "Cantidad de Orden Acumulado";
            this.CantidadOrdenAcumGrilla.Name = "CantidadOrdenAcumGrilla";
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
            // DemandaAcumGrilla
            // 
            this.DemandaAcumGrilla.HeaderText = "Demanda Acumulada";
            this.DemandaAcumGrilla.Name = "DemandaAcumGrilla";
            // 
            // VentasPerdidasGrilla
            // 
            this.VentasPerdidasGrilla.HeaderText = "Ventas Perdidas";
            this.VentasPerdidasGrilla.Name = "VentasPerdidasGrilla";
            // 
            // VentasPerdidasReembolsoGrilla
            // 
            this.VentasPerdidasReembolsoGrilla.HeaderText = "Ventas Perdidas Reembolso";
            this.VentasPerdidasReembolsoGrilla.Name = "VentasPerdidasReembolsoGrilla";
            // 
            // VentasPerdidasUtilidadGrilla
            // 
            this.VentasPerdidasUtilidadGrilla.HeaderText = "Ventas Perdidas Utilidad";
            this.VentasPerdidasUtilidadGrilla.Name = "VentasPerdidasUtilidadGrilla";
            // 
            // PrecioCompraGrilla
            // 
            this.PrecioCompraGrilla.HeaderText = "Costo Compra";
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSimulacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1799, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1799, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.FechaHora,
            this.Politica,
            this.CantidadDias,
            this.OrdenesTotales,
            this.DistribucionDemanda,
            this.DemandaTotal,
            this.DemandaInicialPolitica,
            this.VentasPerdidasInicialPolitica,
            this.VentasTotalesPerdidasReembolso,
            this.VentasTotalesPerdidasUtilidad,
            this.PrecioCompraPolitica,
            this.PrecioReembolsoPolitica,
            this.CostoUtilidadPolitica,
            this.CostoPromedioPolitica,
            this.CostoTotalPolitica});
            this.dataGridViewResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultados.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowTemplate.Height = 25;
            this.dataGridViewResultados.Size = new System.Drawing.Size(1793, 584);
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
            // OrdenesTotales
            // 
            this.OrdenesTotales.HeaderText = "Cantidad Ordenes Totales";
            this.OrdenesTotales.Name = "OrdenesTotales";
            // 
            // DistribucionDemanda
            // 
            this.DistribucionDemanda.HeaderText = "Distribucion Demanda";
            this.DistribucionDemanda.Name = "DistribucionDemanda";
            // 
            // DemandaTotal
            // 
            this.DemandaTotal.HeaderText = "Demanda Total";
            this.DemandaTotal.Name = "DemandaTotal";
            // 
            // DemandaInicialPolitica
            // 
            this.DemandaInicialPolitica.HeaderText = "Demanda Inicial ";
            this.DemandaInicialPolitica.Name = "DemandaInicialPolitica";
            // 
            // VentasPerdidasInicialPolitica
            // 
            this.VentasPerdidasInicialPolitica.HeaderText = "Ventas Perdidas Iniciales";
            this.VentasPerdidasInicialPolitica.Name = "VentasPerdidasInicialPolitica";
            // 
            // VentasTotalesPerdidasReembolso
            // 
            this.VentasTotalesPerdidasReembolso.HeaderText = "Ventas Totales Perdidas Reembolso";
            this.VentasTotalesPerdidasReembolso.Name = "VentasTotalesPerdidasReembolso";
            // 
            // VentasTotalesPerdidasUtilidad
            // 
            this.VentasTotalesPerdidasUtilidad.HeaderText = "Ventas Totales Perdidas Utilidad";
            this.VentasTotalesPerdidasUtilidad.Name = "VentasTotalesPerdidasUtilidad";
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
            this.CostoPromedioPolitica.HeaderText = "Costo Promedio Diario";
            this.CostoPromedioPolitica.Name = "CostoPromedioPolitica";
            // 
            // CostoTotalPolitica
            // 
            this.CostoTotalPolitica.HeaderText = "Costo Total";
            this.CostoTotalPolitica.Name = "CostoTotalPolitica";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1799, 590);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Enunciado";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // opPoliticaA
            // 
            this.opPoliticaA.AutoSize = true;
            this.opPoliticaA.Checked = true;
            this.opPoliticaA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opPoliticaA.Location = new System.Drawing.Point(32, 25);
            this.opPoliticaA.Name = "opPoliticaA";
            this.opPoliticaA.Size = new System.Drawing.Size(83, 22);
            this.opPoliticaA.TabIndex = 17;
            this.opPoliticaA.TabStop = true;
            this.opPoliticaA.Text = "Politica A";
            this.opPoliticaA.UseVisualStyleBackColor = true;
            // 
            // opPoliticaB
            // 
            this.opPoliticaB.AutoSize = true;
            this.opPoliticaB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opPoliticaB.Location = new System.Drawing.Point(33, 53);
            this.opPoliticaB.Name = "opPoliticaB";
            this.opPoliticaB.Size = new System.Drawing.Size(82, 22);
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
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(788, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 114);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiciones Iniciales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opPoliticaA);
            this.groupBox2.Controls.Add(this.opPoliticaB);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(999, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 91);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Políticas de pedidos";
            // 
            // groupBoxOrden
            // 
            this.groupBoxOrden.Controls.Add(this.txtCantidadOrden);
            this.groupBoxOrden.Controls.Add(this.radioButtonCantidadFija);
            this.groupBoxOrden.Controls.Add(this.radioButtonCantidadAleatoria);
            this.groupBoxOrden.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrden.Location = new System.Drawing.Point(1154, 12);
            this.groupBoxOrden.Name = "groupBoxOrden";
            this.groupBoxOrden.Size = new System.Drawing.Size(209, 91);
            this.groupBoxOrden.TabIndex = 22;
            this.groupBoxOrden.TabStop = false;
            this.groupBoxOrden.Text = "Distribucion cantidad orden";
            this.groupBoxOrden.Visible = false;
            // 
            // txtCantidadOrden
            // 
            this.txtCantidadOrden.Location = new System.Drawing.Point(127, 30);
            this.txtCantidadOrden.MaxLength = 6;
            this.txtCantidadOrden.Name = "txtCantidadOrden";
            this.txtCantidadOrden.Size = new System.Drawing.Size(39, 26);
            this.txtCantidadOrden.TabIndex = 26;
            this.txtCantidadOrden.Text = "21";
            this.txtCantidadOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // radioButtonCantidadFija
            // 
            this.radioButtonCantidadFija.AutoSize = true;
            this.radioButtonCantidadFija.Checked = true;
            this.radioButtonCantidadFija.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCantidadFija.Location = new System.Drawing.Point(19, 31);
            this.radioButtonCantidadFija.Name = "radioButtonCantidadFija";
            this.radioButtonCantidadFija.Size = new System.Drawing.Size(102, 22);
            this.radioButtonCantidadFija.TabIndex = 17;
            this.radioButtonCantidadFija.TabStop = true;
            this.radioButtonCantidadFija.Text = "Cantidad fija";
            this.radioButtonCantidadFija.UseVisualStyleBackColor = true;
            // 
            // radioButtonCantidadAleatoria
            // 
            this.radioButtonCantidadAleatoria.AutoSize = true;
            this.radioButtonCantidadAleatoria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCantidadAleatoria.Location = new System.Drawing.Point(19, 59);
            this.radioButtonCantidadAleatoria.Name = "radioButtonCantidadAleatoria";
            this.radioButtonCantidadAleatoria.Size = new System.Drawing.Size(151, 22);
            this.radioButtonCantidadAleatoria.TabIndex = 18;
            this.radioButtonCantidadAleatoria.Text = "Aleatoria enunciado";
            this.radioButtonCantidadAleatoria.UseVisualStyleBackColor = true;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(159, 52);
            this.txtDesde.MaxLength = 6;
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(39, 26);
            this.txtDesde.TabIndex = 22;
            this.txtDesde.Text = "0";
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(58, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Días a mostrar";
            // 
            // txtDiasAMostrar
            // 
            this.txtDiasAMostrar.Location = new System.Drawing.Point(159, 84);
            this.txtDiasAMostrar.MaxLength = 6;
            this.txtDiasAMostrar.Name = "txtDiasAMostrar";
            this.txtDiasAMostrar.Size = new System.Drawing.Size(39, 26);
            this.txtDiasAMostrar.TabIndex = 24;
            this.txtDiasAMostrar.Text = "200";
            this.txtDiasAMostrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ejercicio 17";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "70120 - Micheletti, Martín";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(11, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 46);
            this.label12.TabIndex = 29;
            this.label12.Text = "Exámen Final\r\nSimulación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPrecioCompra);
            this.groupBox3.Controls.Add(this.txtPrecioReembolso);
            this.groupBox3.Controls.Add(this.txtCostoUtilidad);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(562, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 124);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Costos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTiempoTotalSimulacion);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDiasAMostrar);
            this.groupBox4.Controls.Add(this.txtDesde);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(1369, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 124);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiempo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mostrar desde el día";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelMediaExp);
            this.groupBox5.Controls.Add(this.labelDesvN);
            this.groupBox5.Controls.Add(this.labelMediaN);
            this.groupBox5.Controls.Add(this.labelB);
            this.groupBox5.Controls.Add(this.labelA);
            this.groupBox5.Controls.Add(this.txtMediaExp);
            this.groupBox5.Controls.Add(this.txtDesvN);
            this.groupBox5.Controls.Add(this.txtMediaN);
            this.groupBox5.Controls.Add(this.txtB);
            this.groupBox5.Controls.Add(this.txtA);
            this.groupBox5.Controls.Add(this.radioButtonDemandaPoisson);
            this.groupBox5.Controls.Add(this.radioButtonDemandaNormal);
            this.groupBox5.Controls.Add(this.radioButtonDemandaExp);
            this.groupBox5.Controls.Add(this.radioButtonTablaEnunciado);
            this.groupBox5.Controls.Add(this.radioButtonDemandaUniforme);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(217, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 188);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Demanda";
            // 
            // labelMediaExp
            // 
            this.labelMediaExp.AutoSize = true;
            this.labelMediaExp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMediaExp.Location = new System.Drawing.Point(182, 131);
            this.labelMediaExp.Name = "labelMediaExp";
            this.labelMediaExp.Size = new System.Drawing.Size(47, 18);
            this.labelMediaExp.TabIndex = 30;
            this.labelMediaExp.Text = "Media";
            this.labelMediaExp.Visible = false;
            // 
            // labelDesvN
            // 
            this.labelDesvN.AutoSize = true;
            this.labelDesvN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDesvN.Location = new System.Drawing.Point(224, 86);
            this.labelDesvN.Name = "labelDesvN";
            this.labelDesvN.Size = new System.Drawing.Size(38, 18);
            this.labelDesvN.TabIndex = 29;
            this.labelDesvN.Text = "Desv";
            this.labelDesvN.Visible = false;
            // 
            // labelMediaN
            // 
            this.labelMediaN.AutoSize = true;
            this.labelMediaN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMediaN.Location = new System.Drawing.Point(127, 86);
            this.labelMediaN.Name = "labelMediaN";
            this.labelMediaN.Size = new System.Drawing.Size(47, 18);
            this.labelMediaN.TabIndex = 28;
            this.labelMediaN.Text = "Media";
            this.labelMediaN.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelB.Location = new System.Drawing.Point(247, 55);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(16, 18);
            this.labelB.TabIndex = 27;
            this.labelB.Text = "b";
            this.labelB.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(155, 54);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(15, 18);
            this.labelA.TabIndex = 26;
            this.labelA.Text = "a";
            this.labelA.Visible = false;
            // 
            // txtMediaExp
            // 
            this.txtMediaExp.Location = new System.Drawing.Point(233, 128);
            this.txtMediaExp.MaxLength = 10;
            this.txtMediaExp.Name = "txtMediaExp";
            this.txtMediaExp.Size = new System.Drawing.Size(45, 26);
            this.txtMediaExp.TabIndex = 25;
            this.txtMediaExp.Text = "10";
            this.txtMediaExp.Visible = false;
            this.txtMediaExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // txtDesvN
            // 
            this.txtDesvN.Location = new System.Drawing.Point(268, 83);
            this.txtDesvN.MaxLength = 10;
            this.txtDesvN.Name = "txtDesvN";
            this.txtDesvN.Size = new System.Drawing.Size(45, 26);
            this.txtDesvN.TabIndex = 24;
            this.txtDesvN.Text = "5";
            this.txtDesvN.Visible = false;
            this.txtDesvN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // txtMediaN
            // 
            this.txtMediaN.Location = new System.Drawing.Point(176, 83);
            this.txtMediaN.MaxLength = 10;
            this.txtMediaN.Name = "txtMediaN";
            this.txtMediaN.Size = new System.Drawing.Size(45, 26);
            this.txtMediaN.TabIndex = 23;
            this.txtMediaN.Text = "20";
            this.txtMediaN.Visible = false;
            this.txtMediaN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(268, 51);
            this.txtB.MaxLength = 10;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(45, 26);
            this.txtB.TabIndex = 22;
            this.txtB.Text = "25";
            this.txtB.Visible = false;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(176, 51);
            this.txtA.MaxLength = 10;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(45, 26);
            this.txtA.TabIndex = 14;
            this.txtA.Text = "10";
            this.txtA.Visible = false;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInt_KeyPress);
            // 
            // radioButtonDemandaPoisson
            // 
            this.radioButtonDemandaPoisson.AutoSize = true;
            this.radioButtonDemandaPoisson.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDemandaPoisson.Location = new System.Drawing.Point(24, 149);
            this.radioButtonDemandaPoisson.Name = "radioButtonDemandaPoisson";
            this.radioButtonDemandaPoisson.Size = new System.Drawing.Size(74, 22);
            this.radioButtonDemandaPoisson.TabIndex = 21;
            this.radioButtonDemandaPoisson.Text = "Poisson";
            this.radioButtonDemandaPoisson.UseVisualStyleBackColor = true;
            this.radioButtonDemandaPoisson.CheckedChanged += new System.EventHandler(this.radioButtonDemandaUniforme_CheckedChanged);
            // 
            // radioButtonDemandaNormal
            // 
            this.radioButtonDemandaNormal.AutoSize = true;
            this.radioButtonDemandaNormal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDemandaNormal.Location = new System.Drawing.Point(24, 84);
            this.radioButtonDemandaNormal.Name = "radioButtonDemandaNormal";
            this.radioButtonDemandaNormal.Size = new System.Drawing.Size(72, 22);
            this.radioButtonDemandaNormal.TabIndex = 20;
            this.radioButtonDemandaNormal.Text = "Normal";
            this.radioButtonDemandaNormal.UseVisualStyleBackColor = true;
            this.radioButtonDemandaNormal.CheckedChanged += new System.EventHandler(this.radioButtonDemandaUniforme_CheckedChanged);
            // 
            // radioButtonDemandaExp
            // 
            this.radioButtonDemandaExp.AutoSize = true;
            this.radioButtonDemandaExp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDemandaExp.Location = new System.Drawing.Point(24, 117);
            this.radioButtonDemandaExp.Name = "radioButtonDemandaExp";
            this.radioButtonDemandaExp.Size = new System.Drawing.Size(101, 22);
            this.radioButtonDemandaExp.TabIndex = 19;
            this.radioButtonDemandaExp.Text = "Exponencial";
            this.radioButtonDemandaExp.UseVisualStyleBackColor = true;
            this.radioButtonDemandaExp.CheckedChanged += new System.EventHandler(this.radioButtonDemandaUniforme_CheckedChanged);
            // 
            // radioButtonTablaEnunciado
            // 
            this.radioButtonTablaEnunciado.AutoSize = true;
            this.radioButtonTablaEnunciado.Checked = true;
            this.radioButtonTablaEnunciado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTablaEnunciado.Location = new System.Drawing.Point(24, 25);
            this.radioButtonTablaEnunciado.Name = "radioButtonTablaEnunciado";
            this.radioButtonTablaEnunciado.Size = new System.Drawing.Size(125, 22);
            this.radioButtonTablaEnunciado.TabIndex = 17;
            this.radioButtonTablaEnunciado.TabStop = true;
            this.radioButtonTablaEnunciado.Text = "Tabla Enunciado";
            this.radioButtonTablaEnunciado.UseVisualStyleBackColor = true;
            this.radioButtonTablaEnunciado.CheckedChanged += new System.EventHandler(this.radioButtonDemandaUniforme_CheckedChanged);
            // 
            // radioButtonDemandaUniforme
            // 
            this.radioButtonDemandaUniforme.AutoSize = true;
            this.radioButtonDemandaUniforme.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDemandaUniforme.Location = new System.Drawing.Point(24, 53);
            this.radioButtonDemandaUniforme.Name = "radioButtonDemandaUniforme";
            this.radioButtonDemandaUniforme.Size = new System.Drawing.Size(85, 22);
            this.radioButtonDemandaUniforme.TabIndex = 18;
            this.radioButtonDemandaUniforme.Text = "Uniforme";
            this.radioButtonDemandaUniforme.UseVisualStyleBackColor = true;
            this.radioButtonDemandaUniforme.CheckedChanged += new System.EventHandler(this.radioButtonDemandaUniforme_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1602, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 39);
            this.button2.TabIndex = 33;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1602, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 39);
            this.button3.TabIndex = 34;
            this.button3.Text = "Cargar ejemplo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "09/12/2021";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(344, 313);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1053, 23);
            this.progressBar.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 813);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBoxOrden);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Examen Final Simulacion - Ejercicio 17 ";
            this.Load += new System.EventHandler(this.OnLoadEjercicio17);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrilla)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxOrden.ResumeLayout(false);
            this.groupBoxOrden.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton opPoliticaA;
        private System.Windows.Forms.RadioButton opPoliticaB;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        //private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiasAMostrar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewGrilla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomCantidadOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrdenAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasReembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoCompraAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReembolsoAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiarioAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedio;
        private System.Windows.Forms.GroupBox groupBoxOrden;
        private System.Windows.Forms.TextBox txtCantidadOrden;
        private System.Windows.Forms.RadioButton radioButtonCantidadFija;
        private System.Windows.Forms.RadioButton radioButtonCantidadAleatoria;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonDemandaExp;
        private System.Windows.Forms.RadioButton radioButtonTablaEnunciado;
        private System.Windows.Forms.RadioButton radioButtonDemandaUniforme;
        private System.Windows.Forms.TextBox txtMediaExp;
        private System.Windows.Forms.TextBox txtDesvN;
        private System.Windows.Forms.TextBox txtMediaN;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RadioButton radioButtonDemandaPoisson;
        private System.Windows.Forms.RadioButton radioButtonDemandaNormal;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelMediaExp;
        private System.Windows.Forms.Label labelDesvN;
        private System.Windows.Forms.Label labelMediaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Politica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenesTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistribucionDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandaInicialPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasInicialPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasTotalesPerdidasReembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasTotalesPerdidasUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReembolsoPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedioPolitica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotalPolitica;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDiaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomCantidadOrdenGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrdenGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrdenAcumGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemandaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandaAcumGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasReembolsoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidasUtilidadGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompraGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoCompraAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReembolsoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReembolsoAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUtilidadAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiarioGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoDiarioAcumuladoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPromedioGrilla;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

