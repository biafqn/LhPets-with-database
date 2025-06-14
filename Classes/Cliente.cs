using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Web_LHPets.Classes
{
    public class Cliente
    {
        public string? cpf_cnpj { get; set; }
        
        public string? nome { get; set; }
        
        public string? endereco { get; set; }
        
        public string? rg_ie { get; set; }
        
        public string? tipo { get; set; }
        
        public float valor { get; set; }
        
        public float valor_imposto { get; set; }
        
        public float total { get; set; }       
    }
}