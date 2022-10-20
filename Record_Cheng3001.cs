using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary_Cheng3001
{
    [Serializable]
    public class Record_Cheng3001
    {
        public int Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }

        // parameterless constructor sets members to default values
        public Record_Cheng3001() : this(0, string.Empty, string.Empty, 0M) { }

        // overloaded constructor sets members to parameter values
        public Record_Cheng3001(int account, string firstName, string lastName, decimal balance)
        {
            Account = account;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        } //end of Record
    } //end of class Record
}
