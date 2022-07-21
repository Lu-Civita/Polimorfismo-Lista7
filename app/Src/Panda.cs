using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Src
{
    public class Panda : Zoo
    {
        public Panda(string nome, string comidaFavorita, string especie, string cor) : base(nome, comidaFavorita, especie, cor)
        {

        }

        public override void Dormir()
        {
            Console.WriteLine($"{Nome} adoro dormir!");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} como muito!");
        }

        public override void Brincar()
        {
            Console.WriteLine($"{Nome} gosto de brincar.\n");
        }

    }
}
