﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

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
            MySqlCommand cmd = Banco.Abrir();

            // Comandos SQL
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produtos_inserir";

            // Parametros
            cmd.Parameters.AddWithValue("_descricao", Descrição);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_codbar", Codbar);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_desconto", Desconto);
            cmd.ExecuteNonQuery();
            // Fecha Conexão
            cmd.Connection.Close();
           

        }


        public List<Produto> ListarTodos(string descriParte = null)
        {
            // Nova lista
            List<Produto> produtos = new List<Produto>();

            // Abrir conexão
            MySqlCommand cmd = Banco.Abrir();

            // Comando
            if (descriParte == null)
            {// Lista produtos ativos ordenados alfabéticamente
                cmd.CommandText = "select * from produtos where descontinuado = order by 2";
            }
            else
            {// Lista produtos ativos, por parte da descrição e ordenados alfabéticamente
                cmd.CommandText = "select * from produtos where descontinuado = 0 and dracricao like '%" + descriParte + "%' order by 2  ";

            }
            // Var para Consulta
            MySqlDataReader dr = cmd.ExecuteReader();

            // Consulta
            while (dr.Read())
            {
                produtos.Add(new Produto(
                    Convert.ToInt32(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                   ));
            }

            // Fecha Conexão
            cmd.Connection.Close();

            // Retornando lista
            return produtos;
        }





    }

}
