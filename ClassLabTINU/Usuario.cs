﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabTINU
{


    public class Usuario
    {
        // atributos (campos)
        private int Id { set; get; }
        private string Nome { set; get; }
        private string Email { set; get; }
        private Nivel Nivel { set; get; }
        private string Senha { set; get; }
        private bool Ativo { set; get; }

       

        // métodos Construtores
        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email,  string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            
            Senha = senha;
        }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            //dataCad = DateTime.Now;
            //ativo = true;
        }

        public Usuario(string nome, string email, Nivel nivel, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Nivel = nivel;
            this.Senha = senha;
        }

        public Usuario(int iD, string nome, string senha, string email, bool ativo)
        {
            Id = iD;
            Nome = nome;
            Senha = senha;
            Email = email;
            Ativo = ativo;
        }
        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usuarios_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_email", Email);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public static bool EfetuarLogin(string email, string senha)
        {


            // realiza validação e devolve verdadeiro ou falso
            return false;
        }

        //métodos da classe
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usuarios_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_senha", Senha );
            cmd.Parameters.AddWithValue("_email", Email);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public bool alterar(int _id, string _nome,  string _senha, string _email)
        {
            bool resultado = false;
            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                // recebe o nome da procedure
                cmd.CommandText = "alterar_usuarios";
                // recebe os paremetros da procedure - lá do Mysql
                // cmd.Parameters.Add("_id",MySqlDbType.Int32).Value = _id;
                cmd.Parameters.AddWithValue("_id", _id);
                cmd.Parameters.AddWithValue("_nome", _nome);
                cmd.Parameters.AddWithValue("_email", _email);
                cmd.Parameters.AddWithValue("_email", _senha);
                cmd.ExecuteNonQuery();
                resultado = true;
                cmd.Connection.Close();
            }
            catch
            {

            }
            return resultado;
        }
        public static Usuario consultarPorID(int _id)
        {
            Usuario usuario = new Usuario();
            return usuario;
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new Usuario(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetBoolean(5)
                    ));
            }
            return usuarios;







        }    }
}