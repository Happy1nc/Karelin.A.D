using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CafeStore
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double result = 0;
            double dis = 0;

            if (cbJuiceOrange.Checked == true)
            {
                result += 200;
               
            }
           
            if (cbJuiceApple.Checked == true)
            {
                result += 150;
               
            }
            
            if (cbJuiceCarrot.Checked == true)
            {
                result += 170;
                
            }
            
            if (cbSandwichChicken.Checked == true)
            {
                result += 150;
               
            }
           
            if (cbSaladSummer.Checked == true)
            {
                result += 200;
              
            }
           
            if (cbFruits.Checked == true)
            {
                result += 350;
                
            }
            if (rbDiscount.Checked == true)
            {
                dis = (result * 10) / 100;
                result = result - dis;
            }
            else if (rbNoDiscount.Checked == true)
            { }

            if (cbFruits.Checked == false && cbJuiceApple.Checked == false && cbJuiceCarrot.Checked == false && cbJuiceOrange.Checked == false && cbSaladSummer.Checked == false && cbSandwichChicken.Checked == false)
            {
                tbResult.Text = Convert.ToString("Итог: " + "0" + " " + "рублей");
                MessageBox.Show("Выберите товар, который хотите купить","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tbResult.Text = Convert.ToString("Итог: "+result + " " + "рублей");
            }

        }

        private void pbSaveCheck_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCheck = new SaveFileDialog();

            if (saveCheck.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveCheck.FileName);
                sw.WriteLine("Cafe-Bar <<Juice Bar>>");
                sw.WriteLine("Кассовый чек");
                if (cbJuiceOrange.Checked == true)
                {
                    sw.WriteLine("Апельсиновый Сок 1 шт." +
                        "200 руб.");
                }
                
                if (cbJuiceApple.Checked == true)
                {
                    sw.WriteLine("Яблочный Сок 1 шт." +
                        "150 руб.");
                }
                

                if (cbJuiceCarrot.Checked == true)
                {
                    sw.WriteLine("Морковный Сок 1 шт." +
                        "170 руб.");
                }
                

                if (cbSandwichChicken.Checked == true)
                {
                    sw.WriteLine("Сэндвич с курицей 1 шт." +
                        "150 руб.");
                }
                if (cbSaladSummer.Checked == true)
                {
                    sw.WriteLine("Салат <<Летний>> 1 шт." +
                        "200 руб.");
                }
                if (cbFruits.Checked == true)
                {
                    sw.WriteLine("Фруктовая Тарелка 1 шт." +
                        "350 руб.");
                }

                sw.WriteLine(" " + tbResult.Text);
                sw.Close();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            MessageBox.Show("Вы оплатили заказ. Можете закрыть приложение или продолжить покупки.", " Благодарим за покупку!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            InfoWindow window2 = new InfoWindow();
            window2.Show();
        }

        
    }
}
