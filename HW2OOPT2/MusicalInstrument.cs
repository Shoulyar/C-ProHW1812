using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OOPT2
{
    public abstract class MusicalInstrument
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        private DateTime CreationDate { get; set; }

        public MusicalInstrument(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
            CreationDate = DateTime.Now;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Sound of {Name}");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Musical Instrument: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Description of {Name}: {Characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine($"Creation history of {Name}: Created on {CreationDate}");
        }
    }
}
