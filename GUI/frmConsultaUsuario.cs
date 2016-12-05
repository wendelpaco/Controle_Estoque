using BLL;
using DAL;
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
    public partial class frmConsultaUsuario : Form
    {
        public int codigo = 0;
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (rbNome.Checked == true)
                {
                    dgvDadosUsuario.DataSource = bll.LocalizarPorNome(txtValor.Text);
                    //carregaDados();
                }
                else
                {
                    dgvDadosUsuario.DataSource = bll.LocalizarLoginAtivo(txtValor.Text);
                    //carregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void carregaDados()
        {
            dgvDadosUsuario.Columns[0].HeaderText = "Código";
            dgvDadosUsuario.Columns[0].Width = 45;
            dgvDadosUsuario.Columns[1].HeaderText = "Nome do Usuário";
            dgvDadosUsuario.Columns[1].Width = 130;
            dgvDadosUsuario.Columns[2].HeaderText = "Nome do Login";
            dgvDadosUsuario.Columns[2].Width = 105;
            dgvDadosUsuario.Columns[3].HeaderText = "E-mail do Usuário";
            dgvDadosUsuario.Columns[3].Width = 140;
            dgvDadosUsuario.Columns[4].HeaderText = "Perfil";
            dgvDadosUsuario.Columns[4].Width = 95;
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            /*
            btLocalizar_Click(sender, e);
            dgvDadosUsuario.Columns[0].HeaderText = "Código";
            dgvDadosUsuario.Columns[0].Width = 45;
            dgvDadosUsuario.Columns[1].HeaderText = "Nome do Usuário";
            dgvDadosUsuario.Columns[1].Width = 130;
            dgvDadosUsuario.Columns[2].HeaderText = "Nome do Login";
            dgvDadosUsuario.Columns[2].Width = 105;
            dgvDadosUsuario.Columns[3].HeaderText = "E-mail do Usuário";
            dgvDadosUsuario.Columns[3].Width = 140;
            dgvDadosUsuario.Columns[4].HeaderText = "Perfil";
            dgvDadosUsuario.Columns[4].Width = 95;
            */
            rbNome_CheckedChanged(sender, e);
        }

        private void dgvDadosUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDadosUsuario.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void rbInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInativos.Checked == true)
            {
                int novovalor = 0;
                //novovalor = int.Parse(txtValor.Text);
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                txtValor.Enabled = false;
                //txtValor.Text = 0.ToString();
                dgvDadosUsuario.DataSource = bll.LocalizarUsuariosInativos(Convert.ToString(novovalor));
                carregaDados();
            }
            else
            {
                txtValor.Enabled = true;
                txtValor.Text = "";
            }
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuario.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                //txtValor.Enabled = false;
                //txtValor.Text = 0.ToString();
                dgvDadosUsuario.DataSource = bll.LocalizarLoginAtivo(txtValor.Text);
                carregaDados();
            }
           /* else
            {
                txtValor.Enabled = true;
                txtValor.Text = "";
            }*/
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked == true)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                //txtValor.Enabled = false;
                //txtValor.Text = 0.ToString();
                dgvDadosUsuario.DataSource = bll.LocalizarPorNome(txtValor.Text);
                carregaDados();
            }
            /* else
            {
                txtValor.Enabled = true;
                txtValor.Text = "";
            }*/
        }
    }
}
