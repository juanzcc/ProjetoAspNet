using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoAspNet.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendedores> Vendas { get; set; } = new List<RegistroVendedores>();

        public Vendedor()
        {

        }
        public Vendedor(int id, string nome, string email, DateTime dataNasc, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void addVendas(RegistroVendedores rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RegistroVendedores rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Quantia);
        }
    }
}
