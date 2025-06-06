using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS_C_.Models
{
    // Classe que representa uma falha cibernética, herda de Evento.
    public class FalhaCibernetica : Evento
    {
        // Tipo de ataque (Ex: Ransomware, Phishing).
        public string TipoAtaque { get; private set; }

        // Construtor para inicializar a falha cibernética.
        public FalhaCibernetica(int id, DateTime data, string descricao, string tipoAtaque)
            : base(id, data, descricao)
        {
            TipoAtaque = tipoAtaque;
        }

        // Sobrescreve o método ExibirDetalhes para incluir tipo de ataque.
        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Tipo de Ataque: {TipoAtaque}");
        }
    }
}



