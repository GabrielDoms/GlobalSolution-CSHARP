using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS_C_.Controllers;
using GS_C_.Models;

namespace GS_C_.Views
{
    // Classe responsável pela interface de console com o usuário.
    public class InterfaceConsole
    {
        private GerenciadorEventos gerenciador = new GerenciadorEventos();
        private Usuario usuario = new Usuario("rm98630", "230804");

        // Método principal que inicia o sistema.
        public void Iniciar()
        {
            if (!Login())
            {
                Console.WriteLine("Acesso negado. Programa encerrado.");
                return;
            }

            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==== Sistema de Monitoramento de Falhas ====");
                Console.WriteLine("1. Registrar Falha de Energia");
                Console.WriteLine("2. Registrar Falha Cibernética");
                Console.WriteLine("3. Listar Todos os Eventos");
                Console.WriteLine("4. Gerar Relatório de Eventos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarFalhaEnergia();
                        break;
                    case "2":
                        RegistrarFalhaCibernetica();
                        break;
                    case "3":
                        gerenciador.ListarEventos();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        gerenciador.GerarRelatorio();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != "0");
        }

        // Método para autenticar o usuário no sistema.
        private bool Login()
        {
            Console.WriteLine("===== LOGIN =====");
            Console.Write("Usuário: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (usuario.Autenticar(login, senha))
            {
                Console.WriteLine("Login bem-sucedido! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos!");
                return false;
            }
        }

        // Método para coletar dados e registrar falha de energia.
        private void RegistrarFalhaEnergia()
        {
            try
            {
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();

                Console.Write("Criticidade (Baixa/Média/Alta): ");
                string criticidade = Console.ReadLine();

                gerenciador.RegistrarFalhaEnergia(data, descricao, criticidade);

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
                Console.ReadKey();
            }
        }

        // Método para coletar dados e registrar falha cibernética.
        private void RegistrarFalhaCibernetica()
        {
            try
            {
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();

                Console.Write("Tipo de Ataque: ");
                string tipoAtaque = Console.ReadLine();

                gerenciador.RegistrarFalhaCibernetica(data, descricao, tipoAtaque);

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}
