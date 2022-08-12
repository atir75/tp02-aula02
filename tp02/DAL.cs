using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace tp02
{
    internal class DAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDFarinha.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void consultaUmCliente()
        {
            String aux = "select * from TabClientes where cnpj = @cnpj";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@cnpj", OleDbType.VarChar).Value = Cliente.getCNPJ();
            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                Cliente.setNome(result.GetString(2));
            }
            else
                Erro.setMsg("Dado não cadastrado.");
        }
    }
}
