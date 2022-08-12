using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.desconecta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente.setCNPJ(textBox1.Text);

            BLL.validaCNPJ();

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                textBox1.Text = Cliente.getCNPJ();
                textBox2.Text = Cliente.getNome();
            }
        }
    }
}
