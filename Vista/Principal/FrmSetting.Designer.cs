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
            this.roundedPanel6 = new RoundedPanel();
            this.roundedPanel5 = new RoundedPanel();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.roundedButtonStyle1 = new Vista.Principal.RoundedButtonStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.roundedPanel3 = new RoundedPanel();
            this.roundedPanel2 = new RoundedPanel();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new Vista.Principal.RoundedButtonStyle();
            this.btnExit = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle2 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle3 = new Vista.Principal.RoundedButtonStyle();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.groupBoxCredentials.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
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
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.Snow;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.Location = new System.Drawing.Point(656, 517);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(259, 257);
            this.roundedPanel6.TabIndex = 100;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.Snow;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Controls.Add(this.txtSystemName);
            this.roundedPanel5.Controls.Add(this.lblSystemName);
            this.roundedPanel5.Controls.Add(this.textBox1);
            this.roundedPanel5.Controls.Add(this.label4);
            this.roundedPanel5.Controls.Add(this.textBox2);
            this.roundedPanel5.Controls.Add(this.roundedButtonStyle1);
            this.roundedPanel5.Controls.Add(this.label7);
            this.roundedPanel5.Controls.Add(this.label5);
            this.roundedPanel5.Controls.Add(this.textBox4);
            this.roundedPanel5.Controls.Add(this.textBox3);
            this.roundedPanel5.Controls.Add(this.label6);
            this.roundedPanel5.Location = new System.Drawing.Point(30, 430);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(609, 344);
            this.roundedPanel5.TabIndex = 98;
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(161, 20);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Size = new System.Drawing.Size(174, 20);
            this.txtSystemName.TabIndex = 9;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Location = new System.Drawing.Point(21, 22);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(104, 13);
            this.lblSystemName.TabIndex = 8;
            this.lblSystemName.Text = "Nombre del Sistema:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "CUIT:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 92;
            // 
            // roundedButtonStyle1
            // 
            this.roundedButtonStyle1.BackColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle1.BackgroundColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButtonStyle1.BorderRadius = 6;
            this.roundedButtonStyle1.BorderSize = 0;
            this.roundedButtonStyle1.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle1.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.Location = new System.Drawing.Point(367, 22);
            this.roundedButtonStyle1.Name = "roundedButtonStyle1";
            this.roundedButtonStyle1.Size = new System.Drawing.Size(229, 40);
            this.roundedButtonStyle1.TabIndex = 88;
            this.roundedButtonStyle1.Text = "Cambiar Password";
            this.roundedButtonStyle1.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Direccion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 217);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 96;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Phone";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.Snow;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Controls.Add(this.pictureBox);
            this.roundedPanel4.Location = new System.Drawing.Point(656, 90);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(259, 407);
            this.roundedPanel4.TabIndex = 100;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(32, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 197);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Snow;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Location = new System.Drawing.Point(380, 342);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(259, 67);
            this.roundedPanel3.TabIndex = 99;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Snow;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.groupBoxCredentials);
            this.roundedPanel2.Location = new System.Drawing.Point(380, 90);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(259, 234);
            this.roundedPanel2.TabIndex = 98;
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.lblCurrentUsername);
            this.groupBoxCredentials.Controls.Add(this.lblCurrentPassword);
            this.groupBoxCredentials.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCredentials.Location = new System.Drawing.Point(29, 35);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(203, 96);
            this.groupBoxCredentials.TabIndex = 6;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Credenciales actuales";
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.Location = new System.Drawing.Point(24, 30);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(148, 23);
            this.lblCurrentUsername.TabIndex = 0;
            this.lblCurrentUsername.Text = "Usuario: admin";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Location = new System.Drawing.Point(24, 53);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(148, 23);
            this.lblCurrentPassword.TabIndex = 1;
            this.lblCurrentPassword.Text = "Contraseña: ******";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Snow;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.bunifuMetroTextbox1);
            this.roundedPanel1.Controls.Add(this.bunifuMetroTextbox2);
            this.roundedPanel1.Controls.Add(this.bunifuMetroTextbox3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.btnSearch);
            this.roundedPanel1.Location = new System.Drawing.Point(30, 90);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(335, 319);
            this.roundedPanel1.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Actual Password ";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 2;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(42, 38);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(229, 32);
            this.bunifuMetroTextbox1.TabIndex = 67;
            this.bunifuMetroTextbox1.Text = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 2;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(42, 99);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(229, 32);
            this.bunifuMetroTextbox2.TabIndex = 68;
            this.bunifuMetroTextbox2.Text = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderThickness = 2;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(42, 159);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(229, 32);
            this.bunifuMetroTextbox3.TabIndex = 69;
            this.bunifuMetroTextbox3.Text = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Nuevo Password ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Repetir Nuevo Password ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.BackgroundColor = System.Drawing.Color.Gray;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(42, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(229, 40);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Text = "Cambiar Password";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.BorderColor = System.Drawing.Color.Snow;
            this.btnExit.BorderRadius = 6;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(909, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 97;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // roundedButtonStyle2
            // 
            this.roundedButtonStyle2.BackColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle2.BackgroundColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle2.BorderColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle2.BorderRadius = 6;
            this.roundedButtonStyle2.BorderSize = 0;
            this.roundedButtonStyle2.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.roundedButtonStyle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle2.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle2.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle2.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle2.Image")));
            this.roundedButtonStyle2.Location = new System.Drawing.Point(870, 3);
            this.roundedButtonStyle2.Name = "roundedButtonStyle2";
            this.roundedButtonStyle2.Size = new System.Drawing.Size(33, 33);
            this.roundedButtonStyle2.TabIndex = 101;
            this.roundedButtonStyle2.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle2.UseVisualStyleBackColor = false;
            // 
            // roundedButtonStyle3
            // 
            this.roundedButtonStyle3.BackColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle3.BackgroundColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle3.BorderColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle3.BorderRadius = 6;
            this.roundedButtonStyle3.BorderSize = 0;
            this.roundedButtonStyle3.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.roundedButtonStyle3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle3.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle3.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle3.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle3.Image")));
            this.roundedButtonStyle3.Location = new System.Drawing.Point(831, 3);
            this.roundedButtonStyle3.Name = "roundedButtonStyle3";
            this.roundedButtonStyle3.Size = new System.Drawing.Size(33, 33);
            this.roundedButtonStyle3.TabIndex = 102;
            this.roundedButtonStyle3.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle3.UseVisualStyleBackColor = false;
            // 
            // FrmSetting
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.roundedButtonStyle3);
            this.Controls.Add(this.roundedButtonStyle2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSetting";
            this.Text = "Configuración";
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.groupBoxCredentials.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Label lblSystemName;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private RoundedButtonStyle btnSearch;
        private RoundedButtonStyle roundedButtonStyle1;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel6;
        private RoundedButtonStyle btnExit;
        private RoundedButtonStyle roundedButtonStyle2;
        private RoundedButtonStyle roundedButtonStyle3;
    }
}