using ObserverMVC.Models.Enum;
using System;

namespace ObserverMVC.Models
{
    public class Pedido
    {
        public string NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public PedidoStatus PedidoStatus { get; set; }
    }
}