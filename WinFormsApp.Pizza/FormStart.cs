using System;
using System.Windows.Forms;

namespace WinFormsApp.Pizza
{
    public partial class FormStart : Form
    {
        private F secondForm;
        private bool isPramaCodeShowed = false;
        public FormStart()
        {
            InitializeComponent();
            secondForm = new F(this);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            secondForm.Show();
            this.Hide();
            if (!isPramaCodeShowed)
            {
                MessageBox.Show("По случаю первого запуска программы, мы дарим Вам купон на скидку 25%." +
                    " Промокод: PIZZACOOL");
                isPramaCodeShowed = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли приложение для оформления заказа в пиццерии 4PIZZA с учетом скидок.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
