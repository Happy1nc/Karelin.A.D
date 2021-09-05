using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy_store
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (checkBoxBear.Checked == true)
            {
                result += 299;
            }
            else
            {

            }
            if (checkBoxCar.Checked == true)
            {
                result += 499;
            }
            else
            {

            }
            if (checkBoxDuck.Checked == true)
            {
                result += 159;
            }
            else
            {

            }
            if (checkBoxTrain.Checked == true)
            {
                result += 449;
            }
            else
            {

            }
            if (checkBoxBear.Checked == false && checkBoxCar.Checked == false && checkBoxDuck.Checked == false && checkBoxTrain.Checked == false)
            {
                MessageBox.Show("Выберите игрушку, которую хотите купить");
            }
            else
            {
                textBoxCheque.Text =Convert.ToString(result + " " + "рублей");
            }

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оплачено, можете закрыть приложение");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBoxBear_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 1;
        }

        private void checkBoxCar_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 2;
        }

        private void checkBoxDuck_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 3;
        }

        private void checkBoxTrain_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 4;
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        public void labelHello_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine("Магазин <<Мир игрушек>>");
                sw.WriteLine("Кассовый чек");
                if (checkBoxBear.Checked == true)
                {
                    sw.WriteLine("Медведь плюшевый 1 шт." +
                        "299 руб.");
                }
                else
                {

                }
                if (checkBoxCar.Checked == true)
                {
                    sw.WriteLine("Грузовик пластмассовый 1 шт." +
                        "499 руб.");
                }
                else
                {

                }

                if (checkBoxDuck.Checked == true)
                {
                    sw.WriteLine("Каталка деревянная <<Утка>> 1 шт." +
                        "159 руб.");
                }
                else
                {

                }

                if (checkBoxTrain.Checked == true)
                {
                    sw.WriteLine("Конструктор детский <<Паровоз>> 1 шт." +
                        "449 руб.");
                }
                else
                {

                }

                sw.WriteLine("Итого" + " " + textBoxCheque.Text);
                sw.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
