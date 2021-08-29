using System;
using System.Collections;

namespace CollectionDemo
{
    class ArrayListCollection
    {
        static void Main(string[] args)
        {
            ArrayList Al = new ArrayList();

            Al.Add(2);
            Al.Add("Jadhav");
            Al.Add(true);
            Al.Add('P');
            ArrayListDemo DAL = new ArrayListDemo();
            DAL.PrintArrList(Al);
            IEnumerator Ien = Al.GetEnumerator();
            while (Ien.MoveNext())
            {
                Console.Write("\t{0}", Ien.Current);
                Console.WriteLine();
            }
        }
    }

    public class ArrayListDemo
    {
        //public void ArrListMethod()
        //{
            
        //    //PrintArrList(Al);
        //}

    
    
        public void PrintArrList(IEnumerable AL)
        {
            System.Collections.IEnumerator Ien = AL.GetEnumerator();
            while (Ien.MoveNext())
            {
                Console.Write("\t{0}", Ien.Current);
                Console.WriteLine();
            }
        }
    }

    

}
