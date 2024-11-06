using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaçãoAutomovel
{
    public class Veiculo
    {
        public Marca Marca {  get; set; }
        public  Modelo Modelo  { get; set; }
        public bool Teto {get; set; }
        public int Portas { get; set; }
        public Motor Motor { get; set; }
    }

}
