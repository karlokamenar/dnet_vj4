using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnet_vj4
{
    public partial class Form1 : Form
    {
        public delegate double RacOperacija(double a, double b);
        RacOperacija del;
        Kalkulator cal;




        public Form1()
        {
            InitializeComponent();
            cal = new Kalkulator();
            cal.NijeBroj += Je_nije_broj;


        }

        public double plus(double a,double b)
        {
            return a + b;
           
        }

        public double minus(double a, double b)
        {
            return a - b;

        }

        public double puta(double a, double b)
        {
            return a * b;

        }

        public double dijeli(double a, double b)
        {
            return a / b;

        }

        public void Je_nije_broj()
        {
            MessageBox.Show("Greška, svi operandi nisu brojevi");
            this.label1.Text = "Greška";

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
                        cal.OperandA = textBox1.Text;
            cal.OperandB = textBox2.Text;
            if (comboBox1.SelectedItem.ToString() == "+")
                del += plus;
            else if (comboBox1.SelectedItem.ToString() == "-")
                del += minus;
            else if (comboBox1.SelectedItem.ToString() == "*")
                del += puta;
            else if (comboBox1.SelectedItem.ToString() == "/")
            {
                del += dijeli;
                if (cal.OperandB == "0")
                    MessageBox.Show("dijeljenje s 0 nije dozvoljeno");
            }
            
            
               
            
                label1.Text = cal.Izracun(del).ToString();
        }

       
    }
}
