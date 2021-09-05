using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp.Pizza
{
    public partial class F : Form
    {
        private FormStart secondForm;
        public F(FormStart secondFormParam)
        {
            InitializeComponent();
            secondForm = secondFormParam;

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            secondForm.Show();
        }
        private int FromMasketTextBox(MaskedTextBox maskedTextBox)
        {
            string normalStr = maskedTextBox.Text;
            if (normalStr.Length < 2)
            {
                normalStr += " ";
                if (normalStr.Length < 2)
                    normalStr += " ";
            }
            if (normalStr[0] == ' ')
                normalStr = "0" + normalStr[1];
            if (normalStr[1] == ' ')
                normalStr = normalStr[0] + "0";
            if (normalStr[0] == '0')
                normalStr = normalStr[1].ToString();
            return int.Parse(normalStr);
        }
        private void MaskedTextBoxMinus(MaskedTextBox maskedTextBox)
        {
            int count = FromMasketTextBox(maskedTextBox);
            if (count > 0)
                --count;
            if (count < 10)
                maskedTextBox.Text = " " + count.ToString();
            else
                maskedTextBox.Text = count.ToString();
        }
        private void MaskedTextBoxPlus(MaskedTextBox maskedTextBox)
        {
            int count = FromMasketTextBox(maskedTextBox);
            if (count < 99)
                ++count;
            if (count < 10)
                maskedTextBox.Text = " " + count.ToString();
            else
                maskedTextBox.Text = count.ToString();
        }
        private void btnRusMinus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxMinus(maskedTextBoxRus);
        }
        private void btnMeatMinus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxMinus(maskedTextBoxMeat);
        }
        private void btnPineappleMinus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxMinus(maskedTextBoxPineapple);
        }
        private void btnChickenMinus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxMinus(maskedTextBoxChicken);
        }
        private void btnChickenPlus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxPlus(maskedTextBoxChicken);
        }
        private void btnRusPlus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxPlus(maskedTextBoxRus);
        }
        private void btnMeatPlus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxPlus(maskedTextBoxMeat);
        }
        private void btnPineapplePlus_Click(object sender, EventArgs e)
        {
            MaskedTextBoxPlus(maskedTextBoxPineapple);
        }
        private void btnEstimate_Click(object sender, EventArgs e)
        {
            int estimate = (FromMasketTextBox(maskedTextBoxChicken) * 399) +
                (FromMasketTextBox(maskedTextBoxRus) * 499) +
                (FromMasketTextBox(maskedTextBoxMeat) * 399) +
                (FromMasketTextBox(maskedTextBoxPineapple) * 399);
            if (promoInput.Text == "PIZZACOOL")
                estimate = (int)((double)estimate * 0.75);
            lablePrice.Text = estimate.ToString() + " ₽";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скоро с вами свяжется наш оператор, пожалуйста, ожидайте!");
        }

        private void btnSaveCheck_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return; 
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, lablePrice.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
