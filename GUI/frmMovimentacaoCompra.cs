using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMovimentacaoCompra : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalCompra = 0;
        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e){
            
            try{
                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbNParcela.Text);
                Double totallocal = this.totalCompra;
                double valor = totallocal / parcelas;
                DateTime dt = new DateTime();
                dt = dtaDataIni.Value;
                lbTotal.Text = totallocal.ToString() + ",00";

                //se não tiver nada adc ao grid, exibe um alert

                if (!txtNFiscal.Text.Equals(""))
                {
                if (dgvItens.Rows.Count > 0 ){
                    for (int i = 1; i <= parcelas; i++){
                        String[] vetorK = new String[] { i.ToString(), valor.ToString() + ",00", dt.ToString() };
                        this.dgvParcelas.Rows.Add(vetorK);
                        if (dt.Month != 12){
                            dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                        }else{
                            dt = new DateTime(dt.Year + 1, 1, dt.Day);
                        }
                    }
                    //pnFinalizaCompra.Visible = true;
                }else {
                    MessageBox.Show("Adicione os itens ao grid para finalizar a compra!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    btnCancelar.Enabled = true;
                    btnSalvar.Enabled = true;
                    if (dgvParcelas.Rows.Count > 0)
                        btCancelar.Enabled = false;
                        btSalvar.Enabled = false;
                }
                else {
                    MessageBox.Show("Preecha a nota fiscal para finalizar a compra!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //dgvItens.Rows.Clear();
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.totalCompra = 0;
            this.limpaTela();
            setValor();
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            lbTotal.Text = "0,00";
            cbNParcela.SelectedItem = 0;
            cbTpagto.SelectedItem = 0;
        }
        public void setValor()
        {
            txtQtde.Text = "0";
            txtValor.Text = "0,00";
            txtCompraTotal.Text = "0,00";
        }
        public void limpaTela()
        {
            txtComCod.Clear();
            txtNFiscal.Clear();
            txtForCod.Clear();
            txtProCod.Clear();
            lFormulario.Text = "Informe o código do fornecedor ou clique em pesquisar";
            lProduto.Text = "Informe o código do produto ou clique em pesquisar";
            txtQtde.Clear();
            txtValor.Clear();
            txtCompraTotal.Clear();
            dgvItens.Rows.Clear();
        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";
            if ( cbTpagto.Items.Count > 0 && cbNParcela.Items.Count > 0) { 
            cbTpagto.SelectedIndex = 0;
            cbNParcela.SelectedIndex = 0;
            }
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btLocFor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                txtForCod_Leave(sender, e);
            }
        }

        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                lFormulario.ForeColor = Color.Red;
                lFormulario.Text = modelo.ForNome;
            }
            catch
            {
                txtForCod.Clear();
                lFormulario.Text = "Informe o código do fornecedor ou clique em pesquisar";
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                txtProCod_Leave(sender, e);
            }
        }

        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lProduto.ForeColor = Color.Red;
                lProduto.Text = modelo.ProNome;
                txtQtde.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString() + ",00";
            }
            catch
            {
                txtProCod.Clear();
                lFormulario.Text = "Informe o código do produto ou clique em pesquisar";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
            {
                if (this.totalCompra >= 0)
                {
                    this.totalCompra = 0;    
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                    this.totalCompra = this.totalCompra + TotalLocal;
                    String[] i = new String[] { txtProCod.Text, lProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() + ",00" };
                    this.dgvItens.Rows.Add(i);

                    txtProCod.Text = "";
                    lProduto.Text = "Informe o código do produto ou clique em pesquisar";
                    setValor();
                    txtCompraTotal.Text = this.totalCompra.ToString() + ",00";
                }
            }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtCompraTotal.Text = this.totalCompra.ToString() + ",00";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //pnFinalizaCompra.Visible = false;
            if (dgvParcelas.Rows.Count > 0)
            {
                dgvParcelas.Rows.Clear();
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
                lbTotal.Text = "0,00";
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcela.Text);
                modeloCompra.ComStatus = "Ativo";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTpagto.SelectedValue);

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelasCompra mParcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bParcelas = new BLLParcelasCompra(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modeloCompra);
                    //cadastrar os itens da compra
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.Com_cod = modeloCompra.ComCod;
                        mitens.Pro_cod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.Itc_qtde = Convert.ToInt32(dgvItens.Rows[i].Cells[2].Value);
                        mitens.Itc_valor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //altera a qtd de produtos comprados na tabela de produto
                    }
                    // inserir os itens na tabela de produtos
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mParcelas.Com_cod = modeloCompra.ComCod;
                        mParcelas.Pco_cod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mParcelas.Pco_valor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mParcelas.Pco_datavecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bParcelas.Incluir(mParcelas);
                    }
                        //cadastrar as parcelas da compra
                        MessageBox.Show("Compra efetuado: Código " + modeloCompra.ComCod.ToString());

                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtProCod.Text);
                    bll.Alterar(modeloCompra);
                    MessageBox.Show("Cadastro alterado");
                }
                this.limpaTela();
                this.alteraBotoes(1);
                lbTotal.Text = "0,00";
                dgvParcelas.Rows.Clear();
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
