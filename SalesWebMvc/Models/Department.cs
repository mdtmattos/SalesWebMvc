using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }

        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendedor.Sum(vendedor => vendedor.TotalVendas(initial, final));
        }
    }
}
