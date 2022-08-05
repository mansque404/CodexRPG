using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodexRPG
{
    public class Personagem
    {
        public string Nome { get; set; } 
        public double HP { get; set; }
        public double Dano { get; set; }
        public double Bloqueio { get; set; }
        public Random Especial { get; set; }
    }
}