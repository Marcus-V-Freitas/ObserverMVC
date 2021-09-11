using Microsoft.AspNetCore.Mvc;
using ObserverMVC.Models;
using ObserverMVC.Models.Enum;
using ObserverMVC.Observer.Contratos;
using ObserverMVC.Services.Interfaces;
using System;

namespace ObserverMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public HomeController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Pedido pedido = new()
            {
                NumeroPedido = "NAGE121PE",
                DataPedido = DateTime.Now,
                ValorTotal = 105.99m,
                PedidoStatus = PedidoStatus.PagamentoPendente
            };

            return View(pedido);
        }

        [HttpPost]
        public IActionResult Index(Pedido pedido)
        {
            Console.WriteLine("Anexando Observers ...");

            SmsObserver sms = new();
            EmailObserver email = new();

            _pedidoService.Anexar(sms);
            _pedidoService.Anexar(email);

            AtualizarPedido(pedido);

            Console.WriteLine("Desanexando SMS ...");
            _pedidoService.Desanexar(sms);

            AtualizarPedido(pedido);

            return View(pedido);
        }

        private void AtualizarPedido(Pedido pedido)
        {
            Console.WriteLine("Atualizando o status do Pedido...");
            _pedidoService.AtualizarPedido(pedido);
        }
    }
}