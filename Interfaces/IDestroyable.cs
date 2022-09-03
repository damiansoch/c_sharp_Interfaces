using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IDestroyable
    {
        //destruction sound
        string DestructionSound { get; set; }

        //method to destroy an object
        void Destroy();
    }
}
