using System;
using System.ComponentModel.DataAnnotations;

namespace Ingressos.Models
{
    public enum IngressoStatus
    {
        Disponível,
        Vendido,
        Reservado
    }

    public class Ingresso
    {
        [Key]
        public int Id { get; set; }
        public int EventoId { get; set; }
        public int UsuarioId { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCompra { get; set; }
        public IngressoStatus Status { get; set; }
    }
}
