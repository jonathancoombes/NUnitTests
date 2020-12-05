using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

namespace Converters
{
    public class BankingTransaction : IProcessing
    {
        decimal _transactionValue;
        public decimal CurrentBalance { get; set; }
        public TransactionType Type { set; get; }


        public decimal UserInputAmount(decimal currentBalance, IProcessing iConverter)
        {
            if(iConverter.Type == TransactionType.Deposit) 
            {
                CurrentBalance = currentBalance + _transactionValue;
            }
            else 
            {
              CurrentBalance = currentBalance - _transactionValue;
            }
            return CurrentBalance;
        }

        public bool UserInputInputIsValid(string amount)
        {
            decimal value = 0.0m;
          
            try
            {
                decimal.Parse(amount);

              return true ;
    
            }
            catch (Exception e)
            {
                throw new ArgumentNullException(e.Message);
               
            }
             return false;
        }
    }
}
