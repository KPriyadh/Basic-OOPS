using System;
using System.Collections.Generic;
namespace Dependency;
class Program{
    public static void Main(string[] args)
    {
        CCAccount ccAccount = new CCAccount();
        ccAccount.AccountNumber = 123;
        ccAccount.Name = "priya";
        ccAccount.Balance=100000000000;
        SBAccount sbAccount = new SBAccount();
        sbAccount.AccountNumber = 123;
        sbAccount.Name = "priya";
        sbAccount.Balance=100000000000;
        List<CCAccount> ccList = new List<CCAccount>();
        ccList.Add(ccAccount);
        
        List<SBAccount> sbList = new List<SBAccount>();
        sbList.Add(sbAccount);

        List<IAccount> accountList = new List<IAccount>();
        accountList.Add(ccAccount);
        accountList.Add(sbAccount);


        

        
    }
}