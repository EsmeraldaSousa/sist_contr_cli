using System;
using System.Globalization;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;

            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();

            if (var_tipo.ToLower() == "f")
            {
                // Pessoa Física
                Pessoa_Fisica pf = new Pessoa_Fisica
                {
                    nome = var_nome,
                    endereco = var_endereco
                };

                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine($"Nome ..........: {pf.nome}");
                Console.WriteLine($"Endereço ......: {pf.endereco}");
                Console.WriteLine($"CPF ...........: {pf.cpf}");
                Console.WriteLine($"RG ............: {pf.rg}");
                Console.WriteLine($"Valor de Compra: {pf.valor.ToString("C", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"Imposto .......: {pf._imposto.ToString("C", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"Total a Pagar : {pf.total.ToString("C", CultureInfo.CurrentCulture)}");
            }
            else if (var_tipo.ToLower() == "j")
            {
                // Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica
                {
                    nome = var_nome,
                    endereco = var_endereco
                };

                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine($"Nome ..........: {pj.nome}");
                Console.WriteLine($"Endereço ......: {pj.endereco}");
                Console.WriteLine($"CNPJ ..........: {pj.cnpj}");
                Console.WriteLine($"IE ............: {pj.ie}");
                Console.WriteLine($"Valor de Compra: {pj.valor.ToString("C", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"Imposto .......: {pj._imposto.ToString("C", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"Total a Pagar : {pj.total.ToString("C", CultureInfo.CurrentCulture)}");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
