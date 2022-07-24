using CRUD.src;
using CRUD.src.enums;
using System;
using System.Collections.Generic;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();
            int InOutGeneral;

            do
            {
                Console.Clear();
                Console.Write("-- CRUD Carro --\n" +
                    "1 - Cadastro de carro\n" +
                    "2 - Cadastro de carro na posição\n" +
                    "3 - Lista de carro\n" +
                    "4 - Remover carro\n" +
                    "-- Opção escolhida: ");
                int opCRUD = int.Parse(Console.ReadLine());

                switch (opCRUD)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-- Cadastro de carro --");
                        Console.Write("\nDigite a quantidade de carros para registrar: ");
                        int NumRegistroCarro = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= NumRegistroCarro; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("-- Marcas Registradas --\n" +
                                "1 - Ferrari\n" +
                                "2 - Fiat\n" +
                                "3 - Aston Martin\n" +
                                "4 - Porsche\n" +
                                "5 - BMW\n");

                            Console.WriteLine($"\n-- Carro {i} --");
                            Console.Write("Marca do carro: ");
                            Marcas marca = Enum.Parse<Marcas>(Console.ReadLine());
                            Console.Write("Modelo do carro: ");
                            string modelo = Console.ReadLine();
                            Console.Write("Ano de fabricação do carro: ");
                            int anoFabricacao = int.Parse(Console.ReadLine());

                            carros.Add(new Carro(marca, modelo, anoFabricacao));
                        }

                        Console.WriteLine($"\n-- Carro(s) registrado(s) --\n");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine($"-- Cadastrando na posição --");

                        foreach (Carro carro in carros)
                        {
                            Console.WriteLine(carro.ToString());
                        }

                        Console.Write("\nDigite a posição deseja inserir um novo carro: ");
                        int InsertPosition = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("\n-- Marcas Registradas --\n" +
                            "1 - Ferrari\n" +
                            "2 - Fiat\n" +
                            "3 - Aston Martin\n" +
                            "4 - Porsche\n" +
                            "5 - BMW\n");

                        Console.WriteLine($"\n-- Inserindo na posição --");
                        Console.Write("Marca do carro: ");
                        Marcas marcas = Enum.Parse<Marcas>(Console.ReadLine());
                        Console.Write("Modelo do carro: ");
                        string ModeloInsert = Console.ReadLine();
                        Console.Write("Ano de fabricação do carro: ");
                        int anoFabricacaoInsert = int.Parse(Console.ReadLine());

                        carros.Insert(InsertPosition, new Carro(marcas, ModeloInsert, anoFabricacaoInsert));

                        Console.WriteLine($"\n-- Carro registrado na posição {InsertPosition} --");
                        foreach (Carro carro in carros)
                        {
                            Console.WriteLine(carro.ToString());
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (carros.Count == 0)
                        {
                            Console.WriteLine("-- Lista de carro --\n");
                            Console.WriteLine("### A lista está vazia! - É preciso cadastrar um carro! ###");
                        }
                        else
                        {
                            Console.WriteLine("-- Lista de carro --\n");
                            foreach (Carro carro in carros)
                            {
                                Console.WriteLine(carro.ToString());
                            }
                        }
                        break;

                    case 4:
                        Console.Clear();
                        if (carros.Count == 0)
                        {
                            Console.WriteLine("-- Remover de carro --\n");
                            Console.WriteLine("### A lista está vazia! - É preciso cadastrar um carro! ###");
                        }
                        else
                        {
                            Console.WriteLine("-- Remover de carro --\n");

                            Console.WriteLine($"-- ANTES de excluir algum elemento --\n");
                            foreach (Carro carro in carros)
                            {
                                Console.WriteLine(carro.ToString());
                            }

                            Console.Write("\nDigite a posição do carro para remover: ");
                            int RemovePosition = int.Parse(Console.ReadLine());
                            carros.RemoveAt(RemovePosition);

                            Console.WriteLine($"\n-- DEPOIS de excluir algum elemento --\n");
                            foreach (Carro carro in carros)
                            {
                                Console.WriteLine(carro.ToString());
                            }

                            Console.Write($"\n-- Carro da posição {RemovePosition} foi removido com sucesso --\n");
                        }
                        break;

                    default:
                        Console.WriteLine("\n-- Entre com opção válida!! --");
                        break;
                }

                Console.Write("\nDeseja encerrar o programa?\n" +
                    "0 - Não | 1 - Sim\n" +
                    "Opção escolhida: ");
                InOutGeneral = int.Parse(Console.ReadLine());
            } while (InOutGeneral != 1);
            Console.WriteLine("\n-- O programa foi encerrado! --");
        }
    }
}
