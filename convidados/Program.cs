using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convidados
{
    class Program
    {
        class Convidado
        {
            public string nome;
            public int idade;
            public Convidado proximo;
        }

        class Lista
        {
            public Convidado inicio = null;

            public bool existe(string nome)
            {
                Convidado aux = inicio;

                while (aux!=null && aux.nome!=nome)
                {
                    aux = aux.proximo;
                }

                return (aux != null);
            }
            public void exibir()
            {
                Convidado aux = inicio;

                while (aux!=null)
                {
                    Console.WriteLine($"Nome: {aux.nome}");
                    Console.WriteLine($"Idade: {aux.idade}");
                    Console.WriteLine($"Telefone: {aux.telefone}");

                    aux = aux.proximo;
                }
            }

            public void inserir(string nome, int idade, string telefone)
            {
                Convidado novo;
                if (existe(nome))
                {
                    Console.WriteLine("Convidado ja está na lista");
                }
                else
                {
                    novo = new Convidado();
                    novo.nome = nome;
                    novo.idade = idade;
                    novo.telefone = telefone;
                    novo.proximo = inicio;
                    inicio = novo;

                    Console.WriteLine("Convidado inserido na lista com sucesso!");
                }
            }
            public void remover (string nome)
            {
                Convidado aux, ant;
                if (!existe(nome))
                {
                    Console.WriteLine("Convidado não está na lista");
                }
                else
                {
                    aux = inicio;
                    ant = null;

                    while (aux.nome != nome)
                    {
                        ant = aux;
                        aux = aux.proximo;
                    }

                    if (aux == inicio)
                    {
                        inicio = inicio.proximo;
                    }
                    else
                    {
                        ant.proximo = aux.proximo;
                    }

                    Console.WriteLine("Convidado removido da lista");
                }
            }
        }
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Exibir lista");
            Console.WriteLine("2 - Inserir convidado");
            Console.WriteLine("3 - Remover convidado");
            Console.WriteLine("4 - Consultar convidado");
            Console.WriteLine("5 - Consultar velhos");
            Console.WriteLine("6 - Remover jovens");
            Console.WriteLine("15 - Sair");
            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            int op, idade;
            string nome, telefone;
            Lista minhaLista = new Lista();
            do
            {
                op = menu();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        minhaLista.exibir();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Nome: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Idade: ");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Telefone: ");
                        telefone = Console.ReadLine();

                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        minhaLista.remover(nome);

                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;
                }

            } while (op != 15);
        }
    }
}
