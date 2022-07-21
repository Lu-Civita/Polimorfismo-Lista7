using app.Src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Src
{
    public class Papagaio : Zoo, IAcoesPapagaio
    {
        public Papagaio(string nome, string comidaFavorita, string especie, string cor) : base(nome, comidaFavorita, especie, cor)
        {
        }

        public void Voar()
        {
            Console.WriteLine($"{Nome} amo voar!");
        }
        public void Falar()
        {
            Console.WriteLine($"{Nome} canto o hino do Palmeiras!");
        }
    }
}
