using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorismo
{

    public interface IAnimal
    {
        void HacerSonido();
    }

    public class Perro : IAnimal
    {
        public void HacerSonido()
        {
            Console.WriteLine("Guau guau");
        }
    }

    public class Gato : IAnimal
    {
        public void HacerSonido()
        {
            Console.WriteLine("Miau miau");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<IAnimal> animales = new List<IAnimal>();

            animales.Add(new Perro());
            animales.Add(new Gato());

  
            foreach (IAnimal animal in animales)
            {
                animal.HacerSonido();
            }
            Console.ReadKey();
        }
    }
 
}
