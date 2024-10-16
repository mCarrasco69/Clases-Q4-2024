

using System.Drawing;

namespace Clases_Q4_2024
{
   public class Ave
    {

        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Color { get; set; }
        public double Tamano { get; set; }
        public string Habitat { get; set; }

        public FamiliaAve Familia;
        //constructor 
        public Ave()
        {
            Familia = new FamiliaAve();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamano: {Tamano} cm");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Numero de especies:  {Familia.NumeroEspecie}");
            Console.WriteLine($"Caracteristicas: {Familia.Caracteristicas}");
            Console.WriteLine();
        }
    }
}
