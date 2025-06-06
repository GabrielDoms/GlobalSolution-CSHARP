using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GS_C_.Models;
using System.Text;

namespace GS_C_.Controllers
{
    // Classe controladora responsável por gerenciar os eventos.
    public class GerenciadorEventos
    {
        // Lista que armazena todos os eventos registrados.
        private List<Evento> eventos = new List<Evento>();

        // Variável para gerar IDs incrementais automaticamente.
        private int proximoId = 1;

        // Método para registrar uma falha de energia no sistema.
        public void RegistrarFalhaEnergia(DateTime data, string descricao, string criticidade)
        {
            try
            {
                // Validação de campos obrigatórios.
                if (string.IsNullOrWhiteSpace(descricao) || string.IsNullOrWhiteSpace(criticidade))
                    throw new ArgumentException("Descrição e Criticidade não podem estar vazias.");

                // Cria uma nova instância de FalhaEnergia.
                var falha = new FalhaEnergia(proximoId++, data, descricao, criticidade);
                eventos.Add(falha);

                Console.WriteLine("Falha de energia registrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
            }
        }

        // Método para registrar uma falha cibernética no sistema.
        public void RegistrarFalhaCibernetica(DateTime data, string descricao, string tipoAtaque)
        {
            try
            {
                // Validação de campos obrigatórios.
                if (string.IsNullOrWhiteSpace(descricao) || string.IsNullOrWhiteSpace(tipoAtaque))
                    throw new ArgumentException("Descrição e Tipo de Ataque não podem estar vazios.");

                // Cria uma nova instância de FalhaCibernetica.
                var falha = new FalhaCibernetica(proximoId++, data, descricao, tipoAtaque);
                eventos.Add(falha);

                Console.WriteLine("Falha cibernética registrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
            }
        }

        // Método que lista todos os eventos registrados.
        public void ListarEventos()
        {
            Console.WriteLine("\n===== Lista de Eventos =====");
            if (eventos.Count == 0)
            {
                Console.WriteLine("Nenhum evento registrado.");
            }
            else
            {
                // Exibe os detalhes de cada evento.
                foreach (var evento in eventos)
                {
                    evento.ExibirDetalhes();
                    Console.WriteLine("----------------------------");
                }
            }
        }

        // Método para gerar o relatório de eventos em arquivo .txt.
        public void GerarRelatorio()
        {
            try
            {
                // Utiliza StringBuilder para montar o conteúdo do relatório.
                StringBuilder relatorio = new StringBuilder();
                relatorio.AppendLine("===== Relatório de Eventos =====");

                foreach (var evento in eventos)
                {
                    relatorio.AppendLine($"ID: {evento.Id} | Data: {evento.Data} | Descrição: {evento.Descricao}");
                }

                // Salva o arquivo no diretório de execução.
                string caminho = "relatorio_eventos.txt";
                File.WriteAllText(caminho, relatorio.ToString());

                Console.WriteLine($"Relatório gerado com sucesso em: {caminho}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar relatório: {ex.Message}");
            }
        }
    }
}
