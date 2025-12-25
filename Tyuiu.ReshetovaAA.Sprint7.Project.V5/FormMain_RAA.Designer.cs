using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ReshetovaAA.Sprint7.Project.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        // меню
        private MenuStrip menuStripMain_RAA;
        private ToolStripMenuItem менюФайл_RAAToolStripMenuItem;
        private ToolStripMenuItem менюВыход_RAAToolStripMenuItem;
        private ToolStripMenuItem менюСправка_RAAToolStripMenuItem;
        private ToolStripMenuItem менюОПрограмме_RAAToolStripMenuItem;
        private ToolStripMenuItem менюПомощь_RAAToolStripMenuItem;

        // тулбар
        private ToolStrip toolStripMain_RAA;
        private ToolStripButton toolStripButtonLoad_RAA;
        private ToolStripButton toolStripButtonSave_RAA;
        private ToolStripButton toolStripButtonAdd_RAA;
        private ToolStripSeparator toolStripSeparator1_RAA;
        private ToolStripButton toolStripButtonSearch_RAA;
        private ToolStripButton toolStripButtonInfo_RAA;

        // статус-бар
        private StatusStrip statusStripMain_RAA;
        private ToolStripStatusLabel toolStripStatusLabelInfo_RAA;

        // layout
        private TableLayoutPanel tableLayoutMain_RAA;
        internal Label labelTitle_RAA;
        internal Label labelSubtitle_RAA;
        private TabControl tabControlMain_RAA;

        // вкладки
        internal TabPage tabPageProducts_RAA;
        internal TabPage tabPageSuppliers_RAA;
        internal TabPage tabPageStats_RAA;

        // вкладка "Товары"
        private Panel panelProductsTop_RAA;
        private GroupBox groupBoxInput_RAA;
        private TableLayoutPanel tableLayoutInput_RAA;
        private Label labelCode_RAA;
        private Label labelName_RAA;
        private Label labelQuantity_RAA;
        private Label labelPrice_RAA;
        private Label labelNote_RAA;
        internal TextBox textBoxCode_RAA;
        internal TextBox textBoxName_RAA;
        internal TextBox textBoxQuantity_RAA;
        internal TextBox textBoxPrice_RAA;
        internal TextBox textBoxNote_RAA;

        private GroupBox groupBoxSearch_RAA;
        internal TextBox textBoxSearch_RAA;
        private Button buttonResetSearch_RAA;

        // фильтр на вкладке "Товары"
        private GroupBox groupBoxFilter_RAA;
        private Label labelMinPrice_RAA;
        private Label labelMaxPrice_RAA;
        internal TextBox textBoxMinPrice_RAA;
        internal TextBox textBoxMaxPrice_RAA;
        private Button buttonApplyFilter_RAA;
        private Button buttonResetFilter_RAA;

        internal DataGridView dataGridViewProducts_RAA;

        // вкладка "Поставщики"
        private Label labelSuppliersInfo_RAA;

        // вкладка "Статистика"
        private GroupBox groupBoxStats_RAA;
        private Label labelTotalCostTitle_RAA;
        internal Label labelTotalCostValue_RAA;
        private Label labelAveragePriceTitle_RAA;
        internal Label labelAveragePriceValue_RAA;
        private Label labelMostExpensiveTitle_RAA;
        internal Label labelMostExpensiveValue_RAA;
        private Label labelTotalQuantityTitle_RAA;
        internal Label labelTotalQuantityValue_RAA;

        private GroupBox groupBoxChart_RAA;
        internal Chart chartProducts_RAA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // меню
            menuStripMain_RAA = new MenuStrip();
            менюФайл_RAAToolStripMenuItem = new ToolStripMenuItem();
            менюВыход_RAAToolStripMenuItem = new ToolStripMenuItem();
            менюСправка_RAAToolStripMenuItem = new ToolStripMenuItem();
            менюОПрограмме_RAAToolStripMenuItem = new ToolStripMenuItem();
            менюПомощь_RAAToolStripMenuItem = new ToolStripMenuItem();

            менюФайл_RAAToolStripMenuItem.Text = "Файл";
            менюВыход_RAAToolStripMenuItem.Text = "Выход";
            менюВыход_RAAToolStripMenuItem.Click += менюВыход_RAAToolStripMenuItem_Click;
            менюФайл_RAAToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[] { менюВыход_RAAToolStripMenuItem });

            менюСправка_RAAToolStripMenuItem.Text = "Справка";
            менюОПрограмме_RAAToolStripMenuItem.Text = "О программе";
            менюОПрограмме_RAAToolStripMenuItem.Click += менюОПрограмме_RAAToolStripMenuItem_Click;
            менюПомощь_RAAToolStripMenuItem.Text = "Помощь";
            менюПомощь_RAAToolStripMenuItem.Click += менюПомощь_RAAToolStripMenuItem_Click;
            менюСправка_RAAToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[] { менюОПрограмме_RAAToolStripMenuItem, менюПомощь_RAAToolStripMenuItem });

            menuStripMain_RAA.Items.AddRange(new ToolStripItem[]
            {
                менюФайл_RAAToolStripMenuItem,
                менюСправка_RAAToolStripMenuItem
            });
            menuStripMain_RAA.Location = new Point(0, 0);
            menuStripMain_RAA.Size = new Size(1000, 24);

            // тулбар
            toolStripMain_RAA = new ToolStrip();
            toolStripMain_RAA.ImageScalingSize = new Size(24, 24);

            toolStripButtonLoad_RAA = new ToolStripButton();
            toolStripButtonSave_RAA = new ToolStripButton();
            toolStripButtonAdd_RAA = new ToolStripButton();
            toolStripSeparator1_RAA = new ToolStripSeparator();
            toolStripButtonSearch_RAA = new ToolStripButton();
            toolStripButtonInfo_RAA = new ToolStripButton();

            toolStripButtonLoad_RAA.Image = Properties.Resources.icon_load;
            toolStripButtonLoad_RAA.Text = "Загрузить";
            toolStripButtonLoad_RAA.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButtonLoad_RAA.Click += toolStripButtonLoad_RAA_Click;

            toolStripButtonSave_RAA.Image = Properties.Resources.icon_save;
            toolStripButtonSave_RAA.Text = "Сохранить";
            toolStripButtonSave_RAA.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButtonSave_RAA.Click += toolStripButtonSave_RAA_Click;

            toolStripButtonAdd_RAA.Image = Properties.Resources.icon_add;
            toolStripButtonAdd_RAA.Text = "Добавить";
            toolStripButtonAdd_RAA.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButtonAdd_RAA.Click += toolStripButtonAdd_RAA_Click;

            toolStripButtonSearch_RAA.Image = Properties.Resources.icon_search;
            toolStripButtonSearch_RAA.Text = "Найти";
            toolStripButtonSearch_RAA.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButtonSearch_RAA.Click += toolStripButtonSearch_RAA_Click;

            toolStripButtonInfo_RAA.Alignment = ToolStripItemAlignment.Right;
            toolStripButtonInfo_RAA.Image = Properties.Resources.icon_info;
            toolStripButtonInfo_RAA.Text = "О программе";
            toolStripButtonInfo_RAA.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButtonInfo_RAA.Click += toolStripButtonInfo_RAA_Click;

            toolStripMain_RAA.Items.AddRange(new ToolStripItem[]
            {
                toolStripButtonLoad_RAA,
                toolStripButtonSave_RAA,
                toolStripButtonAdd_RAA,
                toolStripSeparator1_RAA,
                toolStripButtonSearch_RAA,
                toolStripButtonInfo_RAA
            });
            toolStripMain_RAA.Location = new Point(0, 24);
            toolStripMain_RAA.Size = new Size(1000, 31);

            // статус-бар
            statusStripMain_RAA = new StatusStrip();
            toolStripStatusLabelInfo_RAA = new ToolStripStatusLabel();
            toolStripStatusLabelInfo_RAA.Text = "Готово к работе: Оптовая база";
            statusStripMain_RAA.Items.Add(toolStripStatusLabelInfo_RAA);
            statusStripMain_RAA.Location = new Point(0, 579);
            statusStripMain_RAA.Size = new Size(1000, 22);

            // заголовки
            labelTitle_RAA = new Label();
            labelSubtitle_RAA = new Label();

            labelTitle_RAA.AutoSize = true;
            labelTitle_RAA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTitle_RAA.Text = "Оптовая база – управление складом";
            labelTitle_RAA.Dock = DockStyle.Top;
            labelTitle_RAA.Padding = new Padding(10, 10, 10, 0);

            labelSubtitle_RAA.AutoSize = true;
            labelSubtitle_RAA.Font = new Font("Segoe UI", 9F);
            labelSubtitle_RAA.Text = "Автор: Решетова Арина";
            labelSubtitle_RAA.Dock = DockStyle.Top;
            labelSubtitle_RAA.Padding = new Padding(10, 0, 10, 5);

            // табконтроль
            tabControlMain_RAA = new TabControl();
            tabPageProducts_RAA = new TabPage();
            tabPageSuppliers_RAA = new TabPage();
            tabPageStats_RAA = new TabPage();

            tabControlMain_RAA.Dock = DockStyle.Fill;
            tabControlMain_RAA.Font = new Font("Segoe UI", 9F);
            tabControlMain_RAA.Controls.Add(tabPageProducts_RAA);
            tabControlMain_RAA.Controls.Add(tabPageSuppliers_RAA);
            tabControlMain_RAA.Controls.Add(tabPageStats_RAA);

            tabPageProducts_RAA.Text = "Товары";
            tabPageSuppliers_RAA.Text = "Поставщики";
            tabPageStats_RAA.Text = "Статистика";

            // вкладка с товарами
            tabPageProducts_RAA.Padding = new Padding(3);

            panelProductsTop_RAA = new Panel();
            panelProductsTop_RAA.Dock = DockStyle.Top;
            panelProductsTop_RAA.Height = 150;
            panelProductsTop_RAA.Padding = new Padding(10);

            groupBoxInput_RAA = new GroupBox();
            groupBoxInput_RAA.Text = "Добавление товара";
            groupBoxInput_RAA.Dock = DockStyle.Fill;

            groupBoxSearch_RAA = new GroupBox();
            groupBoxSearch_RAA.Text = "Поиск по названию";
            groupBoxSearch_RAA.Dock = DockStyle.Right;
            groupBoxSearch_RAA.Width = 220;

            groupBoxFilter_RAA = new GroupBox();
            groupBoxFilter_RAA.Text = "Фильтр по цене";
            groupBoxFilter_RAA.Dock = DockStyle.Right;
            groupBoxFilter_RAA.Width = 220;

            // сетка ввода
            tableLayoutInput_RAA = new TableLayoutPanel();
            tableLayoutInput_RAA.ColumnCount = 5;
            tableLayoutInput_RAA.RowCount = 2;
            tableLayoutInput_RAA.Dock = DockStyle.Fill;
            for (int i = 0; i < 5; i++)
                tableLayoutInput_RAA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutInput_RAA.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutInput_RAA.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));

            labelCode_RAA = new Label();
            labelName_RAA = new Label();
            labelQuantity_RAA = new Label();
            labelPrice_RAA = new Label();
            labelNote_RAA = new Label();

            labelCode_RAA.Text = "Код";
            labelName_RAA.Text = "Название";
            labelQuantity_RAA.Text = "Кол-во";
            labelPrice_RAA.Text = "Цена";
            labelNote_RAA.Text = "Примечание";

            Label[] headers = { labelCode_RAA, labelName_RAA, labelQuantity_RAA, labelPrice_RAA, labelNote_RAA };
            for (int i = 0; i < headers.Length; i++)
            {
                headers[i].Dock = DockStyle.Fill;
                headers[i].TextAlign = ContentAlignment.MiddleCenter;
                headers[i].Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                tableLayoutInput_RAA.Controls.Add(headers[i], i, 0);
            }

            textBoxCode_RAA = new TextBox();
            textBoxName_RAA = new TextBox();
            textBoxQuantity_RAA = new TextBox();
            textBoxPrice_RAA = new TextBox();
            textBoxNote_RAA = new TextBox();

            textBoxCode_RAA.Dock = DockStyle.Fill;
            textBoxName_RAA.Dock = DockStyle.Fill;
            textBoxQuantity_RAA.Dock = DockStyle.Fill;
            textBoxPrice_RAA.Dock = DockStyle.Fill;
            textBoxNote_RAA.Dock = DockStyle.Fill;

            tableLayoutInput_RAA.Controls.Add(textBoxCode_RAA, 0, 1);
            tableLayoutInput_RAA.Controls.Add(textBoxName_RAA, 1, 1);
            tableLayoutInput_RAA.Controls.Add(textBoxQuantity_RAA, 2, 1);
            tableLayoutInput_RAA.Controls.Add(textBoxPrice_RAA, 3, 1);
            tableLayoutInput_RAA.Controls.Add(textBoxNote_RAA, 4, 1);

            groupBoxInput_RAA.Controls.Add(tableLayoutInput_RAA);

            // поиск
            textBoxSearch_RAA = new TextBox();
            textBoxSearch_RAA.Location = new Point(15, 25);
            textBoxSearch_RAA.Width = 190;

            buttonResetSearch_RAA = new Button();
            buttonResetSearch_RAA.Text = "Сброс поиска";
            buttonResetSearch_RAA.Location = new Point(15, 55);
            buttonResetSearch_RAA.Width = 190;
            buttonResetSearch_RAA.Click += buttonResetSearch_RAA_Click;

            groupBoxSearch_RAA.Controls.Add(textBoxSearch_RAA);
            groupBoxSearch_RAA.Controls.Add(buttonResetSearch_RAA);

            // фильтр по цене 
            labelMinPrice_RAA = new Label();
            labelMaxPrice_RAA = new Label();
            textBoxMinPrice_RAA = new TextBox();
            textBoxMaxPrice_RAA = new TextBox();
            buttonApplyFilter_RAA = new Button();
            buttonResetFilter_RAA = new Button();

            labelMinPrice_RAA.Text = "Мин. цена:";
            labelMinPrice_RAA.Location = new Point(15, 25);
            textBoxMinPrice_RAA.Location = new Point(15, 45);
            textBoxMinPrice_RAA.Width = 190;

            labelMaxPrice_RAA.Text = "Макс. цена:";
            labelMaxPrice_RAA.Location = new Point(15, 75);
            textBoxMaxPrice_RAA.Location = new Point(15, 95);
            textBoxMaxPrice_RAA.Width = 190;

            buttonApplyFilter_RAA.Text = "Применить";
            buttonApplyFilter_RAA.Location = new Point(15, 125);
            buttonApplyFilter_RAA.Width = 190;
            buttonApplyFilter_RAA.Click += buttonApplyFilter_RAA_Click;

            buttonResetFilter_RAA.Text = "Сбросить фильтр";
            buttonResetFilter_RAA.Location = new Point(15, 155);
            buttonResetFilter_RAA.Width = 190;
            buttonResetFilter_RAA.Click += buttonResetFilter_RAA_Click;

            groupBoxFilter_RAA.Controls.Add(labelMinPrice_RAA);
            groupBoxFilter_RAA.Controls.Add(textBoxMinPrice_RAA);
            groupBoxFilter_RAA.Controls.Add(labelMaxPrice_RAA);
            groupBoxFilter_RAA.Controls.Add(textBoxMaxPrice_RAA);
            groupBoxFilter_RAA.Controls.Add(buttonApplyFilter_RAA);
            groupBoxFilter_RAA.Controls.Add(buttonResetFilter_RAA);

            panelProductsTop_RAA.Controls.Add(groupBoxInput_RAA);
            panelProductsTop_RAA.Controls.Add(groupBoxFilter_RAA);
            panelProductsTop_RAA.Controls.Add(groupBoxSearch_RAA);

            dataGridViewProducts_RAA = new DataGridView();
            dataGridViewProducts_RAA.Dock = DockStyle.Fill;
            dataGridViewProducts_RAA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts_RAA.BackgroundColor = Color.White;
            dataGridViewProducts_RAA.RowHeadersVisible = false;
            dataGridViewProducts_RAA.AllowUserToAddRows = false;
            dataGridViewProducts_RAA.AllowUserToDeleteRows = false;
            dataGridViewProducts_RAA.AutoGenerateColumns = true;

            tabPageProducts_RAA.Controls.Add(dataGridViewProducts_RAA);
            tabPageProducts_RAA.Controls.Add(panelProductsTop_RAA);

            // поставщики
            labelSuppliersInfo_RAA = new Label();
            labelSuppliersInfo_RAA.Dock = DockStyle.Fill;
            labelSuppliersInfo_RAA.TextAlign = ContentAlignment.MiddleCenter;
            labelSuppliersInfo_RAA.Text = "Раздел поставщиков.";
            tabPageSuppliers_RAA.Controls.Add(labelSuppliersInfo_RAA);

            // статистика
            tabPageStats_RAA.Padding = new Padding(10);

            groupBoxStats_RAA = new GroupBox();
            groupBoxStats_RAA.Text = "Статистика склада";
            groupBoxStats_RAA.Location = new Point(10, 10);
            groupBoxStats_RAA.Size = new Size(400, 200);

            labelTotalCostTitle_RAA = new Label();
            labelTotalCostValue_RAA = new Label();
            labelAveragePriceTitle_RAA = new Label();
            labelAveragePriceValue_RAA = new Label();
            labelMostExpensiveTitle_RAA = new Label();
            labelMostExpensiveValue_RAA = new Label();
            labelTotalQuantityTitle_RAA = new Label();
            labelTotalQuantityValue_RAA = new Label();

            labelTotalCostTitle_RAA.Text = "Общая стоимость:";
            labelAveragePriceTitle_RAA.Text = "Средняя цена:";
            labelMostExpensiveTitle_RAA.Text = "Самый дорогой товар:";
            labelTotalQuantityTitle_RAA.Text = "Общее количество:";

            labelTotalCostTitle_RAA.Location = new Point(15, 30);
            labelTotalCostValue_RAA.Location = new Point(200, 30);

            labelAveragePriceTitle_RAA.Location = new Point(15, 60);
            labelAveragePriceValue_RAA.Location = new Point(200, 60);

            labelMostExpensiveTitle_RAA.Location = new Point(15, 90);
            labelMostExpensiveValue_RAA.Location = new Point(200, 90);
            labelMostExpensiveValue_RAA.AutoSize = true;

            labelTotalQuantityTitle_RAA.Location = new Point(15, 120);
            labelTotalQuantityValue_RAA.Location = new Point(200, 120);

            groupBoxStats_RAA.Controls.Add(labelTotalCostTitle_RAA);
            groupBoxStats_RAA.Controls.Add(labelTotalCostValue_RAA);
            groupBoxStats_RAA.Controls.Add(labelAveragePriceTitle_RAA);
            groupBoxStats_RAA.Controls.Add(labelAveragePriceValue_RAA);
            groupBoxStats_RAA.Controls.Add(labelMostExpensiveTitle_RAA);
            groupBoxStats_RAA.Controls.Add(labelMostExpensiveValue_RAA);
            groupBoxStats_RAA.Controls.Add(labelTotalQuantityTitle_RAA);
            groupBoxStats_RAA.Controls.Add(labelTotalQuantityValue_RAA);

            groupBoxChart_RAA = new GroupBox();
            groupBoxChart_RAA.Text = "Статистика товаров (количество)";
            groupBoxChart_RAA.Location = new Point(10, 220);
            groupBoxChart_RAA.Size = new Size(670, 220);
            groupBoxChart_RAA.Anchor = AnchorStyles.Top | AnchorStyles.Left |
                                       AnchorStyles.Right | AnchorStyles.Bottom;

            chartProducts_RAA = new Chart();
            chartProducts_RAA.Dock = DockStyle.Fill;
            ChartArea chartArea1 = new ChartArea("ChartArea1");
            chartProducts_RAA.ChartAreas.Add(chartArea1);
            Legend legend1 = new Legend("Legend1");
            chartProducts_RAA.Legends.Add(legend1);
            Series series1 = new Series("SeriesQuantity_RAA");
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.ChartType = SeriesChartType.Column;
            chartProducts_RAA.Series.Add(series1);

            groupBoxChart_RAA.Controls.Add(chartProducts_RAA);

            tabPageStats_RAA.Controls.Add(groupBoxChart_RAA);
            tabPageStats_RAA.Controls.Add(groupBoxStats_RAA);

            // лэйаут
            tableLayoutMain_RAA = new TableLayoutPanel();
            tableLayoutMain_RAA.Dock = DockStyle.Fill;
            tableLayoutMain_RAA.ColumnCount = 1;
            tableLayoutMain_RAA.RowCount = 3;
            tableLayoutMain_RAA.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutMain_RAA.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutMain_RAA.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain_RAA.Controls.Add(labelTitle_RAA, 0, 0);
            tableLayoutMain_RAA.Controls.Add(labelSubtitle_RAA, 0, 1);
            tableLayoutMain_RAA.Controls.Add(tabControlMain_RAA, 0, 2);

            // форма
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 601);
            this.Controls.Add(tableLayoutMain_RAA);
            this.Controls.Add(statusStripMain_RAA);
            this.Controls.Add(toolStripMain_RAA);
            this.Controls.Add(menuStripMain_RAA);
            this.MainMenuStrip = menuStripMain_RAA;
            this.Name = "FormMain";
            this.Text = "Оптовая база";
            this.Load += FormMain_Load;
        }
    }
}
