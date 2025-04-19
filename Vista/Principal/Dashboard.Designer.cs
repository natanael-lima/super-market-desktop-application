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
            this.label1 = new System.Windows.Forms.Label();
            this.labelVentasHoy = new System.Windows.Forms.Label();
            this.panelGanancia = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGanancia = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.panelStock = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panelVentasHoy.Controls.Add(this.label1);
            this.panelVentasHoy.Controls.Add(this.labelVentasHoy);
            this.panelVentasHoy.Location = new System.Drawing.Point(20, 20);
            this.panelVentasHoy.Name = "panelVentasHoy";
            this.panelVentasHoy.Size = new System.Drawing.Size(188, 100);
            this.panelVentasHoy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "51";
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
            this.panelGanancia.Controls.Add(this.label2);
            this.panelGanancia.Controls.Add(this.labelGanancia);
            this.panelGanancia.Location = new System.Drawing.Point(261, 20);
            this.panelGanancia.Name = "panelGanancia";
            this.panelGanancia.Size = new System.Drawing.Size(188, 100);
            this.panelGanancia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "11";
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
            this.panelProductos.Controls.Add(this.label3);
            this.panelProductos.Controls.Add(this.labelProductos);
            this.panelProductos.Location = new System.Drawing.Point(501, 20);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(188, 100);
            this.panelProductos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "4";
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
            this.panelStock.Controls.Add(this.label4);
            this.panelStock.Controls.Add(this.labelStock);
            this.panelStock.Location = new System.Drawing.Point(741, 20);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(168, 100);
            this.panelStock.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "15";
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
            this.panelGraficos.Location = new System.Drawing.Point(20, 140);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(890, 586);
            this.panelGraficos.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-1, 80);
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
            this.chart1.Size = new System.Drawing.Size(889, 505);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(930, 766);
            this.Controls.Add(this.panelVentasHoy);
            this.Controls.Add(this.panelGanancia);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.panelGraficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
    }
}