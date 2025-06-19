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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "25,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "15,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "30,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "20,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "35,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "28,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "10,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "25,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "15,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "30,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "20,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "35,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "28,0,0,0");
            this.roundedPanel7 = new RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundedPanel6 = new RoundedPanel();
            this.btnExport = new Vista.Principal.RoundedButtonStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButtonStyle4 = new Vista.Principal.RoundedButtonStyle();
            this.chartSalesByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMin = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle2 = new Vista.Principal.RoundedButtonStyle();
            this.roundedButtonStyle1 = new Vista.Principal.RoundedButtonStyle();
            this.roundedPanel5 = new RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.dtpMonth = new Vista.Principal.DatePicker();
            this.roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByMonth)).BeginInit();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.BackColor = System.Drawing.Color.White;
            this.roundedPanel7.BorderRadius = 20;
            this.roundedPanel7.Controls.Add(this.label2);
            this.roundedPanel7.Controls.Add(this.chartStock);
            this.roundedPanel7.Location = new System.Drawing.Point(486, 194);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(434, 258);
            this.roundedPanel7.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Productos con stock bajo";
            // 
            // chartStock
            // 
            this.chartStock.BackColor = System.Drawing.Color.Transparent;
            this.chartStock.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea4.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartStock.Legends.Add(legend4);
            this.chartStock.Location = new System.Drawing.Point(3, 48);
            this.chartStock.Name = "chartStock";
            this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Series6";
            this.chartStock.Series.Add(series4);
            this.chartStock.Size = new System.Drawing.Size(428, 210);
            this.chartStock.TabIndex = 22;
            this.chartStock.Text = "chart2";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.White;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.Controls.Add(this.dtpMonth);
            this.roundedPanel6.Controls.Add(this.btnExport);
            this.roundedPanel6.Controls.Add(this.label1);
            this.roundedPanel6.Controls.Add(this.roundedButtonStyle4);
            this.roundedPanel6.Controls.Add(this.chartSalesByMonth);
            this.roundedPanel6.Location = new System.Drawing.Point(21, 478);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(896, 298);
            this.roundedPanel6.TabIndex = 24;
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
            this.btnExport.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(796, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(40, 40);
            this.btnExport.TabIndex = 86;
            this.btnExport.TextColor = System.Drawing.Color.SeaGreen;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas por mes";
            // 
            // roundedButtonStyle4
            // 
            this.roundedButtonStyle4.BackColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle4.BackgroundColor = System.Drawing.Color.Snow;
            this.roundedButtonStyle4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedButtonStyle4.BorderColor = System.Drawing.Color.Firebrick;
            this.roundedButtonStyle4.BorderRadius = 6;
            this.roundedButtonStyle4.BorderSize = 1;
            this.roundedButtonStyle4.FlatAppearance.BorderSize = 0;
            this.roundedButtonStyle4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonStyle4.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonStyle4.ForeColor = System.Drawing.Color.RosyBrown;
            this.roundedButtonStyle4.Image = ((System.Drawing.Image)(resources.GetObject("roundedButtonStyle4.Image")));
            this.roundedButtonStyle4.Location = new System.Drawing.Point(842, 10);
            this.roundedButtonStyle4.Name = "roundedButtonStyle4";
            this.roundedButtonStyle4.Size = new System.Drawing.Size(40, 40);
            this.roundedButtonStyle4.TabIndex = 109;
            this.roundedButtonStyle4.TextColor = System.Drawing.Color.RosyBrown;
            this.roundedButtonStyle4.UseVisualStyleBackColor = false;
            // 
            // chartSalesByMonth
            // 
            this.chartSalesByMonth.BackColor = System.Drawing.Color.Transparent;
            this.chartSalesByMonth.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea5.Name = "ChartArea1";
            this.chartSalesByMonth.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSalesByMonth.Legends.Add(legend5);
            this.chartSalesByMonth.Location = new System.Drawing.Point(34, 51);
            this.chartSalesByMonth.Name = "chartSalesByMonth";
            this.chartSalesByMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            dataPoint15.AxisLabel = "Enero";
            dataPoint16.AxisLabel = "Febrero";
            dataPoint17.AxisLabel = "Marzo";
            dataPoint18.AxisLabel = "Abril";
            dataPoint19.AxisLabel = "Mayo";
            dataPoint20.AxisLabel = "Junio";
            dataPoint21.AxisLabel = "Julio";
            series5.Points.Add(dataPoint15);
            series5.Points.Add(dataPoint16);
            series5.Points.Add(dataPoint17);
            series5.Points.Add(dataPoint18);
            series5.Points.Add(dataPoint19);
            series5.Points.Add(dataPoint20);
            series5.Points.Add(dataPoint21);
            series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series5.YValuesPerPoint = 4;
            this.chartSalesByMonth.Series.Add(series5);
            this.chartSalesByMonth.Size = new System.Drawing.Size(828, 244);
            this.chartSalesByMonth.TabIndex = 22;
            this.chartSalesByMonth.Text = "chart1";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Gray;
            this.btnMin.BackgroundColor = System.Drawing.Color.Gray;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMin.BorderColor = System.Drawing.Color.Snow;
            this.btnMin.BorderRadius = 6;
            this.btnMin.BorderSize = 0;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(831, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(33, 33);
            this.btnMin.TabIndex = 108;
            this.btnMin.TextColor = System.Drawing.Color.White;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Controls.Add(this.label5);
            this.roundedPanel5.Controls.Add(this.chartDashboard);
            this.roundedPanel5.Location = new System.Drawing.Point(18, 194);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(434, 258);
            this.roundedPanel5.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estadísticas del sistema";
            // 
            // chartDashboard
            // 
            this.chartDashboard.BackColor = System.Drawing.Color.Transparent;
            this.chartDashboard.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            this.chartDashboard.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea6.Name = "ChartArea1";
            this.chartDashboard.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartDashboard.Legends.Add(legend6);
            this.chartDashboard.Location = new System.Drawing.Point(3, 48);
            this.chartDashboard.Name = "chartDashboard";
            this.chartDashboard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Color = System.Drawing.Color.Lime;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            dataPoint22.AxisLabel = "Enero";
            dataPoint23.AxisLabel = "Febrero";
            dataPoint24.AxisLabel = "Marzo";
            dataPoint25.AxisLabel = "Abril";
            dataPoint26.AxisLabel = "Mayo";
            dataPoint27.AxisLabel = "Junio";
            dataPoint28.AxisLabel = "Julio";
            series6.Points.Add(dataPoint22);
            series6.Points.Add(dataPoint23);
            series6.Points.Add(dataPoint24);
            series6.Points.Add(dataPoint25);
            series6.Points.Add(dataPoint26);
            series6.Points.Add(dataPoint27);
            series6.Points.Add(dataPoint28);
            series6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series6.YValuesPerPoint = 4;
            this.chartDashboard.Series.Add(series6);
            this.chartDashboard.Size = new System.Drawing.Size(428, 210);
            this.chartDashboard.TabIndex = 22;
            this.chartDashboard.Text = "chart1";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPanel4.BackgroundImage")));
            this.roundedPanel4.BorderRadius = 15;
            this.roundedPanel4.Controls.Add(this.lblSale);
            this.roundedPanel4.Controls.Add(this.labelStock);
            this.roundedPanel4.Location = new System.Drawing.Point(720, 70);
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
            this.roundedPanel3.Location = new System.Drawing.Point(486, 70);
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
            this.roundedPanel2.Location = new System.Drawing.Point(252, 70);
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
            this.roundedPanel1.Location = new System.Drawing.Point(18, 70);
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
            // dtpMonth
            // 
            this.dtpMonth.BorderColor = System.Drawing.Color.Gray;
            this.dtpMonth.BorderSize = 1;
            this.dtpMonth.CustomFormat = "MMMM yyyy";
            this.dtpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(538, 10);
            this.dtpMonth.MinimumSize = new System.Drawing.Size(0, 40);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(144, 40);
            this.dtpMonth.SkinColor = System.Drawing.Color.White;
            this.dtpMonth.TabIndex = 112;
            this.dtpMonth.TextColor = System.Drawing.Color.Gray;
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(945, 800);
            this.Controls.Add(this.roundedPanel7);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.btnMin);
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
            this.roundedPanel7.ResumeLayout(false);
            this.roundedPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByMonth)).EndInit();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private RoundedPanel roundedPanel5;
        private RoundedButtonStyle btnMin;
        private RoundedButtonStyle roundedButtonStyle2;
        private RoundedButtonStyle roundedButtonStyle1;
        private RoundedPanel roundedPanel6;
        private Label label1;
        private RoundedPanel roundedPanel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private Label label2;
        private RoundedButtonStyle btnExport;
        private RoundedButtonStyle roundedButtonStyle4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesByMonth;
        private DatePicker dtpMonth;
    }
}