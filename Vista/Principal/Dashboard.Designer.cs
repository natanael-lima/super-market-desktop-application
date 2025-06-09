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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "25,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "15,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "30,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "20,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "35,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "28,0");
            this.panelVentasHoy = new System.Windows.Forms.Panel();
            this.lblProd = new System.Windows.Forms.Label();
            this.labelVentasHoy = new System.Windows.Forms.Label();
            this.panelGanancia = new System.Windows.Forms.Panel();
            this.lblCat = new System.Windows.Forms.Label();
            this.labelGanancia = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.lblUse = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.panelStock = new System.Windows.Forms.Panel();
            this.lblSale = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelVentasHoy.SuspendLayout();
            this.panelGanancia.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVentasHoy
            // 
            this.panelVentasHoy.BackColor = System.Drawing.Color.White;
            this.panelVentasHoy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelVentasHoy.BackgroundImage")));
            this.panelVentasHoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVentasHoy.Controls.Add(this.lblProd);
            this.panelVentasHoy.Controls.Add(this.labelVentasHoy);
            this.panelVentasHoy.Location = new System.Drawing.Point(21, 75);
            this.panelVentasHoy.Name = "panelVentasHoy";
            this.panelVentasHoy.Size = new System.Drawing.Size(188, 100);
            this.panelVentasHoy.TabIndex = 0;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.Color.White;
            this.lblProd.Location = new System.Drawing.Point(3, 52);
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
            this.labelVentasHoy.Location = new System.Drawing.Point(3, 11);
            this.labelVentasHoy.Name = "labelVentasHoy";
            this.labelVentasHoy.Size = new System.Drawing.Size(89, 19);
            this.labelVentasHoy.TabIndex = 0;
            this.labelVentasHoy.Text = "Productos";
            // 
            // panelGanancia
            // 
            this.panelGanancia.BackColor = System.Drawing.Color.White;
            this.panelGanancia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGanancia.BackgroundImage")));
            this.panelGanancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGanancia.Controls.Add(this.lblCat);
            this.panelGanancia.Controls.Add(this.labelGanancia);
            this.panelGanancia.Location = new System.Drawing.Point(266, 75);
            this.panelGanancia.Name = "panelGanancia";
            this.panelGanancia.Size = new System.Drawing.Size(188, 100);
            this.panelGanancia.TabIndex = 1;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(3, 53);
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
            this.labelGanancia.Location = new System.Drawing.Point(3, 12);
            this.labelGanancia.Name = "labelGanancia";
            this.labelGanancia.Size = new System.Drawing.Size(92, 19);
            this.labelGanancia.TabIndex = 0;
            this.labelGanancia.Text = "Categorias";
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.White;
            this.panelProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelProductos.BackgroundImage")));
            this.panelProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProductos.Controls.Add(this.lblUse);
            this.panelProductos.Controls.Add(this.labelProductos);
            this.panelProductos.Location = new System.Drawing.Point(511, 75);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(188, 100);
            this.panelProductos.TabIndex = 2;
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.BackColor = System.Drawing.Color.Transparent;
            this.lblUse.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUse.ForeColor = System.Drawing.Color.White;
            this.lblUse.Location = new System.Drawing.Point(3, 53);
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
            this.labelProductos.Location = new System.Drawing.Point(3, 12);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(78, 19);
            this.labelProductos.TabIndex = 0;
            this.labelProductos.Text = "Usuarios";
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.Color.White;
            this.panelStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStock.BackgroundImage")));
            this.panelStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStock.Controls.Add(this.lblSale);
            this.panelStock.Controls.Add(this.labelStock);
            this.panelStock.Location = new System.Drawing.Point(756, 75);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(168, 100);
            this.panelStock.TabIndex = 3;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.BackColor = System.Drawing.Color.Transparent;
            this.lblSale.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.White;
            this.lblSale.Location = new System.Drawing.Point(3, 53);
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
            this.labelStock.Location = new System.Drawing.Point(3, 12);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(96, 19);
            this.labelStock.TabIndex = 0;
            this.labelStock.Text = "Ventas Hoy";
            // 
            // panelGraficos
            // 
            this.panelGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraficos.BackColor = System.Drawing.Color.White;
            this.panelGraficos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraficos.Controls.Add(this.label5);
            this.panelGraficos.Controls.Add(this.chart1);
            this.panelGraficos.Location = new System.Drawing.Point(21, 195);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(905, 552);
            this.panelGraficos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Actividades";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 69);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint8.AxisLabel = "Enero";
            dataPoint9.AxisLabel = "Febrero";
            dataPoint10.AxisLabel = "Marzo";
            dataPoint11.AxisLabel = "Abril";
            dataPoint12.AxisLabel = "Mayo";
            dataPoint13.AxisLabel = "Junio";
            dataPoint14.AxisLabel = "Julio";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(889, 432);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(912, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelVentasHoy);
            this.Controls.Add(this.panelGanancia);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.panelGraficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelVentasHoy.ResumeLayout(false);
            this.panelVentasHoy.PerformLayout();
            this.panelGanancia.ResumeLayout(false);
            this.panelGanancia.PerformLayout();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            this.panelGraficos.ResumeLayout(false);
            this.panelGraficos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panelVentasHoy;
        private System.Windows.Forms.Panel panelGanancia;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Panel panelGraficos;
        private System.Windows.Forms.Label labelVentasHoy;
        private System.Windows.Forms.Label labelGanancia;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelStock;
        private Label lblProd;
        private Label lblCat;
        private Label lblUse;
        private Label lblSale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
        private Button btnExit;
    }
}