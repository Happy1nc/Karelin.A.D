using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy_store
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void buttonOk_MouseClick(object sender, MouseEventArgs e)
        {
            FormMain f2 = new FormMain();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли программу, в которой приведен список игрушек. Вы можете выбрать от 1 до 4 игрушек. Уйти без покупок нельзя - программа выведет об соответствующее сообщение. Затем программа подсчитает стоимость выбранных игрушек и выведет итоговую стоимость.");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
