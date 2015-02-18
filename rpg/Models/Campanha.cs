using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rpg.Models
{
    public class Campanha
    {
        public int Cod_Campanha { get; set; }

        public int Cod_Mestre { get; set; }
        
        public String Descricao_Basica { get; set; }

        public String Descricao { get; set; }

        public bool Ativo { get; set; }

        public bool utilixar_Global { get; set; }
    }
}