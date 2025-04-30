using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chovek
{
    internal class person
    {

        private string Name;
        private int age;
        private List<BankAccount> bankAccounts;
    }
    
    

    public person (string name, int age)
    {
        this.Name = name;
        this.age = age;
        this.bankAccounts = new List<BankAccount>();
    }
    public person(string name, int age)
    {
        this.Name = name;
        this.age = age;
        this.bankAccounts = new List<BankAccount>();
    }
}