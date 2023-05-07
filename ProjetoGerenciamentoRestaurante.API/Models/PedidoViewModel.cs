using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjetoGerenciamentoRestaurante.API.Models
{
    public class PedidoViewModel
    {
        public GarconModel? Garcon { get; set; }
        public double totalVendas { get; set; }
        public int countPedidos { get; set; }
        public double quantidadeTotal { get; set; }
    }
}