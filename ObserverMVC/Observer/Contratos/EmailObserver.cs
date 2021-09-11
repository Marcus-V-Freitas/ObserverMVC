using ObserverMVC.Models;
using ObserverMVC.Observer.Interfaces;
using System;

namespace ObserverMVC.Observer.Contratos
{
    public class EmailObserver : IPedidoObserver
    {
        public void Atualizar(Pedido pedido)
        {
            Console.WriteLine($"Número Pedido {pedido.NumeroPedido} teve seu status atualizado para: {pedido.PedidoStatus}. Um email será enviado para o cliente.");
        }
    }
}