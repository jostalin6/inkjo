using System;

namespace INKJO
{
    class Program
    {
        static void Main(string[] args)
        {

            //duplicate char in a array

            char[] val = { 'a', 'b', 'c', 'a', 'b','c','1' };

            int i = 0;
            int j;
            for (i=0;i<val.Length-1;i++)
            { 
                for(j=i+1;j<val.Length;j++)
                {
                    if(val[i]==val[j])
                    {
                        Console.WriteLine(val[i]);
                    }

                }

            }
           
        }
    }
}
