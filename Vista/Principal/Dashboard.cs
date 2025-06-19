using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vista.Principal
{
    public partial class Dashboard : Form
    {
        private ProductService productService = new ProductService();
        private CategoryService categoryService = new CategoryService();
        private UserService userService = new UserService();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            int userCount = userService.CountAllUsers();
            int categoryCount = categoryService.CountAllCategories();
            int productCount = productService.CountAllProducts();

            lblCat.Text=categoryCount.ToString();
            lblProd.Text=productCount.ToString();
            lblUse.Text= userCount.ToString();
            LoadChartDashboard();
            LoadStockChart();

            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MMMM yyyy"; // Solo muestra mes y año
            dtpMonth.ValueChanged += dtpMonth_ValueChanged;
            LoadSalesChartByMonth(dtpMonth.Value);

        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesChartByMonth(dtpMonth.Value);
        }

        private void LoadSalesChartByMonth(DateTime selectedDate)
        {
            chartSalesByMonth.Series.Clear();
            chartSalesByMonth.Titles.Clear();

            Series series = new Series("Ventas diarias");
            series.ChartType = SeriesChartType.Column;

            // Simular ventas por día para el mes seleccionado
            var random = new Random();
            int daysInMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDay = new DateTime(selectedDate.Year, selectedDate.Month, day);
                int salesAmount = random.Next(0, 10); // Simulación: 0 a 10 ventas por día
                series.Points.AddXY(day, salesAmount);
            }

            chartSalesByMonth.Series.Add(series);
            chartSalesByMonth.Titles.Add($"Ventas - {selectedDate.ToString("MMMM yyyy")}");
            series.IsValueShownAsLabel = true;
        }


        private void LoadChartDashboard()
        {
            // Limpiar datos previos (por si recargás)
            chartDashboard.Series.Clear();
            chartDashboard.Titles.Clear();

            // Crear la serie
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Resumen");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // o Column, Bar, Doughnut...

            // Convertir los valores de los labels
            int prod = int.Parse(lblProd.Text);
            int cat = int.Parse(lblCat.Text);
            int user = int.Parse(lblUse.Text);
            int sale = int.Parse(lblSale.Text);

            // Agregar puntos a la serie
            series.Points.AddXY("Productos", prod);
            series.Points.AddXY("Categorías", cat);
            series.Points.AddXY("Usuarios", user);
            series.Points.AddXY("Ventas", sale);

            // Agregar la serie al gráfico
            chartDashboard.Series.Add(series);

            // Agregar título si querés
            //chartDashboard.Titles.Add("Estadísticas del sistema");

            // Estética opcional
            chartDashboard.Series[0].IsValueShownAsLabel = true; // Muestra los valores sobre el gráfico
        }

        private void LoadStockChart()
        {
            chartStock.Series.Clear();
            chartStock.Titles.Clear();

            Series series = new Series("Stock Bajo");
            series.ChartType = SeriesChartType.Bar;

            // 🧪 Datos ficticios
            var products = new List<(string name, int stock)>
    {
        ("Auriculares JBL", 2),
        ("Teclado Redragon", 1),
        ("Mouse Logitech", 0),
        ("Cargador Samsung", 3),
        ("Cable HDMI", 5),
    };

            foreach (var product in products.OrderBy(p => p.stock))
            {
                int idx = series.Points.AddXY(product.name, product.stock);
                // 🎨 Colores según nivel de stock
                if (product.stock == 1)
                    series.Points[idx].Color = Color.Red;
                else if (product.stock <= 3)
                    series.Points[idx].Color = Color.DarkOrange;
                else
                    series.Points[idx].Color = Color.Gold;
            }

            chartStock.Series.Add(series);
            series.IsValueShownAsLabel = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }
    }
}
