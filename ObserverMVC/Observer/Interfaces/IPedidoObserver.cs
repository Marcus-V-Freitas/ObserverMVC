using ObserverMVC.Models;

namespace ObserverMVC.Observer.Interfaces
{
    public interface IPedidoObserver
    {
        void Atualizar(Pedido pedido);
    }
}