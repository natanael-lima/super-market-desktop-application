using Entidades;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

namespace Vista.Principal
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.panelLineBottom = new System.Windows.Forms.Panel();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(13, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Red;
            this.panelLine.Location = new System.Drawing.Point(20, 73);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(880, 2);
            this.panelLine.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Vista.Properties.Resources.icons8_about_24;
            this.pictureBox.Location = new System.Drawing.Point(40, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(250, 100);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(250, 140);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(200, 20);
            this.txtRepeatPassword.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(250, 180);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 30);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Cambiar Contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.lblCurrentUsername);
            this.groupBoxCredentials.Controls.Add(this.lblCurrentPassword);
            this.groupBoxCredentials.Location = new System.Drawing.Point(500, 100);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(300, 120);
            this.groupBoxCredentials.TabIndex = 6;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Credenciales actuales";
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.Location = new System.Drawing.Point(20, 30);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentUsername.TabIndex = 0;
            this.lblCurrentUsername.Text = "Usuario: admin";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Location = new System.Drawing.Point(20, 60);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentPassword.TabIndex = 1;
            this.lblCurrentPassword.Text = "Contraseña: ******";
            // 
            // panelLineBottom
            // 
            this.panelLineBottom.BackColor = System.Drawing.Color.Gray;
            this.panelLineBottom.Location = new System.Drawing.Point(20, 250);
            this.panelLineBottom.Name = "panelLineBottom";
            this.panelLineBottom.Size = new System.Drawing.Size(880, 1);
            this.panelLineBottom.TabIndex = 7;
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(180, 268);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Size = new System.Drawing.Size(300, 20);
            this.txtSystemName.TabIndex = 9;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Location = new System.Drawing.Point(40, 270);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(104, 13);
            this.lblSystemName.TabIndex = 8;
            this.lblSystemName.Text = "Nombre del Sistema:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(912, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 65;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmSetting
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.groupBoxCredentials);
            this.Controls.Add(this.panelLineBottom);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.txtSystemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSetting";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxCredentials.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Panel panelLineBottom;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Label lblSystemName;
        private Button button1;
        private Button btnExit;
    }
}