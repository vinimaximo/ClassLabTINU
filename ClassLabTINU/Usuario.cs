using System;
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
        private int id;
        private string nome;
        private string email;
        private Nivel nivel;
        private string password;
        private bool ativo;

        // propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get { return nome; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password
        {
            get
            {
                // restrições
                return password;
            }

        }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        


        // métodos Construtores
        public Usuario()
        {
        }

        public Usuario(string nome, string cpf, string email)
        {
            nome = nome;
            password = cpf;
            Email = email;
            //dataCad = DateTime.Now;
            //ativo = true;
        }

        public Usuario(string nome, string email, Nivel nivel, string password)
        {
            this.nome = nome;
            this.email = email;
            this.nivel = nivel;
            this.password = password;
        }

        public Usuario(int iD, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            id = iD;
            nome = nome;
            password = cpf;
            Email = email;
            dataCad = dataCad;
            Ativo = ativo;
        }
        // métodos da classe
        public int Inserir()
        {
            // chamadas de banco e gravo o registro
            return id;
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
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_password", password );
            cmd.Parameters.AddWithValue("_email", Email);
            
            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public bool alterar(Usuario usuario)
        {
            return true;
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
                   dr.GetDateTime(4),
                   dr.GetBoolean(5)
                    ));
            }
            return usuarios;







        }    }
}