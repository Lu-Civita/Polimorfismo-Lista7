using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Src
{
    internal class Girafa : Zoo
    {
        public Girafa(string nome, string comidaFavorita, string especie, string cor) : base(nome, comidaFavorita, especie, cor)
        {
        }

        public override void Dormir()
        {
            Console.WriteLine($"{Nome} durmo demais...");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} gosto de comer!");
        }

        public override void Espiar()
        {
            Console.WriteLine($"{Nome} fico espiando.\n");
        }
    }
}
