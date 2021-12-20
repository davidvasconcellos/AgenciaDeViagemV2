using DigitalViagem.Enum;
using System;

namespace DigitalViagem.Models
{
    public class Viagem
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataVolta { get; set; }
        public DateTime DataPartida { get; set; }
        public string Valor  { get; set; }
        public Status Status { get; set; }
    }
}
