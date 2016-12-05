using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCompra : Form
    {
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {

        }

        public void executaConsulta(int op)
        {
            //op = 1 todas as compras
            //op = 2 por fornecedor
            //op = 3 data da compra
            //op = 4 parcelas em aberto
        }
        public void atualizaCabecalhoDGCompra()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 45;
            dgvDados.Columns[1].HeaderText = "Data da Compra";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "N* da nota fiscal";
            dgvDados.Columns[2].Width = 80;
            dgvDados.Columns[3].HeaderText = "N* de Parcelas";
            dgvDados.Columns[3].Width = 70;
            dgvDados.Columns[4].HeaderText = "Fornecedor";
            dgvDados.Columns[4].Width = 170;
            dgvDados.Columns[5].HeaderText = "Status da Compra";
            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].HeaderText = "Cod Fornecedor";
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].HeaderText = "Cod Tipo de Pagamento";
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[8].HeaderText = "Total";
            dgvDados.Columns[8].Width = 65;

        }
        private void btLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbNomeFornecedor.Text = "Nome do Fornecedor:  " + modelo.ForNome;
                BLLCompra bllCompra = new BLLCompra(cx);
                dgvDados.DataSource = bllCompra.Localizar(f.codigo);
                f.Dispose();
                this.atualizaCabecalhoDGCompra();
            }
            else
            {
                txtForCod.Text = "";
                lbNomeFornecedor.Text = "Nome do Fornecedor";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            pnFornecedor.Visible = false;

            if (rbGeral.Checked == true)
            {

            }
            if (rbData.Checked == true)
            {

            }
            if (rbFornecedor.Checked == true)
            {
                pnFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {

            }
        }
    }
}
