using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarDemo
{
    //Consider an array/list of sheep where some sheep may be missing from their place. 
    //We need a function that counts the number of sheep present in the array (true means present).
    class Program
    {
        static void Main(string[] args)
        {
            Kata k = new Kata();
            bool[] sheeps = new bool[2];
            sheeps[0] = false;
            sheeps[1] = true;
            k.CountSheeps(sheeps);
            foreach (bool res in sheeps)
            {
                Console.WriteLine(res);
            }
                
          
            Console.ReadLine();
        }
        public  class Kata
        {
            public  int CountSheeps(bool[] sheeps)
            {
                return sheeps.Count(sheep => sheep);
            }
            
        }
        
    }
    
}
