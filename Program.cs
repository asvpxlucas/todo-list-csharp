using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClasseObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----- To-Do List -----");

            int indice = 0;
            string[] tarefa = new string[10];

            bool rodando = true;

            while (rodando)
            {

                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Remover tarefas");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a tarefa: ");
                        string digitarTarefa = Console.ReadLine();



                        if (indice < tarefa.Length)
                        {
                            tarefa[indice] = digitarTarefa;
                            indice++;
                        }
                        else
                        {
                            Console.WriteLine("Lista cheia");
                        }

                        break;
                    case 2:
                        Console.WriteLine("----------");
                        for (int i = 0; i < indice; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + tarefa[i]);

                        }
                        Console.WriteLine("----------");
                        break;
                    case 3:
                        Console.WriteLine("----------");
                        Console.WriteLine("Digite o número da tarefa que deseja remover:");
                        int opcaoRemover = int.Parse(Console.ReadLine());

                        int posicao = opcaoRemover - 1;

                        tarefa[posicao] = null;

                        Console.WriteLine("----------");

                        break;
                    case 4:
                        rodando = false;
                        break;
                }
            }

        }
    }
}
