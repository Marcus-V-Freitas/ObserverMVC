using ObserverMVC.Models;

namespace ObserverMVC.Services.Interfaces
{
    public interface IPedidoService : IPedidoNotificador
    {
        void AtualizarPedido(Pedido pedido);
    }
}