using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Car:Vehicle,IDestroyable
    {
        public string DestructionSound { get; set; }

        //list of type IDestroyable, it can stora any objects that implement this interface
        //and we can only access the properties and methods in this interface
        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color) : base(speed, color)
        {
            //initializint the sound
            DestructionSound = "CarExplosion.mp3";
            //initialize the list what gets destroyed
            DestroyablesNearby = new List<IDestroyable>();
        }

        //initialize Destroy() method
        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            //go through each destroyable object nearby and call its destroy method
            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
