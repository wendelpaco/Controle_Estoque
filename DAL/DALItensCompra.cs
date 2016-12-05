using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALItensCompra
    {
        private DALConexao conexao;
        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into ITENSCOMPRA(ITC_COD, ITC_QTDE, ITC_VALOR, COM_COD, PRO_COD)" +
                "values (@ITC_COD,@ITC_QTDE,@ITC_VALOR,@COM_COD,@PRO_COD); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@ITC_COD", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@ITC_QTDE", modelo.Itc_qtde);
            cmd.Parameters.AddWithValue("@ITC_VALOR", modelo.Itc_valor);
            cmd.Parameters.AddWithValue("@COM_COD", modelo.Com_cod);
            cmd.Parameters.AddWithValue("@PRO_COD", modelo.Pro_cod);
            conexao.Conectar();
            //cmd.Prepare();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "update ITENSCOMPRA set ITC_COD = @ITC_COD, ITC_QTDE = @ITC_QTDE, ITC_VALOR = @ITC_VALOR, " +
                "COM_COD=@COM_COD, PRO_COD=@PRO_COD " +
                " where ITC_COD = @ITC_COD and COM_COD=@COM_COD and PRO_COD=@PRO_COD;";
            cmd.Parameters.AddWithValue("@ITC_COD", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@ITC_QTDE", modelo.Itc_qtde);
            cmd.Parameters.AddWithValue("@ITC_VALOR", modelo.Itc_valor);
            cmd.Parameters.AddWithValue("@COM_COD", modelo.Com_cod);
            cmd.Parameters.AddWithValue("@PRO_COD", modelo.Pro_cod);
            cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = 
                "delete from ITENSCOMPRA "+
                " where ITC_COD = @ITC_COD and COM_COD=@COM_COD and PRO_COD=@PRO_COD;";
            cmd.Parameters.AddWithValue("@ITC_COD", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@COM_COD", modelo.Com_cod);
            cmd.Parameters.AddWithValue("@PRO_COD", modelo.Pro_cod);
            cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ITENSCOMPRA where COM_COD ="+
                comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int Comcod, int Procod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = 
                "select * from ITENSCOMPRA "+
                " where ITC_COD = @ITC_COD and COM_COD=@COM_COD and PRO_COD=@PRO_COD;";
            cmd.Parameters.AddWithValue("@ITC_COD", ItcCod);
            cmd.Parameters.AddWithValue("@COM_COD", Comcod);
            cmd.Parameters.AddWithValue("@PRO_COD", Procod);
            cmd.Prepare();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = ItcCod;
                modelo.Com_cod = Comcod;
                modelo.Pro_cod = Procod;
                modelo.Itc_qtde = Convert.ToDouble(registro["ITC_QTDE"]);
                modelo.Itc_qtde = Convert.ToDouble(registro["ITC_VALOR"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
