using System.Drawing;
using System.Windows.Forms;

namespace Vista.Principal
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "25,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "15,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "30,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "20,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "35,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "28,0");
            this.label5 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.lblSale = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.roundedPanel3 = new RoundedPanel();
            this.lblUse = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.roundedPanel2 = new RoundedPanel();
            this.lblCat = new System.Windows.Forms.Label();
            this.labelGanancia = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.lblProd = new System.Windows.Forms.Label();
            this.labelVentasHoy = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundedPanel5 = new RoundedPanel();
            this.roundedButtonStyle3 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle2 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle1 = new Vista.Principal.RoundedButtonStyle();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.roundedPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Actividades";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel4.BackgroundImage")));
            this.roundedPanel4.BorderRadius = 15;
            this.roundedPanel4.Controls.Add(this.lblSale);
            this.roundedPanel4.Controls.Add(this.labelStock);
            this.roundedPanel4.Location = new System.Drawing.Point(725, 77);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(200, 100);
            this.roundedPanel4.TabIndex = 21;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.BackColor = System.Drawing.Color.Transparent;
            this.lblSale.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.White;
            this.lblSale.Location = new System.Drawing.Point(16, 55);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(44, 32);
            this.lblSale.TabIndex = 4;
            this.lblSale.Text = "15";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(16, 11);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(96, 19);
            this.labelStock.TabIndex = 0;
            this.labelStock.Text = "Ventas Hoy";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel3.BackgroundImage")));
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.Controls.Add(this.lblUse);
            this.roundedPanel3.Controls.Add(this.labelProductos);
            this.roundedPanel3.Location = new System.Drawing.Point(491, 77);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(200, 100);
            this.roundedPanel3.TabIndex = 20;
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.BackColor = System.Drawing.Color.Transparent;
            this.lblUse.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUse.ForeColor = System.Drawing.Color.White;
            this.lblUse.Location = new System.Drawing.Point(18, 55);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(29, 32);
            this.lblUse.TabIndex = 3;
            this.lblUse.Text = "4";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.BackColor = System.Drawing.Color.Transparent;
            this.labelProductos.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.Color.White;
            this.labelProductos.Location = new System.Drawing.Point(18, 11);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(78, 19);
            this.labelProductos.TabIndex = 0;
            this.labelProductos.Text = "Usuarios";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel2.BackgroundImage")));
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.Controls.Add(this.lblCat);
            this.roundedPanel2.Controls.Add(this.labelGanancia);
            this.roundedPanel2.Location = new System.Drawing.Point(257, 77);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(200, 100);
            this.roundedPanel2.TabIndex = 19;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(19, 55);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(43, 32);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "11";
            // 
            // labelGanancia
            // 
            this.labelGanancia.AutoSize = true;
            this.labelGanancia.BackColor = System.Drawing.Color.Transparent;
            this.labelGanancia.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanancia.ForeColor = System.Drawing.Color.White;
            this.labelGanancia.Location = new System.Drawing.Point(19, 11);
            this.labelGanancia.Name = "labelGanancia";
            this.labelGanancia.Size = new System.Drawing.Size(92, 19);
            this.labelGanancia.TabIndex = 0;
            this.labelGanancia.Text = "Categorias";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel1.BackgroundImage")));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.lblProd);
            this.roundedPanel1.Controls.Add(this.labelVentasHoy);
            this.roundedPanel1.Location = new System.Drawing.Point(23, 77);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(200, 100);
            this.roundedPanel1.TabIndex = 18;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.Color.White;
            this.lblProd.Location = new System.Drawing.Point(17, 55);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(44, 32);
            this.lblProd.TabIndex = 1;
            this.lblProd.Text = "51";
            // 
            // labelVentasHoy
            // 
            this.labelVentasHoy.AutoSize = true;
            this.labelVentasHoy.BackColor = System.Drawing.Color.Transparent;
            this.labelVentasHoy.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentasHoy.ForeColor = System.Drawing.Color.White;
            this.labelVentasHoy.Location = new System.Drawing.Point(17, 11);
            this.labelVentasHoy.Name = "labelVentasHoy";
            this.labelVentasHoy.Size = new System.Drawing.Size(89, 19);
            this.labelVentasHoy.TabIndex = 0;
            this.labelVentasHoy.Text = "Productos";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(29, 71);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            dataPoint29.AxisLabel = "Enero";
            dataPoint30.AxisLabel = "Febrero";
            dataPoint31.AxisLabel = "Marzo";
            dataPoint32.AxisLabel = "Abril";
            dataPoint33.AxisLabel = "Mayo";
            dataPoint34.AxisLabel = "Junio";
            dataPoint35.AxisLabel = "Julio";
            series5.Points.Add(dataPoint29);
            series5.Points.Add(dataPoint30);
            series5.Points.Add(dataPoint31);
            series5.Points.Add(dataPoint32);
            series5.Points.Add(dataPoint33);
            series5.Points.Add(dataPoint34);
            series5.Points.Add(dataPoint35);
            series5.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(844, 473);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Controls.Add(this.chart1);
            this.roundedPanel5.Controls.Add(this.label5);
            this.roundedPanel5.Location = new System.Drawing.Point(21, 211);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(902, 565);
            this.roundedPanel5.TabIndex = 23;
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
            this.roundedButtonStyle2.TabIndex = 107;
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
            this.roundedButtonStyle1.TabIndex = 106;
            this.roundedButtonStyle1.TextColor = System.Drawing.Color.White;
            this.roundedButtonStyle1.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.roundedButtonStyle3);
            this.Controls.Add(this.roundedButtonStyle2);
            this.Controls.Add(this.roundedButtonStyle1);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label labelVentasHoy;
        private System.Windows.Forms.Label labelGanancia;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelStock;
        private Label lblProd;
        private Label lblCat;
        private Label lblUse;
        private Label lblSale;
        private Label label5;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RoundedPanel roundedPanel5;
        private RoundedButtonStyle roundedButtonStyle3;
        private RoundedButtonStyle roundedButtonStyle2;
        private RoundedButtonStyle roundedButtonStyle1;
    }
}