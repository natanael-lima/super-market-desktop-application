namespace Vista
{
    partial class FrmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPagado = new System.Windows.Forms.Label();
            this.lblRestante = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Location = new System.Drawing.Point(12, 30);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(120, 40);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.Text = "Efectivo";
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(12, 80);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(120, 40);
            this.btnCredito.TabIndex = 1;
            this.btnCredito.Text = "Tarjeta Crédito";
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(12, 203);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(120, 40);
            this.btnDebito.TabIndex = 2;
            this.btnDebito.Text = "Tarjeta Débito";
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(12, 326);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(120, 40);
            this.btnTransferencia.TabIndex = 3;
            this.btnTransferencia.Text = "Transferencia";
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(12, 376);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(120, 40);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "Código QR";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTotal.Location = new System.Drawing.Point(366, 51);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(261, 60);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$150.500";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPagado
            // 
            this.lblPagado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPagado.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPagado.Location = new System.Drawing.Point(366, 145);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(261, 60);
            this.lblPagado.TabIndex = 6;
            this.lblPagado.Text = "$0.00";
            this.lblPagado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestante
            // 
            this.lblRestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRestante.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRestante.ForeColor = System.Drawing.Color.Red;
            this.lblRestante.Location = new System.Drawing.Point(366, 239);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(261, 60);
            this.lblRestante.TabIndex = 7;
            this.lblRestante.Text = "$0.00";
            this.lblRestante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(197, 448);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 40);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Location = new System.Drawing.Point(317, 448);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 40);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "6.55";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 40);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(138, 135);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 40);
            this.textBox3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total pagado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Restan pagar:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(138, 259);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 40);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(138, 203);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 40);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(138, 326);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 40);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(138, 376);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(136, 40);
            this.textBox7.TabIndex = 19;
            // 
            // FrmPayment
            // 
            this.ClientSize = new System.Drawing.Size(640, 500);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPagado);
            this.Controls.Add(this.lblRestante);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.Label lblRestante;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}