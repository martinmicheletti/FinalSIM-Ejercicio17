
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSimulacion
            // 
            this.dataGridViewSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimulacion.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewSimulacion.Name = "dataGridViewSimulacion";
            this.dataGridViewSimulacion.RowTemplate.Height = 25;
            this.dataGridViewSimulacion.Size = new System.Drawing.Size(1065, 562);
            this.dataGridViewSimulacion.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(968, 12);
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
            // 
            // txtPrecioReembolso
            // 
            this.txtPrecioReembolso.Location = new System.Drawing.Point(122, 27);
            this.txtPrecioReembolso.Name = "txtPrecioReembolso";
            this.txtPrecioReembolso.Size = new System.Drawing.Size(99, 23);
            this.txtPrecioReembolso.TabIndex = 3;
            // 
            // txtCostoUtilidad
            // 
            this.txtCostoUtilidad.Location = new System.Drawing.Point(250, 27);
            this.txtCostoUtilidad.Name = "txtCostoUtilidad";
            this.txtCostoUtilidad.Size = new System.Drawing.Size(81, 23);
            this.txtCostoUtilidad.TabIndex = 4;
            // 
            // txtDemandaAnteriorInicial
            // 
            this.txtDemandaAnteriorInicial.Location = new System.Drawing.Point(476, 27);
            this.txtDemandaAnteriorInicial.Name = "txtDemandaAnteriorInicial";
            this.txtDemandaAnteriorInicial.Size = new System.Drawing.Size(102, 23);
            this.txtDemandaAnteriorInicial.TabIndex = 5;
            // 
            // txtTiempoTotalSimulacion
            // 
            this.txtTiempoTotalSimulacion.Location = new System.Drawing.Point(813, 27);
            this.txtTiempoTotalSimulacion.Name = "txtTiempoTotalSimulacion";
            this.txtTiempoTotalSimulacion.Size = new System.Drawing.Size(74, 23);
            this.txtTiempoTotalSimulacion.TabIndex = 6;
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
            this.label2.Location = new System.Drawing.Point(476, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Demanda anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 9);
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
            this.label6.Location = new System.Drawing.Point(813, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiempo total";
            // 
            // txtVentasPerdidas
            // 
            this.txtVentasPerdidas.Location = new System.Drawing.Point(617, 27);
            this.txtVentasPerdidas.Name = "txtVentasPerdidas";
            this.txtVentasPerdidas.Size = new System.Drawing.Size(89, 23);
            this.txtVentasPerdidas.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 630);
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
            this.Controls.Add(this.dataGridViewSimulacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoadEjercicio17);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimulacion)).EndInit();
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
    }
}

