using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2pontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ponto pt = new ponto();

        ponto P1 = new ponto();
        ponto P2 = new ponto();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {

            P1.X = Convert.ToDouble(x1.Text);
            P1.Y = Convert.ToDouble(y1.Text);
            P2.X = Convert.ToDouble(x2.Text);
            P2.Y = Convert.ToDouble(y2.Text);
            label1.Text = P1.Distancia(P2).ToString();
            //label1.Text = (Math.Sqrt(Math.Pow(P2.X - P1.X, 2)+ Math.Pow(P2.Y - P1.Y, 2))).ToString();


            /*
            pt.PontoX1 = x1.Text;
            pt.PontoX2 = x2.Text;
            pt.PontoY1 = y1.Text;
            pt.PontoY2 = y2.Text;
            label1.Text = pt.Pontos;
            */
        }
    }
}
