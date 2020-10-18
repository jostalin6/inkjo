using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace INKJO
{
    class Program
    {
        static void Main(string[] args)
        {
           //welcome to inkjo bank
            Console.WriteLine("******INKJO Bank*******");
            Console.WriteLine("1.Balance Enquiry");
            Console.WriteLine("2.Withdrawal");

            string usrInput = Console.ReadLine();
            int input = Convert.ToInt32(usrInput);

            switch (input)
            {
                case 1:
                    decimal bal = BalanceAmt(1,1000,false);
                    Console.WriteLine(bal);
                    break;
                case 2:
                    decimal rbal = BalanceAmt(1,1000,true);
                    Console.WriteLine(rbal);
                    break;
                default:
                    break;

            }

        }
        //data schema define
        //func

        public static decimal BalanceAmt(int id, decimal wamt,bool iswithdrawal)
        {

            //mutiple datas
            decimal amt=0;

            List<users> lst = new List<users>()
            {
                new users{id=1,Amount=10000,Limit=2000,Isdailytran=false},
                new users{id=2,Amount=20000,Limit=2000,Isdailytran=true},
                new users{id=3,Amount=30000,Limit=2000,Isdailytran=false}
            };
            var res = lst.Where(t => t.id == id).ToList();

            if(!iswithdrawal)
            {
                if(res.Count!=0)
                {
                    foreach (users u in res)
                    {
                        amt = u.Amount;
                    }
                }
                else
                {
                    //does not exist
                }
            }
            else
            {
                if(res.Count!=0)
                {
                    
                        foreach (users u in res)
                        {
                        if (wamt < u.Amount-500 && u.Isdailytran == false&& wamt < u.Limit)
                            {
                                amt = u.Amount-wamt;
                            }
                        }
                   
                }
            }
            return amt;
        }
        public class users 
        { 
            public int id { get; set; }
            public decimal Amount { get; set; }
            public int Limit { get; set; }
            public bool Isdailytran { get; set; }

        }


    }
}
