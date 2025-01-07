using System;
using System.Collections.Generic;

namespace CadastroClientes
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();

        static void Main(string[] args) {
            bool executando = true;

            while (executando) {
                Console.WriteLine("\n1 - Adicionar cliente");
                Console.WriteLine("2 - Visualizar clientes");
                Console.WriteLine("3 - Editar cliente");
                Console.WriteLine("4 - Excluir cliente");
                Console.WriteLine("5 - Sair");
                Console.Write("Selecione uma opção:");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        VisualizarClientes();
                        break;
                    case 3:
                        EditarCliente();
                        break;
                    case 4:
                        ExcluirCliente();
                        break;
                    case 5:
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.\n");
                        break;
                }
            }
        }

        static void AdicionarCliente()
        {
            Console.Write("\nDigite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o e-mail do cliente: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(nome, email);
            clientes.Add(cliente);

            Console.WriteLine("Cliente adicionado com sucesso.\n");
        }

        static void VisualizarClientes()
        {
            foreach (Cliente cliente in clientes){
                if(cliente !=  null){
                Console.WriteLine("\nNome: " + cliente.Nome);
                Console.WriteLine("E-mail: " + cliente.Email);
                } else {
                Console.WriteLine("Nenhum cliente cadastrado.\n");
                }
            }   
        }

        static void EditarCliente()
        {
            Console.Write("\nDigite o nome do cliente que deseja editar: ");
            string nome = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.Nome == nome);

            if (cliente != null) {
                Console.Write("Digite o novo nome do cliente: ");
                string novoNome = Console.ReadLine();

                Console.Write("Digite o novo e-mail do cliente: ");
                string novoEmail = Console.ReadLine();

                cliente.Nome = novoNome;
                cliente.Email = novoEmail;

                Console.WriteLine("Cliente editado com sucesso.");
            } else {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        static void ExcluirCliente()
        {
            Console.Write("Digite o nome do cliente que deseja excluir: ");
            string nome = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.Nome == nome);

            if (cliente != null) {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente excluído com sucesso.");
            } else {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }

    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}