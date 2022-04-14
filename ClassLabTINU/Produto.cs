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
        private int id;
        private string descrição;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        //propriedades
        public int ID { get { return id; } set { id = value; } }
        public string Descrição { get { return descrição; } set { descrição = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string Codbar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        private double Desconto { get { return desconto; } set { desconto = value; } }
        public bool Descontinuado { get => descontinuado; }

        // Construtores 

        public Produto()
        {
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            id = id;
            this.Descrição = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor)
        {
            id = this.id;
            this.Descrição = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
        }


        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.Descrição = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
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
            id = Convert.ToInt32(banco.ExecuteScalar());

            // Fecha Conexão
            banco.Connection.Close();

        }

        public void Alterar(Produto Produto)
        {

        }

        public void ConsultarPorId(int _id)
        {

        }

        public void ConsultarPorValor(int _valor)
        {
        }

        public List<Produto> ConsultarPorDescricao(string _descricao)
        {
            List<Produto> lista = new List<Produto>();
            return lista;
        }

        public void ConsultarPorCodbar(int _codbar)
        {
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
