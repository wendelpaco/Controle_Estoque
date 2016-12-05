using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLParcelasVenda
    {
        private DALConexao conexao;
        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.Pve_cod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.Ven_cod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.Pve_valor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = new DateTime();
            if (modelo.Pve_datavecto.Year < data.Year)
            {
                throw new Exception("O Ano de vencimento inferior ao ano atual");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.Pve_cod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.Ven_cod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.Pve_valor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = new DateTime();
            if (modelo.Pve_datavecto.Year < data.Year)
            {
                throw new Exception("O Ano de vencimento inferior ao ano atual");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.Pve_cod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.Ven_cod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodasAsParcelas(int venCod)
        {
            if (venCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.ExcluirTodasAsParcelas(venCod);
        }
        public DataTable Localizar(int venCod)
        {
            if (venCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.Localizar(venCod);
        }
        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int venCod)
        {
            if (PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (venCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(PveCod, venCod);
        }
    }
}
