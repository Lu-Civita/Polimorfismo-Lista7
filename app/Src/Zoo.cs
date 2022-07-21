using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Src
{
	public class Zoo
	{
		public string Nome { get; set; }

		public string ComidaFavorita { get; set; }

		public string Especie { get; set; }

        public string Cor { get; set; }

        public Zoo(string nome, string comidaFavorita, string especie, string cor)
        {
            Nome = nome;
            ComidaFavorita = comidaFavorita;
            Especie = especie;
            Cor = cor;
        }

        public virtual void Dormir()
        {
			Console.WriteLine($"{Nome} está dormindo");
        }

		public virtual void Comer()
		{
			Console.WriteLine($"{Nome} está comendo");
		}
        public virtual void Brincar()
        {
            Console.WriteLine($"{Nome} gosto de brincar.");
        }

        public virtual void Espiar()
        {
            Console.WriteLine($"{Nome} fico espiando.");
        }
    }
}
