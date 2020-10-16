using System;
using System.Linq;

namespace INKJO
{
    class Program
    {
        static void Main(string[] args)
        {
            //un balanced paranthesis remove

            string val = "inkjo (youtube)is a best(";

            char[] arr = new char[val.Length];

            int i, j;
            for(i=0;i<arr.Length;i++)
            {
                arr[i] = val[i];
            }

            for(i=0;i<arr.Length;i++)
            {
                if(arr[i]=='(')
                {
                    bool flag = true;
                    for(j=i+1;j<arr.Length;j++)
                    {

                        if(arr[j]==')')
                        {
                            
                            if(flag)
                            {
                                Console.WriteLine("Matched");
                                flag = false;
                            }
                            else
                            {
                                arr = arr.Where((val, idx) => idx != j).ToArray();                            }
                        }

                    }

                }
            }


            Console.WriteLine(arr);
        }
    }
}
