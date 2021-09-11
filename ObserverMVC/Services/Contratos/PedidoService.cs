using ObserverMVC.Models;
using ObserverMVC.Observer.Interfaces;
using ObserverMVC.Services.Interfaces;
using System.Collections.Generic;

namespace ObserverMVC.Services.Contratos
{
    public class PedidoService : IPedidoService
    {
        private List<IPedidoObserver> observers = new();

        public void Anexar(IPedidoObserver observer)
        {
            observers.Add(observer);
        }

        public void AtualizarPedido(Pedido pedido)
        {
            Notificar(pedido);
        }

        public void Desanexar(IPedidoObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notificar(Pedido pedido)
        {
            foreach (var observer in observers)
            {
                observer.Atualizar(pedido);
            }
        }
    }
}