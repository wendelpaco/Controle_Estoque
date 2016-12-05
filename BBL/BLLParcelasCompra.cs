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
    public class BLLParcelasCompra
    {
        private DALConexao conexao;
        public BLLParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.Pco_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.Pco_valor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = new DateTime();
            if (modelo.Pco_datavecto.Year < data.Year)
            {
                throw new Exception("O Ano de Vencimento inferior ao ano atual");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.Pco_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.Pco_valor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = new DateTime();
            if (modelo.Pco_datavecto.Year < data.Year)
            {
                throw new Exception("O Ano de Vencimento inferior ao ano atual");
            }
            
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.Pco_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }
        public void ExcluirTodasAsParcelas(int comCod)
        {
            if (comCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            DALobj.ExcluirTodasAsParcelas(comCod);
        }
        public DataTable Localizar(int comCod)
        {
            if (comCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.Localizar(comCod);
        }
        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod)
        {
            if (PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            DALParcelasCompra DALobj = new DALParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(PcoCod, ComCod);
        }
    }
}
