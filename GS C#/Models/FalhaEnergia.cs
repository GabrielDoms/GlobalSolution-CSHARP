using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_C_.Models
{
    // Classe que representa uma falha de energia, herda de Evento.
    public class FalhaEnergia : Evento
    {
        // Criticidade da falha (Baixa, Média ou Alta).
        public string Criticidade { get; private set; }

        // Construtor para inicializar a falha de energia.
        public FalhaEnergia(int id, DateTime data, string descricao, string criticidade)
            : base(id, data, descricao)
        {
            Criticidade = criticidade;
        }

        // Sobrescreve o método ExibirDetalhes para incluir criticidade.
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Criticidade: {Criticidade}");
        }
    }
}


