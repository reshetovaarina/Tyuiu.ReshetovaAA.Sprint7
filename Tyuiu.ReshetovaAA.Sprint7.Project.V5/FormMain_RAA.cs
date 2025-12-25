using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint7.Project.V5.Lib;

namespace Tyuiu.ReshetovaAA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        DataService dataService_RAA = new DataService();

        public FormMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            RefreshGrid(null);
            UpdateStatistics();
            UpdateChart();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelTitle_RAA.Text = "Оптовая база – управление складом";
            labelSubtitle_RAA.Text = "Автор: Решетова Арина";
        }

        // обновление таблицы, статистки и графика

        private void RefreshGrid(List<Product> list)
        {
            if (list == null)
                list = dataService_RAA.Products;

            dataGridViewProducts_RAA.DataSource = null;
            dataGridViewProducts_RAA.DataSource = list;
        }

        private void UpdateStatistics()
        {
            double totalCost = 0;
            double sumPrice = 0;
            int totalQuantity = 0;
            double maxPrice = 0;
            string mostExpName = "Нет";

            List<Product> list = dataService_RAA.Products;

            for (int i = 0; i < list.Count; i++)
            {
                Product p = list[i];

                totalCost += p.Price * p.Quantity;
                sumPrice += p.Price;
                totalQuantity += p.Quantity;

                if (p.Price > maxPrice)
                {
                    maxPrice = p.Price;
                    mostExpName = string.IsNullOrWhiteSpace(p.Name) ? "Без названия" : p.Name;
                }
            }

            double avgPrice = 0;
            if (list.Count > 0)
                avgPrice = sumPrice / list.Count;

            labelTotalCostValue_RAA.Text = totalCost.ToString("0.##");
            labelAveragePriceValue_RAA.Text = avgPrice.ToString("0.##");
            labelMostExpensiveValue_RAA.Text = mostExpName;
            labelTotalQuantityValue_RAA.Text = totalQuantity.ToString();
        }

        private void UpdateChart()
        {
            chartProducts_RAA.Series["SeriesQuantity_RAA"].Points.Clear();

            for (int i = 0; i < dataService_RAA.Products.Count; i++)
            {
                Product p = dataService_RAA.Products[i];

                string xLabel = !string.IsNullOrWhiteSpace(p.Name) ? p.Name : p.Code;

                chartProducts_RAA.Series["SeriesQuantity_RAA"]
                    .Points.AddXY(xLabel, p.Quantity);
            }
        }

        // меню

        private void менюВыход_RAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonLoad_RAA_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV файлы|*.csv|Все файлы|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataService_RAA.LoadFromCsv(ofd.FileName);
                RefreshGrid(null);
                UpdateStatistics();
                UpdateChart();
            }
        }

        private void toolStripButtonSave_RAA_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV файлы|*.csv|Все файлы|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataService_RAA.SaveToCsv(sfd.FileName);
            }
        }

        private void toolStripButtonAdd_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Code = textBoxCode_RAA.Text;
                p.Name = textBoxName_RAA.Text;
                p.Quantity = int.Parse(textBoxQuantity_RAA.Text);
                p.Price = double.Parse(textBoxPrice_RAA.Text);
                p.Note = textBoxNote_RAA.Text;

                dataService_RAA.AddProduct(p);

                RefreshGrid(null);
                UpdateStatistics();
                UpdateChart();

                textBoxCode_RAA.Clear();
                textBoxName_RAA.Clear();
                textBoxQuantity_RAA.Clear();
                textBoxPrice_RAA.Clear();
                textBoxNote_RAA.Clear();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonSearch_RAA_Click(object sender, EventArgs e)
        {
            string text = textBoxSearch_RAA.Text;
            List<Product> result = dataService_RAA.SearchByName(text);
            RefreshGrid(result);
            tabControlMain_RAA.SelectedTab = tabPageProducts_RAA;
        }

        private void buttonResetSearch_RAA_Click(object sender, EventArgs e)
        {
            textBoxSearch_RAA.Clear();
            RefreshGrid(null);
        }

        private void toolStripButtonInfo_RAA_Click(object sender, EventArgs e)
        {
            FormAbout_RAA f = new FormAbout_RAA();
            f.ShowDialog();
        }

        private void менюОПрограмме_RAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonInfo_RAA_Click(sender, e);
        }

        private void менюПомощь_RAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp_RAA f = new FormHelp_RAA();
            f.ShowDialog();
        }

        // фильтр с ценами

        private void buttonApplyFilter_RAA_Click(object sender, EventArgs e)
        {
            double min = 0;
            double max = double.MaxValue;

            bool hasMin = double.TryParse(textBoxMinPrice_RAA.Text, out min);
            bool hasMax = double.TryParse(textBoxMaxPrice_RAA.Text, out max);

            List<Product> result = new List<Product>();

            for (int i = 0; i < dataService_RAA.Products.Count; i++)
            {
                Product p = dataService_RAA.Products[i];
                bool ok = true;

                if (hasMin && p.Price < min) ok = false;
                if (hasMax && p.Price > max) ok = false;

                if (ok)
                    result.Add(p);
            }

            RefreshGrid(result);
            tabControlMain_RAA.SelectedTab = tabPageProducts_RAA;
        }

        private void buttonResetFilter_RAA_Click(object sender, EventArgs e)
        {
            textBoxMinPrice_RAA.Clear();
            textBoxMaxPrice_RAA.Clear();
            RefreshGrid(null);
        }
    }
}
