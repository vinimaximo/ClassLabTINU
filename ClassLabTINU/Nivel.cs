using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabTINU
{
    public class Nivel
    { // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        public readonly bool ativo;

        //criando propriedades 
        public int ID { get { return id; } }
        public string Nome { get { return nome;} private set { nome = value; } }
        public string Sigla { get { return sigla; } }
        
        
        //Métodos contrutores
        
        public Nivel()
        {
        }

        public Nivel(string nome, string sigla, bool ativo)
        {
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }

        public Nivel(int id, string nome, string sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }
        //metodos da classe
        public void inserirNovo()
        {
            // inserir um novo nível

        }
           
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">Identificação do nível</param>
        /// <param name="sigla">Valor literal da nova sigla</param>
        /// <returns>Retorna valor para teste lógico, confirmando a alteração</returns>
        public bool Alterar(int id, string sigla)
        {
            return true;
        }
           
    
    
    
    
    
    
    
    
    
    }  
    





}
