﻿namespace Vista.Principal
{
    partial class FrmUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnOpenAdd = new Vista.Principal.RoundedButtonStyle();
            this.btnExport = new Vista.Principal.RoundedButtonStyle();
            this.btnPrint = new Vista.Principal.RoundedButtonStyle();
            this.btnSearch = new Vista.Principal.RoundedButtonStyle();
            this.btnRefresh = new Vista.Principal.RoundedButtonStyle();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roundedButtonStyle3 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle2 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle1 = new Vista.Principal.RoundedButtonStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Gestion de Usuarios";
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUser.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.ColumnHeadersHeight = 25;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(12, 121);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUser.Size = new System.Drawing.Size(920, 667);
            this.dgvUser.TabIndex = 46;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // btnOpenAdd
            // 
            this.btnOpenAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            this.btnOpenAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            this.btnOpenAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenAdd.BorderColor = System.Drawing.Color.Purple;
            this.btnOpenAdd.BorderRadius = 6;
            this.btnOpenAdd.BorderSize = 0;
            this.btnOpenAdd.FlatAppearance.BorderSize = 0;
            this.btnOpenAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAdd.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAdd.ForeColor = System.Drawing.Color.White;
            this.btnOpenAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAdd.Image")));
            this.btnOpenAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAdd.Location = new System.Drawing.Point(815, 73);
            this.btnOpenAdd.Name = "btnOpenAdd";
            this.btnOpenAdd.Size = new System.Drawing.Size(117, 40);
            this.btnOpenAdd.TabIndex = 68;
            this.btnOpenAdd.Text = "Añadir Nuevo";
            this.btnOpenAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAdd.TextColor = System.Drawing.Color.White;
            this.btnOpenAdd.UseVisualStyleBackColor = false;
            this.btnOpenAdd.Click += new System.EventHandler(this.btnOpenAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Honeydew;
            this.btnExport.BackgroundColor = System.Drawing.Color.Honeydew;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.BorderColor = System.Drawing.Color.Green;
            this.btnExport.BorderRadius = 6;
            this.btnExport.BorderSize = 1;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(487, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(40, 40);
            this.btnExport.TabIndex = 77;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Snow;
            this.btnPrint.BackgroundColor = System.Drawing.Color.Snow;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.BorderColor = System.Drawing.Color.Firebrick;
            this.btnPrint.BorderRadius = 6;
            this.btnPrint.BorderSize = 1;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(441, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 40);
            this.btnPrint.TabIndex = 76;
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
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
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(308, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 40);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.Gray;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 6;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(395, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(13, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 44);
            this.txtSearch.TabIndex = 78;
            this.txtSearch.Text = "Buscar....";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.roundedButtonStyle3.TabIndex = 105;
            this.roundedButtonStyle3.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle3.UseVisualStyleBackColor = false;
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
            this.roundedButtonStyle2.TabIndex = 104;
            this.roundedButtonStyle2.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle2.UseVisualStyleBackColor = false;
            // 
            // roundedButtonStyle1
            // 
            this.roundedButtonStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.roundedButtonStyle1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.roundedButtonStyle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle1.BorderColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle1.BorderRadius = 6;
            this.roundedButtonStyle1.BorderSize = 0;
            this.roundedButtonStyle1.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.roundedButtonStyle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle1.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle1.Image")));
            this.roundedButtonStyle1.Location = new System.Drawing.Point(909, 3);
            this.roundedButtonStyle1.Name = "roundedButtonStyle1";
            this.roundedButtonStyle1.Size = new System.Drawing.Size(33, 33);
            this.roundedButtonStyle1.TabIndex = 103;
            this.roundedButtonStyle1.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.UseVisualStyleBackColor = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.roundedButtonStyle3);
            this.Controls.Add(this.roundedButtonStyle2);
            this.Controls.Add(this.roundedButtonStyle1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvUser;
        private RoundedButtonStyle btnOpenAdd;
        private RoundedButtonStyle btnExport;
        private RoundedButtonStyle btnPrint;
        private RoundedButtonStyle btnSearch;
        private RoundedButtonStyle btnRefresh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private RoundedButtonStyle roundedButtonStyle3;
        private RoundedButtonStyle roundedButtonStyle2;
        private RoundedButtonStyle roundedButtonStyle1;
    }
}