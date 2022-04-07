using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabTINU
{            
    public class Cliente
    {
        //atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        //propriedades
        public int ID { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

       

        //construtores
         public Cliente()
         {
         }

        public Cliente(string nome, string cpf, string email  )
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;      
            //dataCad = DateTime.Now;
            //ativo = true;
        }

        public Cliente(int iD, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            ID = iD;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }



        //métodos da classe
        public void inserir(Cliente cliente)
        {

        }
        public bool alterar (Cliente cliente)
        {
            return true;
        }
        public static Cliente consultarPorID(int _id) 
        {
            Cliente cliente = new Cliente();
                //cena dos proximos episódios...
           return cliente;
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            //cena dos proximos espisódios
            return clientes;
        }
        



    }
}
