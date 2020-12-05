using System;
using System.Collections.Generic;
using System.Text;

namespace Converters
{
      public enum TransactionType{
            WithDraw,
            Deposit
        }

    public interface IProcessing{
    
        decimal CurrentBalance { get; set; }
        TransactionType Type { get; set; }
        bool UserInputInputIsValid(string amount);
        decimal UserInputAmount(decimal currentBalance, IProcessing iConverter);
        
    }
}
