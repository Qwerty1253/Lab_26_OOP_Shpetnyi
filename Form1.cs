using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace Lab_26
{
    public partial class Form1 : Form
    {
        private Microsoft.Office.Interop.Word.Application _wordApp;
        private Document _wordDoc;
        private string _templatePath;

        public Form1()
        {
            InitializeComponent();
        }

        // Обробник кнопки для генерації квитанції
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (!string.IsNullOrEmpty(textBoxTemplatePath.Text))
            {
                _templatePath = textBoxTemplatePath.Text;
            }
            else
            {
                MessageBox.Show("Оберіть шаблон для генерації квитанції.");
                return;
            }

            try
            {
                _wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
                _wordDoc = _wordApp.Documents.Add(_templatePath);

                // Заполнение данных в шаблоне
                FillReceiptData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для заполнения данных в шаблоне
        private void FillReceiptData()
        {
            ReplaceContentControlText(_wordDoc, "numberoflist", "123456"); // Пример номера квитанции
            ReplaceContentControlText(_wordDoc, "PIB", textBoxName.Text + " " + textBoxSurname.Text);
            ReplaceContentControlText(_wordDoc, "address", textBoxAddress.Text);
            ReplaceContentControlText(_wordDoc, "osobrah", textBoxOsobrah.Text);
            ReplaceContentControlText(_wordDoc, "monthandyear", DateTime.Now.ToString("MMMM yyyy"));
            ReplaceContentControlText(_wordDoc, "dateprevious", textBoxDateF.Text);
            ReplaceContentControlText(_wordDoc, "datenow", textBoxDateS.Text);
            ReplaceContentControlText(_wordDoc, "prev", textBoxPrev.Text);
            ReplaceContentControlText(_wordDoc, "bydate", textBoxByDate.Text);
            ReplaceContentControlText(_wordDoc, "typylich", textBoxTypeLich.Text);
            ReplaceContentControlText(_wordDoc, "tarif", textBoxTarif.Text);
            ReplaceContentControlText(_wordDoc, "m3price", textBoxM3Price.Text);

            // Расчет потребленного объема и суммы к оплате
            double prev = double.Parse(textBoxPrev.Text);
            double bydate = double.Parse(textBoxByDate.Text);
            double m3price = double.Parse(textBoxM3Price.Text);
            double m3used = bydate - prev;
            double oplatames = m3used * m3price;
            double pilga = double.Parse(textBoxPilga.Text);
            double oplatamespilga = oplatames - pilga;
            double borg = double.Parse(textBoxBorg.Text);
            double sumalast = oplatamespilga + borg;

            ReplaceContentControlText(_wordDoc, "m3used", m3used.ToString());
            ReplaceContentControlText(_wordDoc, "oplatames", oplatames.ToString("F2"));
            ReplaceContentControlText(_wordDoc, "pilga", pilga.ToString("F2"));
            ReplaceContentControlText(_wordDoc, "oplatamespilga", oplatamespilga.ToString("F2"));
            ReplaceContentControlText(_wordDoc, "borg", borg.ToString("F2"));
            ReplaceContentControlText(_wordDoc, "sumalast", sumalast.ToString("F2"));
        }

        // Метод для замены текста в элементах управления содержимым по тегу
        private void ReplaceContentControlText(Document doc, string tag, string text)
        {
            foreach (ContentControl cc in doc.ContentControls)
            {
                if (cc.Tag == tag)
                {
                    cc.Range.Text = text;
                }
            }
        }

        // Метод для освобождения ресурсов Word
        private void ReleaseWordObject(object obj)
        {
            if (obj != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
        }

        // Обработчик кнопки для выбора шаблона
        private void buttonSelectTemplate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Templates (*.dotx)|*.dotx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxTemplatePath.Text = openFileDialog.FileName;
                }
            }
        }

        // Проверка введенных данных
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Введіть ім'я та прізвище.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Введіть адрес.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxOsobrah.Text))
            {
                MessageBox.Show("Введіть особистий рахунок.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxDateF.Text) || string.IsNullOrEmpty(textBoxDateS.Text))
            {
                MessageBox.Show("Введіть дати споживання.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPrev.Text) || string.IsNullOrEmpty(textBoxByDate.Text))
            {
                MessageBox.Show("Введіть показання лічильника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxTypeLich.Text))
            {
                MessageBox.Show("Введіть тип лічильника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxTarif.Text))
            {
                MessageBox.Show("Введіть тариф.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxM3Price.Text))
            {
                MessageBox.Show("Введіть ціну за 1 м³.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPilga.Text))
            {
                MessageBox.Show("Введіть пільгу/субсидію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxBorg.Text))
            {
                MessageBox.Show("Введіть заборгованість.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}