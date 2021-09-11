using ObserverMVC.Models;
using ObserverMVC.Observer.Interfaces;
using System;

namespace ObserverMVC.Observer.Contratos
{
    public class SmsObserver : IPedidoObserver
    {
        public void Atualizar(Pedido pedido)
        {
            Console.WriteLine($"Número Pedido {pedido.NumeroPedido} teve seu status atualizado para: {pedido.PedidoStatus}. Um SMS será enviado para o cliente.");
        }
    }
}