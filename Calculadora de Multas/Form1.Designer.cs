namespace Calculadora_de_Multas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_feriados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_expensas = new System.Windows.Forms.TextBox();
            this.tb_alquiler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.dtp_hoy = new System.Windows.Forms.DateTimePicker();
            this.dtp_pago = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_dias = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_mora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alquiler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_feriados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_expensas);
            this.groupBox1.Controls.Add(this.tb_alquiler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Feriados";
            // 
            // tb_feriados
            // 
            this.tb_feriados.Location = new System.Drawing.Point(97, 65);
            this.tb_feriados.Name = "tb_feriados";
            this.tb_feriados.Size = new System.Drawing.Size(200, 20);
            this.tb_feriados.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expensas";
            // 
            // tb_expensas
            // 
            this.tb_expensas.Location = new System.Drawing.Point(97, 39);
            this.tb_expensas.Name = "tb_expensas";
            this.tb_expensas.Size = new System.Drawing.Size(200, 20);
            this.tb_expensas.TabIndex = 2;
            // 
            // tb_alquiler
            // 
            this.tb_alquiler.Location = new System.Drawing.Point(97, 13);
            this.tb_alquiler.Name = "tb_alquiler";
            this.tb_alquiler.Size = new System.Drawing.Size(200, 20);
            this.tb_alquiler.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hoy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_calcular);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtp_hoy);
            this.groupBox2.Controls.Add(this.dtp_pago);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(97, 71);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 10;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // dtp_hoy
            // 
            this.dtp_hoy.Location = new System.Drawing.Point(97, 45);
            this.dtp_hoy.Name = "dtp_hoy";
            this.dtp_hoy.Size = new System.Drawing.Size(200, 20);
            this.dtp_hoy.TabIndex = 9;
            // 
            // dtp_pago
            // 
            this.dtp_pago.Location = new System.Drawing.Point(97, 19);
            this.dtp_pago.Name = "dtp_pago";
            this.dtp_pago.Size = new System.Drawing.Size(200, 20);
            this.dtp_pago.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "F. de Pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_dias);
            this.groupBox3.Controls.Add(this.tb_total);
            this.groupBox3.Controls.Add(this.tb_mora);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total";
            // 
            // tb_dias
            // 
            this.tb_dias.Enabled = false;
            this.tb_dias.Location = new System.Drawing.Point(97, 19);
            this.tb_dias.Name = "tb_dias";
            this.tb_dias.Size = new System.Drawing.Size(200, 20);
            this.tb_dias.TabIndex = 13;
            // 
            // tb_total
            // 
            this.tb_total.Enabled = false;
            this.tb_total.Location = new System.Drawing.Point(97, 71);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(200, 20);
            this.tb_total.TabIndex = 16;
            // 
            // tb_mora
            // 
            this.tb_mora.Enabled = false;
            this.tb_mora.Location = new System.Drawing.Point(97, 45);
            this.tb_mora.Name = "tb_mora";
            this.tb_mora.Size = new System.Drawing.Size(200, 20);
            this.tb_mora.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 332);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de Multas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_feriados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_expensas;
        private System.Windows.Forms.TextBox tb_alquiler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_hoy;
        private System.Windows.Forms.DateTimePicker dtp_pago;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_dias;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_mora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

