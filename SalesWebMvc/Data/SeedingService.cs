﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Vendedor.Any() ||
                _context.Vendas.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Moda");
            Department d2 = new Department(2, "Cosméticos");
            Department d3 = new Department(3, "Outros");

            Vendedor v1 = new Vendedor(1, "João Silva", "joao@gmail.com", new DateTime(1998, 04, 21), 1000.0, d3);
            Vendedor v2 = new Vendedor(2, "Maria Castro", "maria@bol.com.br", new DateTime(1991, 12, 08), 1200.0, d1);
            Vendedor v3 = new Vendedor(3, "Ana Ferreira", "ana@yahoo.com.br", new DateTime(1985, 05, 19), 1300.0, d2);
            Vendedor v4 = new Vendedor(4, "Lucia Gomes", "luciagomes@uol.com.br", new DateTime(1991, 02, 17), 1200.0, d2);
            Vendedor v5 = new Vendedor(5, "Antonio Gonçalves", "agoncalves@gmail.com.br", new DateTime(1988, 06, 23), 1500.0, d3);
            Vendedor v6 = new Vendedor(6, "Julia Rufino", "juliar@hotmail.com", new DateTime(1996, 02, 08), 1350.0, d1);

            Vendas r1 = new Vendas(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Faturado, v1);
            Vendas r2 = new Vendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Faturado, v5);
            Vendas r3 = new Vendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Cancelado, v4);
            Vendas r4 = new Vendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Faturado, v1);
            Vendas r5 = new Vendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Faturado, v3);
            Vendas r6 = new Vendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Faturado, v1);
            Vendas r7 = new Vendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, v2);
            Vendas r8 = new Vendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Faturado, v4);
            Vendas r9 = new Vendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, v6);
            Vendas r10 = new Vendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Faturado, v6);
            Vendas r11 = new Vendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Faturado, v2);
            Vendas r12 = new Vendas(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, v3);
            Vendas r13 = new Vendas(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Faturado, v4);
            Vendas r14 = new Vendas(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Faturado, v5);
            Vendas r15 = new Vendas(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Faturado, v1);
            Vendas r16 = new Vendas(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Faturado, v4);
            Vendas r17 = new Vendas(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Faturado, v1);
            Vendas r18 = new Vendas(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Faturado, v3);
            Vendas r19 = new Vendas(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Faturado, v5);
            Vendas r20 = new Vendas(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Faturado, v6);
            Vendas r21 = new Vendas(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Faturado, v2);
            Vendas r22 = new Vendas(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Faturado, v4);
            Vendas r23 = new Vendas(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelado, v2);
            Vendas r24 = new Vendas(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Faturado, v5);
            Vendas r25 = new Vendas(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Faturado, v3);
            Vendas r26 = new Vendas(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Faturado, v4);
            Vendas r27 = new Vendas(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, v1);
            Vendas r28 = new Vendas(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Faturado, v3);
            Vendas r29 = new Vendas(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Faturado, v5);
            Vendas r30 = new Vendas(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Faturado, v2);

            _context.Department.AddRange(d1, d2, d3);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.Vendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();

        }
    }
}