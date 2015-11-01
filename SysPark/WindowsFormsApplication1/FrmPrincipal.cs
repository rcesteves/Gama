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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estacionamento tela = new Frm_Estacionamento();
            tela.Show();
        }

        private void convênioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Convenio tela = new Frm_Convenio();
            tela.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Funcionario tela = new Frm_Funcionario();
            tela.Show();
        }

        private void planoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Plano tela = new Frm_Plano();
            tela.Show();
        }

        private void veículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Veiculo tela = new Frm_Veiculo();
            tela.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Veiculo_Marca tela = new Frm_Veiculo_Marca();
            tela.Show();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Veiculo_Tipo tela = new Frm_Veiculo_Tipo();
            tela.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_Orçamento tela = new Frm_Orçamento();
            tela.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
             

        }


        private void toolStripButton3_DoubleClick(object sender, EventArgs e)
        {
           MessageBox.Show("teste");
        }

        private void cmdCaixa_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tela de caixa, validação de tickets
            Frm_Caixa tela = new Frm_Caixa();
           
            tela.Show();
        }

        private void preçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Precos tela = new Frm_Precos();
            tela.Show();
        }

        private void mensalistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mensalista tela = new Frm_Mensalista();
            tela.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
