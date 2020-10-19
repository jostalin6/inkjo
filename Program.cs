using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace INKJO
{
    class Program
    {
        static void Main(string[] args)
        {

            //sorting

            int [] num = { 1, 3, 4, 5, 0, 6, 7, 7 };

            int i, j,temp;
            for(i=0;i<num.Length;i++)
            {
                for(j=i+1;j<num.Length;j++)
                {
                    if(num[j]>=num[i])
                    {
                        temp = num[j];
                        num[j] = num[i];
                        num[i] = temp;
                    }

                }

            }

            foreach(int k in num)
            {
                Console.WriteLine(k);
            }


        }
    }
}
