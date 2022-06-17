using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M07 : Form
    {
        public Frm_M07()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "abc";
            mem1.Age = 24;
            /*
            string name = mem1.Name;
            int age = mem1.Age;

            MessageBox.Show("姓名:" + name + ",年齡: " + age);
            */
            Member mem2 = new Member()
            {
                Name = "abc",
                Age = 15
            }; 

            MessageBox.Show("姓名:" + mem2.Name + ",年齡: " +  mem2.Age);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            button2.Click += new EventHandler(button2_Click);
            //button2.Click += Button2_Click;
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            button2.Click -= new EventHandler(button2_Click);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btndiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payment pay;

            if(btndiscount.Text == "50%off")
            {
                pay = discount50off;
            }
            else
            {
                pay = discount20off;
            }

            double price = double.Parse(txt_price.Text);
            double result = pay(price);
            MessageBox.Show(result.ToString());
        }

        delegate double Payment(double Price);

        double discount50off(double price)
        {
            return price * 0.5;
        }

        double discount20off(double price)
        {
            return price * 0.8;
        }
    }
}
