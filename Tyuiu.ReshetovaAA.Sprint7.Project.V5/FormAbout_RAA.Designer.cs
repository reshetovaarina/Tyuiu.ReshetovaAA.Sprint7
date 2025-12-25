using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.ReshetovaAA.Sprint7.Project.V5
{
    partial class FormAbout_RAA
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBoxAuthor_RAA;
        private Label labelInfo_RAA;
        private Button buttonOk_RAA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            pictureBoxAuthor_RAA = new PictureBox();
            labelInfo_RAA = new Label();
            buttonOk_RAA = new Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBoxAuthor_RAA)).BeginInit();
            SuspendLayout();

            pictureBoxAuthor_RAA.Image = Properties.Resources.photo_me;
            pictureBoxAuthor_RAA.Location = new Point(12, 12);
            pictureBoxAuthor_RAA.Size = new Size(120, 150);
            pictureBoxAuthor_RAA.SizeMode = PictureBoxSizeMode.Zoom;

            labelInfo_RAA.Location = new Point(150, 12);
            labelInfo_RAA.Size = new Size(260, 120);
            labelInfo_RAA.Text =
                "Программа «Оптовая база»" + "\r\n\r\n" +
                "Автор: Решетова Арина Алексеевна\r\n" +
                "Группа: СМАРТб-25-1\r\n\r\n" +
                "ТИУ";

            buttonOk_RAA.Text = "OK";
            buttonOk_RAA.Location = new Point(335, 148);
            buttonOk_RAA.Size = new Size(75, 23);
            buttonOk_RAA.Click += buttonOk_RAA_Click;

            ClientSize = new Size(422, 183);
            Controls.Add(buttonOk_RAA);
            Controls.Add(labelInfo_RAA);
            Controls.Add(pictureBoxAuthor_RAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";

            ((System.ComponentModel.ISupportInitialize)(pictureBoxAuthor_RAA)).EndInit();
            ResumeLayout(false);
        }
    }
}
