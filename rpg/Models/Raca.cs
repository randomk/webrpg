using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rpg.Models
{
    public class Raca
    {
        public int Cod_Raca { get; set; }

        public String Descricao_Basica { get; set; }

        public String Descricao { get; set; }

        public int Campanha { get; set; } //admin pode cria raca global (campanha 0) mestre tem q escolher a campanha (dele)

        public String Vantagens { get; set; }

        public String Pericias { get; set; }

        public bool Utilizar_Global { get; set; }

        public int Custo { get; set; }

        public bool Ativo { get; set; }
    }
}