using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteadorDado.Models// contesto que ele compartilha(onde ele consegue enxegar)
{
    public class Dado
    {
        private int qteLados;
        private int ladoSorteado;

        public Dado(int lados)
        {
            qteLados = lados;
        }

        public int LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public void Rolar()
        {
            //Random rnd = new Random();
            //ladoSorteado = rnd.Next(1, qteLados+1);
            LadoSorteado = Random.Shared.Next(1,qteLados+1);
            
        }
        
    }
}
