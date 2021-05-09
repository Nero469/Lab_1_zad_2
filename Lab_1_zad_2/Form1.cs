using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_zad_2
{


    public partial class Form1 : Form
    {
        string polacz;
        double liczbaPierwsza;
        double LiczbaDruga;

        public Form1()
        {
            InitializeComponent();
        }
        bool NowaLiczba = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("9");
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text.IndexOf(',') == -1)
            {
                TextBox1.Text += ",";
                NowaLiczba = false;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Dzialanie_Przycisku("0");
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            Operacja("+");
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            Operacja("-");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            LiczbaDruga = Convert.ToDouble(TextBox1.Text);
            Label1.Text = String.Empty;
            switch(polacz)
                {
                    case "+":
                        TextBox1.Text = Convert.ToString(liczbaPierwsza + LiczbaDruga);
                         break;
                    
                    case "-":
                        TextBox1.Text = Convert.ToString(liczbaPierwsza - LiczbaDruga);
                         break;

                    case "*":
                        TextBox1.Text = Convert.ToString(liczbaPierwsza * LiczbaDruga);
                        break;

                    case "/":
                        if (LiczbaDruga == 0)
                        {
                            TextBox1.Text = "Nie dziel przez 0";
                        }
                        else
                        {
                            TextBox1.Text = Convert.ToString(liczbaPierwsza / LiczbaDruga);
                        }
                        break;
                }
                polacz = String.Empty;
                NowaLiczba = true;
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            Operacja("/");
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            Operacja("*");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            Label1.Text = String.Empty;
            polacz = String.Empty;
            NowaLiczba = true;


        }
        private void Dzialanie_Przycisku(string liczba)
        {
            if (NowaLiczba == false)
            {
                TextBox1.Text += liczba;
            }
            else
            {
                TextBox1.Text = liczba;
                NowaLiczba = false;
            }
        }
        private void Operacja(string polacz)
        {
            liczbaPierwsza = Convert.ToDouble(TextBox1.Text);
            Label1.Text = TextBox1.Text;
            Label1.Text += polacz;
            this.polacz = polacz;
            NowaLiczba = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

    }
}