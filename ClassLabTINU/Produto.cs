using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
       
        //propriedades
        public int ID { get { return id; } set { id = value; } }
        public string Descrição { get { return descrição; } set { descrição = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string Codbar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        private double Desconto { get { return desconto; } set { desconto = value; } }
      
        //construtores
        public Produto()
        {
        }

        public Produto(string descrição, string unidade, string codbar, double valor)
        {
            Descrição = descrição;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
        }

        public Produto(int iD, string descrição, string unidade, string codbar, double valor, double desconto)
        {
            ID = iD;
            Descrição = descrição;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
            Desconto = desconto;
        }




        //métodos da classe
        public void inserir(Produto produto)
        {

        }
        public bool alterar(Produto produto)
        {
            return true;
        }
        public static Produto consultarPorID(int _id)
        {
            Produto produto = new Produto();            
            return produto;
        }
        public static Produto consultarPorDescrição(int _descrição)
        {
            Produto produto = new Produto();
            return produto;
        }
       public static Produto consultarPorCodbar(int _Codbar)
        {
            Produto produto = new Produto();
            return produto;
        }
        public static Produto consultarPorValor(int _Valor)
        {
            Produto produto = new Produto();
            return produto;
        }
        public static List<Produto> Listar()
        {
            List<Produto> produto = new List<Produto>();
            return produto;
        }



    }

}
