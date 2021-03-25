using ProjetoAspNet.Models.Enums;
using System;

namespace ProjetoAspNet.Models
{
    public class RegistroVendedores
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusVendedores Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendedores()
        {

        }

        public RegistroVendedores(int id, DateTime data, double quantia, StatusVendedores status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
