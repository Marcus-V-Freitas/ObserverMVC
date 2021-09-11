using ObserverMVC.Models;
using ObserverMVC.Observer.Interfaces;

namespace ObserverMVC.Services.Interfaces
{
    public interface IPedidoNotificador
    {
        void Anexar(IPedidoObserver observer);

        void Desanexar(IPedidoObserver observer);

        void Notificar(Pedido pedido);
    }
}