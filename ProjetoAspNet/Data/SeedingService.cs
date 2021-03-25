using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAspNet.Models;
using ProjetoAspNet.Models.Enums;


namespace ProjetoAspNet.Data
{
    public class SeedingService
    {
        private ProjetoAspNetContext _context;

        public SeedingService(ProjetoAspNetContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendedores.Any())
            {
                return; // Db ja tem informações
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Clark Kent", "superman@gmail.com", new DateTime(1938, 1, 1), 1000.0, d1);
            Vendedor v2 = new Vendedor(2, "Steve Rogers", "capitao@gmail.com", new DateTime(1918, 7, 4), 3500.0, d2);
            Vendedor v3 = new Vendedor(3, "Bruce Wayne", "batman@gmail.com", new DateTime(1940, 1, 1), 2200.0, d1);
            Vendedor v4 = new Vendedor(4, "Tony Stark", "homemferro@gmail.com", new DateTime(1970, 5, 29), 3000.0, d4);
            Vendedor v5 = new Vendedor(5, "Barry Allen", "flash@gmail.com", new DateTime(1940, 1, 1), 4000.0, d3);
            Vendedor v6 = new Vendedor(6, "Peter Parker", "homemaranha@gmail.com", new DateTime(2001, 8, 10), 3000.0, d2);

            RegistroVendedores r1 = new RegistroVendedores(1, new DateTime(2018, 09, 25), 11000.0, StatusVendedores.Billed, v1);
            RegistroVendedores r2 = new RegistroVendedores(2, new DateTime(2018, 09, 4), 7000.0, StatusVendedores.Billed, v5);
            RegistroVendedores r3 = new RegistroVendedores(3, new DateTime(2018, 09, 13), 4000.0, StatusVendedores.Canceled, v4);
            RegistroVendedores r4 = new RegistroVendedores(4, new DateTime(2018, 09, 1), 8000.0, StatusVendedores.Billed, v1);
            RegistroVendedores r5 = new RegistroVendedores(5, new DateTime(2018, 09, 21), 3000.0, StatusVendedores.Billed, v3);
            RegistroVendedores r6 = new RegistroVendedores(6, new DateTime(2018, 09, 15), 2000.0, StatusVendedores.Billed, v1);
            RegistroVendedores r7 = new RegistroVendedores(7, new DateTime(2018, 09, 28), 13000.0, StatusVendedores.Billed, v2);
            RegistroVendedores r8 = new RegistroVendedores(8, new DateTime(2018, 09, 11), 4000.0, StatusVendedores.Billed, v4);
            RegistroVendedores r9 = new RegistroVendedores(9, new DateTime(2018, 09, 14), 11000.0, StatusVendedores.Pending, v6);
            RegistroVendedores r10 = new RegistroVendedores(10, new DateTime(2018, 09, 7), 9000.0, StatusVendedores.Billed, v6);
            RegistroVendedores r11 = new RegistroVendedores(11, new DateTime(2018, 09, 13), 6000.0, StatusVendedores.Billed, v2);
            RegistroVendedores r12 = new RegistroVendedores(12, new DateTime(2018, 09, 25), 7000.0, StatusVendedores.Pending, v3);
            RegistroVendedores r13 = new RegistroVendedores(13, new DateTime(2018, 09, 29), 10000.0, StatusVendedores.Billed, v4);
            RegistroVendedores r14 = new RegistroVendedores(14, new DateTime(2018, 09, 4), 3000.0, StatusVendedores.Billed, v5);
            RegistroVendedores r15 = new RegistroVendedores(15, new DateTime(2018, 09, 12), 4000.0, StatusVendedores.Billed, v1);
            RegistroVendedores r16 = new RegistroVendedores(16, new DateTime(2018, 10, 5), 2000.0, StatusVendedores.Billed, v4);
            RegistroVendedores r17 = new RegistroVendedores(17, new DateTime(2018, 10, 1), 12000.0, StatusVendedores.Billed, v1);
            RegistroVendedores r18 = new RegistroVendedores(18, new DateTime(2018, 10, 24), 6000.0, StatusVendedores.Billed, v3);
            RegistroVendedores r19 = new RegistroVendedores(19, new DateTime(2018, 10, 22), 8000.0, StatusVendedores.Billed, v5);
            RegistroVendedores r20 = new RegistroVendedores(20, new DateTime(2018, 10, 15), 8000.0, StatusVendedores.Billed, v6);
            RegistroVendedores r21 = new RegistroVendedores(21, new DateTime(2018, 10, 17), 9000.0, StatusVendedores.Billed, v2);
            RegistroVendedores r22 = new RegistroVendedores(22, new DateTime(2018, 10, 24), 4000.0, StatusVendedores.Billed, v4);
            RegistroVendedores r23 = new RegistroVendedores(23, new DateTime(2018, 10, 19), 11000.0, StatusVendedores.Canceled, v2);
            RegistroVendedores r24 = new RegistroVendedores(24, new DateTime(2018, 10, 12), 8000.0, StatusVendedores.Billed, v5);
            RegistroVendedores r25 = new RegistroVendedores(25, new DateTime(2018, 10, 31), 7000.0, StatusVendedores.Billed, v3);
            RegistroVendedores r26 = new RegistroVendedores(26, new DateTime(2018, 10, 6), 5000.0, StatusVendedores.Billed, v4);
            RegistroVendedores r27 = new RegistroVendedores(27, new DateTime(2018, 10, 13), 9000.0, StatusVendedores.Pending, v1);
            RegistroVendedores r28 = new RegistroVendedores(28, new DateTime(2018, 10, 7), 4000.0, StatusVendedores.Billed, v3);
            RegistroVendedores r29 = new RegistroVendedores(29, new DateTime(2018, 10, 23), 12000.0, StatusVendedores.Billed, v5);
            RegistroVendedores r30 = new RegistroVendedores(30, new DateTime(2018, 10, 12), 5000.0, StatusVendedores.Billed, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
            _context.RegistroVendedores.AddRange(r1, r2, r3, r4, r5
                ,r6, r6, r8, r9, r10
                ,r11,r12,r13,r14,r15
                ,r16,r17,r18,r19,r20
                ,r21,r22,r23,r24,r25
                ,r26,r27,r28,r29,r30
                );

            _context.SaveChanges();
        }
    }
}
