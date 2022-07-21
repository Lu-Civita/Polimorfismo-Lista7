using System;
using app.Src;
using app.Src.interfaces;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo Lola = new Girafa("Lola", "Frutas", "Girafa", "Marrom e amarelo");
           
            Zoo Tony = new Panda("Tony", "Bambu e folhagens", "Panda", "Branco e Preto");

            var Laila = new Papagaio("Laila", "Frutas e sementes", "Papagaio", "Verde e Vermelho");

            Lola.Comer();
            Lola.Dormir();
            Lola.Espiar();

            Tony.Comer();
            Tony.Dormir();
            Tony.Brincar();

            Laila.Voar();
            Laila.Falar();

        }
    }
}
