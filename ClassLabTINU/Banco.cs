using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ClassLabTINU
{
    public static class Banco
    {
        //Propriedade  de conexão - string
        public static string StrConexão { get; set; }

        //Método abrir conexão
            public static MySqlCommand Abrir()
            {  
                MySqlCommand cmd = new MySqlCommand();
                StrConexão = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=;port=3306";
                MySqlConnection cn = new MySqlConnection(StrConexão);
                try
                {
                    cn.Open();
                }
                catch
                {
                    throw;
                }
                
                 cmd.Connection = cn;
                 return cmd;
            } 


       












    }
}
