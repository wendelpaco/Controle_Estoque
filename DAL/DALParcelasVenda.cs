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
    public class DALParcelasVenda
    {
        private DALConexao conexao;
        public DALParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "insert into PARCELASVENDA(PVE_COD, VEN_COD, PVE_DATAVECTO, PVE_VALOR) " +
                "values (@PVE_COD, @VEN_COD, @PVE_DATAVECTO, @PVE_VALOR); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@PVE_COD", modelo.Pve_cod);
            cmd.Parameters.AddWithValue("@VEN_COD", modelo.Ven_cod);
            cmd.Parameters.AddWithValue("@PVE_VALOR", modelo.Pve_valor);
            cmd.Parameters.Add("@PVE_DATAVECTO", System.Data.SqlDbType.Date);

            if (modelo.Pve_datavecto == null)
            {
                cmd.Parameters["@PVE_DATAVECTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@PVE_DATAVECTO"].Value = modelo.Pve_datavecto;
            }

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Alterar(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "UPDATE PARCELASVENDA SET " +
                "PVE_VALOR = @PVE_VALOR, " +
                "PVE_DATEPAGTO = @PVE_DATEPAGTO, " +
                "PVE_DATAVECTO = @PVE_DATAVECTO, " +
                " WHERE PVE_COD = @PVE_COD AND VEN_COD = @VEN_COD ";
            cmd.Parameters.AddWithValue("@PVE_COD", modelo.Pve_cod);
            cmd.Parameters.AddWithValue("@PVE_VALOR", modelo.Pve_valor);
            cmd.Parameters.AddWithValue("@VEN_COD", modelo.Ven_cod);
            cmd.Parameters.Add("@PVE_DATEPAGTO", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@PVE_DATAVECTO", System.Data.SqlDbType.Date);

            if (modelo.Pve_datapagto == null)
            {
                cmd.Parameters["@PVE_DATEPAGTO"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@PVE_DATEPAGTO"].Value = modelo.Pve_datapagto;
            }
            cmd.Parameters["@PVE_DATAVECTO"].Value = modelo.Pve_datavecto;

            // cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(ModeloParcelasVenda modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "delete from PARCELASVENDA " +
                " WHERE PVE_COD = @PVE_COD AND VEN_COD = @VEN_COD ";
            cmd.Parameters.AddWithValue("@PVE_COD", modelo.Pve_cod);
            cmd.Parameters.AddWithValue("@VEN_COD", modelo.Ven_cod);
            cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void ExcluirTodasAsParcelas(int vemCod)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "delete from PARCELASVENDA " +
                " WHERE VEN_COD = @VEN_COD ";
            cmd.Parameters.AddWithValue("@PVE_COD", vemCod);
            cmd.Prepare();
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(int vemCod)
        {
            DataTable tabela = new DataTable();
            string sql = "Select * from PARCELASVENDA where VEN_COD = " + vemCod.ToString();
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int venCod)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();  
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "select * from PARCELASVENDA " +
                " where PVE_COD = @PVE_COD and VEN_COD= @VEN_COD;";
            cmd.Parameters.AddWithValue("@PVE_COD", PveCod);
            cmd.Parameters.AddWithValue("@VEN_COD", venCod);
            cmd.Prepare();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.Pve_cod = PveCod;
                modelo.Ven_cod = venCod;
                modelo.Pve_datapagto = Convert.ToDateTime(registro["PVE_DATAPAGTO"]);
                modelo.Pve_datavecto = Convert.ToDateTime(registro["PVE_DATAVECTO"]);
                modelo.Pve_valor = Convert.ToDouble(registro["PVE_VALOR"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
