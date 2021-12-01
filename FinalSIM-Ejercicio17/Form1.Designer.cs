
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
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.opPoliticaA = new System.Windows.Forms.RadioButton();
            this.opPoliticaB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.dataGridViewSimulacion.Size = new System.Drawing.Size(1399, 505);
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
            this.button1.Location = new System.Drawing.Point(1312, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar Simulacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickIniciarSimulacion);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(12, 27);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(84, 23);
            this.txtPrecioCompra.TabIndex = 2;
            this.txtPrecioCompra.Text = "0,8";
            // 
            // txtPrecioReembolso
            // 
            this.txtPrecioReembolso.Location = new System.Drawing.Point(122, 27);
            this.txtPrecioReembolso.Name = "txtPrecioReembolso";
            this.txtPrecioReembolso.Size = new System.Drawing.Size(99, 23);
            this.txtPrecioReembolso.TabIndex = 3;
            this.txtPrecioReembolso.Text = "0,20";
            // 
            // txtCostoUtilidad
            // 
            this.txtCostoUtilidad.Location = new System.Drawing.Point(250, 27);
            this.txtCostoUtilidad.Name = "txtCostoUtilidad";
            this.txtCostoUtilidad.Size = new System.Drawing.Size(81, 23);
            this.txtCostoUtilidad.TabIndex = 4;
            this.txtCostoUtilidad.Text = "0,4";
            // 
            // txtDemandaAnteriorInicial
            // 
            this.txtDemandaAnteriorInicial.Location = new System.Drawing.Point(353, 27);
            this.txtDemandaAnteriorInicial.Name = "txtDemandaAnteriorInicial";
            this.txtDemandaAnteriorInicial.Size = new System.Drawing.Size(102, 23);
            this.txtDemandaAnteriorInicial.TabIndex = 5;
            this.txtDemandaAnteriorInicial.Text = "20";
            // 
            // txtTiempoTotalSimulacion
            // 
            this.txtTiempoTotalSimulacion.Location = new System.Drawing.Point(872, 24);
            this.txtTiempoTotalSimulacion.Name = "txtTiempoTotalSimulacion";
            this.txtTiempoTotalSimulacion.Size = new System.Drawing.Size(74, 23);
            this.txtTiempoTotalSimulacion.TabIndex = 6;
            this.txtTiempoTotalSimulacion.Text = "200";
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
            this.label2.Location = new System.Drawing.Point(353, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Demanda anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 9);
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
            this.label6.Location = new System.Drawing.Point(872, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiempo total";
            // 
            // txtVentasPerdidas
            // 
            this.txtVentasPerdidas.Location = new System.Drawing.Point(482, 27);
            this.txtVentasPerdidas.Name = "txtVentasPerdidas";
            this.txtVentasPerdidas.Size = new System.Drawing.Size(89, 23);
            this.txtVentasPerdidas.TabIndex = 13;
            this.txtVentasPerdidas.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Política";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 539);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSimulacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1405, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1405, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // opPoliticaA
            // 
            this.opPoliticaA.AutoSize = true;
            this.opPoliticaA.Location = new System.Drawing.Point(674, 29);
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
            this.opPoliticaB.Location = new System.Drawing.Point(674, 54);
            this.opPoliticaB.Name = "opPoliticaB";
            this.opPoliticaB.Size = new System.Drawing.Size(74, 19);
            this.opPoliticaB.TabIndex = 18;
            this.opPoliticaB.TabStop = true;
            this.opPoliticaB.Text = "Politica B";
            this.opPoliticaB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 630);
            this.Controls.Add(this.opPoliticaB);
            this.Controls.Add(this.opPoliticaA);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVentasPerdidas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempoTotalSimulacion);
            this.Controls.Add(this.txtDemandaAnteriorInicial);
            this.Controls.Add(this.txtCostoUtilidad);
            this.Controls.Add(this.txtPrecioReembolso);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoadEjercicio17);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton opPoliticaA;
        private System.Windows.Forms.RadioButton opPoliticaB;
    }
}

