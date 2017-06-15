using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_ExamplesCode
{
    public interface IPerson
    {
        void Train();
    }
    
    public class Peter : IPerson
    {
        public void Train()
        {
            Console.WriteLine("Peter's training");
        }
    }

    public class Sabina : IPerson
    {
        public void Train()
        {
            Console.WriteLine("Sabina's training");
        }
    }
}
