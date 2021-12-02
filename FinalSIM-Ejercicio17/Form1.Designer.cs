﻿
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.opPoliticaA = new System.Windows.Forms.RadioButton();
            this.opPoliticaB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.txtDemandaAnteriorInicial.Location = new System.Drawing.Point(28, 44);
            this.txtDemandaAnteriorInicial.Name = "txtDemandaAnteriorInicial";
            this.txtDemandaAnteriorInicial.Size = new System.Drawing.Size(102, 23);
            this.txtDemandaAnteriorInicial.TabIndex = 5;
            this.txtDemandaAnteriorInicial.Text = "20";
            // 
            // txtTiempoTotalSimulacion
            // 
            this.txtTiempoTotalSimulacion.Location = new System.Drawing.Point(1136, 45);
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
            this.label6.Location = new System.Drawing.Point(1136, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiempo total";
            // 
            // txtVentasPerdidas
            // 
            this.txtVentasPerdidas.Location = new System.Drawing.Point(157, 44);
            this.txtVentasPerdidas.Name = "txtVentasPerdidas";
            this.txtVentasPerdidas.Size = new System.Drawing.Size(89, 23);
            this.txtVentasPerdidas.TabIndex = 13;
            this.txtVentasPerdidas.Text = "3";
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
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.dataGridViewSimulacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1405, 511);
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
            this.tabPage2.Size = new System.Drawing.Size(1405, 511);
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
            this.dataGridViewResultados.Size = new System.Drawing.Size(1399, 505);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDemandaAnteriorInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVentasPerdidas);
            this.groupBox1.Location = new System.Drawing.Point(547, 9);
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
            this.groupBox2.Location = new System.Drawing.Point(967, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 88);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Políticas de pedidos";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(382, 218);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(543, 24);
            this.progressBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
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
    }
}

