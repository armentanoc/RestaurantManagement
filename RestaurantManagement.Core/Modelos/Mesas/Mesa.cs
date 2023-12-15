using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Core.Modelos.Mesas
{
    public  class Mesa
    {
        public int Numero { get; set; }
        public int QuantidadeCadeiras { get; set; }
        public bool AreaExterna { get; set; }

        public Mesa(int numero, int quantidadeCadeiras, bool areaExterna) {
            Numero = numero;
            QuantidadeCadeiras = quantidadeCadeiras;
            AreaExterna = areaExterna;
        }

        public void LevarAreaExterna()
        {
            AreaExterna = true;
        }

    }
}
