using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight
    {
        private Carro _sharedState;

        public Flyweight(Carro car)
        {
            this._sharedState = car;
        }

        public void Operation(Carro uniqueState)
        {
            string s = JsonConverter.SerializeObject(this._sharedState);
            string u = JsonConverter.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying Shared{s} and unique {u} state.");

        }
    }
}
