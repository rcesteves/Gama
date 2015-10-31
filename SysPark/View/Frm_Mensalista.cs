using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_Mensalista : Form
    {
        public Frm_Mensalista()
        {
            InitializeComponent();
        }

        private void Frm_Mensalista_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja importar Orçamento ?");
      // se precionar sim então buscar pelo cpf/cnpj ou código do orçamento e puxar dados para tela de cadastro de clientes;)
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
