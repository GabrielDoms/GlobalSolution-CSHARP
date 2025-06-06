using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_C_.Models
{
    // Classe base para representar um evento genérico no sistema.
    public class Evento
    {
        // Identificador único do evento.
        public int Id { get; private set; }

        // Data e hora em que o evento ocorreu.
        public DateTime Data { get; private set; }

        // Descrição geral do evento.
        public string Descricao { get; private set; }

        // Construtor para inicializar o evento com ID, data e descrição.
        public Evento(int id, DateTime data, string descricao)
        {
            Id = id;
            Data = data;
            Descricao = descricao;
        }

        // Método virtual que exibe os detalhes do evento na tela.
        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {Id} | Data: {Data} | Descrição: {Descricao}");
        }
    }
}



