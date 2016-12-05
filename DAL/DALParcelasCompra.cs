using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALParcelasCompra
    {
        private DALConexao conexao;
        public DALParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into PARCELASCOMPRA(PCO_COD, PCO_VALOR,PCO_DATAVECTO, COM_COD) " +
                "values (@PCO_COD,@PCO_VALOR,@PCO_DATAVECTO, @COM_COD); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@PCO_COD", modelo.Pco_cod);
            cmd.Parameters.AddWithValue("@PCO_VALOR", modelo.Pco_valor);
            cmd.Parameters.AddWithValue("@COM_COD", modelo.Com_cod);
            cmd.Parameters.Add("@PCO_DATAVECTO", System.Data.SqlDbType.Date);

            if (modelo.Pco_datavecto == null)
            {
                cmd.Parameters["@PCO_DATAVECTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@PCO_DATAVECTO"].Value = modelo.Pco_datavecto;
            }

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "UPDATE PARCELASCOMPRA SET " +
                "PCO_VALOR = @PCO_VALOR, " +
                "PCO_DATEPAGTO = @PCO_DATEPAGTO, " +
                "PCO_DATAVECTO = @PCO_DATAVECTO, " +
                " WHERE PCO_COD = @PCO_COD AND COM_COD = @COM_COD ";
            cmd.Parameters.AddWithValue("@PCO_COD", modelo.Pco_cod);
            cmd.Parameters.AddWithValue("@PCO_VALOR", modelo.Pco_valor);
            cmd.Parameters.AddWithValue("@COM_COD", modelo.Com_cod);
            cmd.Parameters.Add("@PCO_DATEPAGTO", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@PCO_DATAVECTO", System.Data.SqlDbType.Date);

            if (modelo.Pco_datapagto == null)
            {
                cmd.Parameters["@PCO_DATEPAGTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@PCO_DATEPAGTO"].Value = modelo.Pco_datapagto;
            }
            cmd.Parameters["@PCO_DATAVECTO"].Value = modelo.Pco_datavecto;

            // cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "delete from PARCELASCOMPRA " +
                " WHERE PCO_COD = @PCO_COD AND COM_COD = @COM_COD ";
            cmd.Parameters.AddWithValue("@PCO_COD", modelo.Pco_cod);
            cmd.Parameters.AddWithValue("@COM_COD", modelo.Com_cod);
            cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirTodasAsParcelas(int comcod)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "delete from PARCELASCOMPRA " +
                " WHERE COM_COD = @COM_COD ";
            cmd.Parameters.AddWithValue("@PCO_COD", comcod);
            cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            string sql = "Select * from PARCELASCOMPRA where COM_COD = " + comcod.ToString();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int Comcod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "select * from PARCELASCOMPRA " +
                " where PCO_COD = @PCO_COD and COM_COD= @COM_COD;";
            cmd.Parameters.AddWithValue("@PCO_COD", PcoCod);
            cmd.Parameters.AddWithValue("@COM_COD", Comcod);
            cmd.Prepare();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Pco_cod = PcoCod;
                modelo.Com_cod = Comcod;
                modelo.Pco_datapagto = Convert.ToDateTime(registro["PCO_DATAPAGTO"]);
                modelo.Pco_datavecto = Convert.ToDateTime(registro["PCO_DATAVECTO"]);
                modelo.Pco_valor = Convert.ToDouble(registro["PCO_VALOR"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
