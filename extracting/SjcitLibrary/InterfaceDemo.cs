using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjcitLibrary
{
    public interface InterfaceDemo
    {
        void showProducts(int pid, string pname);
        void showorders(int oid, DateTime odt);
    }
    public class Props
    {
        public int prods { get; set; }
        public int orders { get; set; }
    }

    class Does : Props, InterfaceDemo
    {
        public void showorders(int oid, DateTime odt)
        {
            throw new NotImplementedException();
        }

        public void showProducts(int pid, string pname)
        {
            throw new NotImplementedException();
        }
    }

    void Deposit(int acno, decimal amt);
        void Withdraw(int acno, decimal amt);int oi
        void Transfer(int ToAcno, int FromAcno, decimal amt);
        void CheckBalance();
    }
   class Account
    {
        //auto implemneted properties---AIP
        public int Acno { get; set; }
        public decimal Bal { get; set; }


    }


    class SavingAccount : Account, IBankAccount//this class director what he needs sreelela acts
    {
        public void CheckBalance()
        {
            //throw new NotImplementedException();
            Console.WriteLine(base.Bal);
        }

        public void Deposit(int acno, decimal amt)
        {
            //throw new NotImplementedException();
            base.Bal = base.Bal + amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }

        public void Transfer(int ToAcno, int FromAcno, decimal amt)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Facility not available....");
        }

        public void Withdraw(int acno, decimal amt)
        {
            //   throw new NotImplementedException();
            base.Bal = base.Bal - amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }
    }

    class CurrentAccount : Account, IBankAccount // this class director what he needs sreeleela 
    {
        public void CheckBalance()
        {
            //throw new NotImplementedException();
            Console.WriteLine(base.Bal);
        }

        public void Deposit(int acno, decimal amt)
        {
            //throw new NotImplementedException();
            base.Bal = base.Bal + amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }

        public void Transfer(int ToAcno, int FromAcno, decimal amt)
        {
            //        throw new NotImplementedException();
            Account sender = new Account();
            Account receiver = new Account();
            sender.Acno = FromAcno;
            receiver.Acno = ToAcno;
            sender.Bal = sender.Bal - amt;
            receiver.Bal = receiver.Bal + amt;
            Console.WriteLine("After transfer sender has " + sender.Bal);

            Console.WriteLine("After transfer receiver has " + receiver.Bal);



        }

        public void Withdraw(int acno, decimal amt)
        {
            //throw new NotImplementedException();
            base.Bal = base.Bal - amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }
    }


}
