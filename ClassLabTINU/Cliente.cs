﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
         public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_nome",Nome);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.Parameters.AddWithValue("_email", Email);
            ID = Convert.ToInt32 (cmd.ExecuteScalar());
            cmd.Connection.Close();
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
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome";
            var dr = cmd.ExecuteReader();   
            while (dr.Read())
            {
                clientes.Add(new Cliente(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetDateTime(4),
                   dr.GetBoolean(5)
                    ));
            }
            return clientes;
        }
        
        


    }
}
