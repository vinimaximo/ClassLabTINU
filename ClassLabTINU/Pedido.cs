using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassLabTINU
{
    public class Pedido
    {
        // idped data status_ped desconto idcli_ped iduser_ped
        // Atributos

        // Propriedades
        public int Id { get; set; }
        public DateTime DataPed { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        // Construtores 
        public Pedido() { }

         
        public Pedido (int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {    
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
   
 
        }
        // Métodos da classe - Operações/Ações/Funções
        public void Inserir() { }
        public bool Alterar(Pedido pedido)
        {
            return false;
        }
        public static List<Pedido> ConsultarClienteId(int _id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            //Graça...conecta ao banco e realiza a consulta pelo id do cliente
            return  pedidos;
        }


    
    
    
    
    
    
    
    
    
    
    
    }
}
