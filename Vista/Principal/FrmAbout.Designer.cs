namespace Vista.Principal
{
    partial class FrmAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(17, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SUPSUP Supermarket Gestor";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(40, 60);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(72, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versión: 1.0.0";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(40, 80);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(158, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Desarrollado por: Natanael Lima";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(40, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(220, 60);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Gestor diseñado para facilitar el manejo de inventario, ventas y clientes en supe" +
    "rmercados pequeños y medianos.";
            // 
            // lblWarning
            // 
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(40, 180);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(220, 40);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "⚠️ Este sistema debe ser manejado por personal autorizado. Realice copias de segu" +
    "ridad regularmente.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAbout
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnClose;

    } 
}