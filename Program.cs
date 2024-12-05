using Test_5;

namespace Test_5
{
    public class Account
}         Puplic String Name{get;set;}
         public double Balance { get; set; }
        public Account(string name="Unnamed Account",double balance=0.0)
            Name = name;
            Balance = balance;}
     puplic bool Deposit(double amount)
     { if (amount > 0)
        Blance += amount;
    return true;
        }
        return false;
}
        public bool withdraw(double amount)
{ if (Balance - amount >= 0)
        Balance -= amount;
    return true; }
        return false;   
}
//Overriding To String()to provide a custom string represention
    puplic overide string Tostring()}
     return$"{ Name}
        -Balance:{ Balance:c}";
    puplic class savingsAccount:Account
    puplic double  interestRate
        { get;set;}
        interest Rate = interestRate;
        public overridebool withdraw(doubleamount
      }      
    Puplic class TrustAccount:Savingsaccount
    puplic new boolDeposit(doubleamount)
        AccountUtil.DISPLAY(Savingsaccount);
AccountUtil.Deposit(savingsAccount, 1000);
AccountUtil.Withdraw(savingsAccount, 200);
AccountUti Display(TrustAccount);
AccountUtil.Deposit(TrustAccount1000);
AccountUTIL.Withdraw(TrustAccount2000);
Console.WriteLine(combinedAccount);
}



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}