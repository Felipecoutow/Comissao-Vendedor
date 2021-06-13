using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Comissão_Vendedor
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProd1.Clear();
            txtProd2.Clear();
            txtProd3.Clear();
            txtComissao.Clear();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            double Prod1, Prod2, Prod3, Comissao;

            Prod1 = double.Parse(txtProd1.Text);
            Prod2 = double.Parse(txtProd2.Text);
            Prod3 = double.Parse(txtProd3.Text);

            Comissao = (Prod1 + Prod2 + Prod3) * 0.05;

            txtComissao.Text = Convert.ToString(Comissao);

        }
    }
}
