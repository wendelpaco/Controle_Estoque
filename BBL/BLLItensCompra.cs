using DAL;
using Modelo;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLItensCompra
    {
        private DALConexao conexao;
        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }
            if (modelo.Itc_qtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }
            if (modelo.Itc_valor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }
            if (modelo.Itc_qtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero");
            }
            if (modelo.Itc_valor <= 0)
            {
                throw new Exception("O valor do item deve ser maior do que zero");
            }
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.Com_cod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório");
            }
            if (modelo.Pro_cod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DALItensCompra DALobj = new DALItensCompra(conexao);
            DALobj.Excluir(modelo);
        }
        public DataTable Localizar(int comcod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.Localizar(comcod);
        }
        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int Com_cod, int Pro_cod)
        {
            DALItensCompra DALobj = new DALItensCompra(conexao);
            return DALobj.CarregaModeloItensCompra(ItcCod, Com_cod, Pro_cod);
        }
    }
}
