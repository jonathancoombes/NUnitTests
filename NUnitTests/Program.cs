using System;
using Converters;
namespace NUnitTests
{

    class Program 
    {

       
      readonly IProcessing _newTrans = new BankingTransaction();

        public static void Main(string[] args){

            //Running Console Application

            //Program newProg = new Program();
            //newProg.RunTransaction();

            // Running Tests

            BankingTransactionTest newTest= new BankingTransactionTest();
        }


           public void RunTransaction()
            {
                _newTrans.Type = TransactionType.Deposit;

            if (_newTrans.UserInputInputIsValid("1000"))
            {
                    _newTrans.UserInputAmount(50000, _newTrans);
                    Console.WriteLine($"The balance after the transaction now is: {_newTrans.CurrentBalance}");
                    Console.ReadLine();
            }

            }

        
            
           

     
        }
    }





