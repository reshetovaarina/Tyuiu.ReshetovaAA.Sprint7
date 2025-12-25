using System.Windows.Forms;

namespace Tyuiu.ReshetovaAA.Sprint7.Project.V5
{
    partial class FormHelp_RAA
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox textBoxHelp_RAA;
        private Button buttonClose_RAA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            textBoxHelp_RAA = new TextBox();
            buttonClose_RAA = new Button();

            SuspendLayout();

            textBoxHelp_RAA.Multiline = true;
            textBoxHelp_RAA.ReadOnly = true;
            textBoxHelp_RAA.ScrollBars = ScrollBars.Vertical;
            textBoxHelp_RAA.Dock = DockStyle.Top;
            textBoxHelp_RAA.Height = 200;
            textBoxHelp_RAA.Text =
                "Краткая инструкция:" + "\r\n\r\n" +
                "1. Загрузите CSV-файл с данными о товарах (кнопка «Загрузить»)." + "\r\n" +
                "2. Для добавления новой записи заполните поля «Код», «Название», " +
                "«Количество», «Цена», «Примечание» и нажмите кнопку «Добавить»." + "\r\n" +
                "3. Для поиска по названию введите часть названия в поле поиска и " +
                "нажмите кнопку «Найти»." + "\r\n" +
                "4. Статистику по складу и фильтр по цене можно посмотреть на вкладке «Статистика»." + "\r\n" +
                "5. Для сохранения текущих данных в CSV используйте кнопку «Сохранить».";

            buttonClose_RAA.Text = "Закрыть";
            buttonClose_RAA.Dock = DockStyle.Bottom;
            buttonClose_RAA.Height = 25;
            buttonClose_RAA.Click += buttonClose_RAA_Click;

            ClientSize = new System.Drawing.Size(420, 240);
            Controls.Add(buttonClose_RAA);
            Controls.Add(textBoxHelp_RAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Помощь";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
