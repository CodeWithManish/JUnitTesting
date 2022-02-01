using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    public class VendingMachine
    {
        public void Calculate()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] store = new int[notes.Length];
            int change = 2006;
            for(int i = 0; i < notes.Length; i++)
            {
                if (change/notes[i]>0) //2,1
                {
                    store[i] = change / notes[i];//store[0]=2
                    change -= notes[i]*store[i];//2006-(1000*2)=6,1
                }
            }
            for(int i = 0; i<notes.Length; i++)
            {
                if (store[i] != 0)
                {
                    Console.WriteLine(notes[i] + "_" + store[i]);
                }
            }
        }
    }
}
