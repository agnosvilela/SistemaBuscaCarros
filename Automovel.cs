using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSCARROS
{
    public class Automovel
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public string Cor { get; set; } = string.Empty;

        // Construtor padrão
        public Automovel()
        {
            Marca = string.Empty;
            Modelo = string.Empty;
            Cor = string.Empty;
        }
    }


}
