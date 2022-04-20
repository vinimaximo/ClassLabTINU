using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;

namespace ClassLabTINU
{
     public class Produto
    {
        //atributos
        private int Id { get; set; }
        private string Descrição { get; set; }
        private string Unidade { get; set; }
        private string Codbar { get; set; }
        private double Valor { get; set; }
        private double Desconto { get; set; }
        private bool Descontinuado { get; set; }
        //propriedades

        // Construtores 





        public Produto(int id, string descricao, string unidade, string codbar, double valor)
        {
            Id = id;
            this.Descrição = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
          
        }


        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.Descrição = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            
        }
        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Id = id;
            this.Descrição = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            this.Descontinuado = descontinuado;
        }



        // Metodos 

        public void Inserir()
        {
            // Abre conexão com banco
            var banco = Banco.Abrir();

            // Comandos SQL
            banco.CommandType = CommandType.StoredProcedure;
            banco.CommandText = "produto_inserir";

            // Parametros
            banco.Parameters.AddWithValue("_descricao", Descrição);
            banco.Parameters.AddWithValue("_unidade", Unidade);
            banco.Parameters.AddWithValue("_codbar", Codbar);
            banco.Parameters.AddWithValue("_valor", Valor);
            banco.Parameters.AddWithValue("_desconto", Desconto);
            Id = Convert.ToInt32(banco.ExecuteScalar());

            // Fecha Conexão
            banco.Connection.Close();

        }


        public List<Produto> ListarTodos(int i = 0, int l = 0)
        {
            // Nova lista
            List<Produto> lista = new List<Produto>();

            // Abrir conexão
            var banco = Banco.Abrir();

            // Comando
            banco.CommandType = CommandType.Text;
            if (l > 0)
                banco.CommandText = $"select * from produtos limit {i} , {l}";
            else
                banco.CommandText = "select * from produtos";

            // Var para Consulta
            var dr = banco.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                lista.Add(new Produto(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                   ));
            }

            // Fecha Conexão
            banco.Connection.Close();

            // Retornando lista
            return lista;
        }





    }

}
