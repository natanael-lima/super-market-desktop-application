namespace Vista.Principal
{
    partial class FrmCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnOpenAdd = new Vista.Principal.RoundedButtonStyle();
            this.btnRefresh = new Vista.Principal.RoundedButtonStyle();
            this.btnSearch = new Vista.Principal.RoundedButtonStyle();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roundedButtonStyle1 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle2 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle3 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle4 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle5 = new Vista.Principal.RoundedButtonStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Gestion de Categorias";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeight = 25;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCategory.Location = new System.Drawing.Point(12, 121);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(125)))));
            this.dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.Size = new System.Drawing.Size(920, 667);
            this.dgvCategory.TabIndex = 65;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
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
            this.btnOpenAdd.Location = new System.Drawing.Point(815, 74);
            this.btnOpenAdd.Name = "btnOpenAdd";
            this.btnOpenAdd.Size = new System.Drawing.Size(117, 40);
            this.btnOpenAdd.TabIndex = 67;
            this.btnOpenAdd.Text = "Añadir Nuevo";
            this.btnOpenAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAdd.TextColor = System.Drawing.Color.White;
            this.btnOpenAdd.UseVisualStyleBackColor = false;
            this.btnOpenAdd.Click += new System.EventHandler(this.btnOpenAdd_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(395, 74);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(310, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 40);
            this.btnSearch.TabIndex = 69;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.LineThickness = 2;
            this.txtSearch.Location = new System.Drawing.Point(13, 70);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 44);
            this.txtSearch.TabIndex = 71;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roundedButtonStyle1
            // 
            this.roundedButtonStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.roundedButtonStyle1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.roundedButtonStyle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle1.BorderColor = System.Drawing.Color.Green;
            this.roundedButtonStyle1.BorderRadius = 6;
            this.roundedButtonStyle1.BorderSize = 1;
            this.roundedButtonStyle1.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle1.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle1.Image")));
            this.roundedButtonStyle1.Location = new System.Drawing.Point(486, 74);
            this.roundedButtonStyle1.Name = "roundedButtonStyle1";
            this.roundedButtonStyle1.Size = new System.Drawing.Size(40, 40);
            this.roundedButtonStyle1.TabIndex = 79;
            this.roundedButtonStyle1.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.UseVisualStyleBackColor = false;
            // 
            // roundedButtonStyle2
            // 
            this.roundedButtonStyle2.BackColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle2.BackgroundColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle2.BorderColor = System.Drawing.Color.Firebrick;
            this.roundedButtonStyle2.BorderRadius = 6;
            this.roundedButtonStyle2.BorderSize = 1;
            this.roundedButtonStyle2.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle2.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle2.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle2.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle2.Image")));
            this.roundedButtonStyle2.Location = new System.Drawing.Point(440, 74);
            this.roundedButtonStyle2.Name = "roundedButtonStyle2";
            this.roundedButtonStyle2.Size = new System.Drawing.Size(40, 40);
            this.roundedButtonStyle2.TabIndex = 78;
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
            this.roundedButtonStyle3.TabIndex = 108;
            this.roundedButtonStyle3.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle3.UseVisualStyleBackColor = false;
            // 
            // roundedButtonStyle4
            // 
            this.roundedButtonStyle4.BackColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle4.BackgroundColor = System.Drawing.Color.Gray;
            this.roundedButtonStyle4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle4.BorderColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle4.BorderRadius = 6;
            this.roundedButtonStyle4.BorderSize = 0;
            this.roundedButtonStyle4.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.roundedButtonStyle4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle4.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle4.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle4.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle4.Image")));
            this.roundedButtonStyle4.Location = new System.Drawing.Point(870, 3);
            this.roundedButtonStyle4.Name = "roundedButtonStyle4";
            this.roundedButtonStyle4.Size = new System.Drawing.Size(33, 33);
            this.roundedButtonStyle4.TabIndex = 107;
            this.roundedButtonStyle4.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle4.UseVisualStyleBackColor = false;
            // 
            // roundedButtonStyle5
            // 
            this.roundedButtonStyle5.BackColor = System.Drawing.Color.IndianRed;
            this.roundedButtonStyle5.BackgroundColor = System.Drawing.Color.IndianRed;
            this.roundedButtonStyle5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle5.BorderColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle5.BorderRadius = 6;
            this.roundedButtonStyle5.BorderSize = 0;
            this.roundedButtonStyle5.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.roundedButtonStyle5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle5.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle5.ForeColor = System.Drawing.Color.White;
            this.roundedButtonStyle5.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle5.Image")));
            this.roundedButtonStyle5.Location = new System.Drawing.Point(909, 3);
            this.roundedButtonStyle5.Name = "roundedButtonStyle5";
            this.roundedButtonStyle5.Size = new System.Drawing.Size(33, 33);
            this.roundedButtonStyle5.TabIndex = 106;
            this.roundedButtonStyle5.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle5.UseVisualStyleBackColor = false;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.roundedButtonStyle3);
            this.Controls.Add(this.roundedButtonStyle4);
            this.Controls.Add(this.roundedButtonStyle5);
            this.Controls.Add(this.roundedButtonStyle1);
            this.Controls.Add(this.roundedButtonStyle2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenAdd);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCategory;
        private RoundedButtonStyle btnOpenAdd;
        private RoundedButtonStyle btnRefresh;
        private RoundedButtonStyle btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private RoundedButtonStyle roundedButtonStyle1;
        private RoundedButtonStyle roundedButtonStyle2;
        private RoundedButtonStyle roundedButtonStyle3;
        private RoundedButtonStyle roundedButtonStyle4;
        private RoundedButtonStyle roundedButtonStyle5;
    }
}