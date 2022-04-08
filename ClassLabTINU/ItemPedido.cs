using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabTINU
{
    internal class ItemPedido
    {
        //iped_ip idprod_ip valor quantidade desconto
        //Atributos 
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;
    
        //Propriedades
        public Produto Produto { get { return produto; } set { produto = value; } } 
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }

        //Construtores
        public ItemPedido() { }

        public ItemPedido(Produto produto, double valor, double quantidade, double desconto)
        {
            this.produto = produto;
            this.valor = valor;
            this.quantidade = quantidade;
            this.desconto = desconto;
        }
    
    
        //Métodos da classe - Ação da classe
        public void Inserir() { }
        public void Alterar(ItemPedido item)
        {

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

}
