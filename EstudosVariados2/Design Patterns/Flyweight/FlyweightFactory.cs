using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Carro[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.GetKey()));
            }
        }

        public string getKey(Carro key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Modelo);
            elements.Add(key.Cor);
            elements.Add(key.Marca);

            if (key.Dono != null && key.Numero != null)
            {
                elements.Add(key.Dono);
                elements.Add(key.Numero);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Carro sharedState)
        {
            string key this.getKey(sharedState);

            if (Flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory não encontra flyweight, criando um novo.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else { Console.WriteLine("Reusando um flyweight."); }

            return flyweights.FirstOrDefault(t => t.Item2 == key).Item1;
        }

        public void listFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"Flyweight Factory: Temos {count} flyweights");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
