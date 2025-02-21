using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CallingAllClass
    {
        //Handling File Not Found Exception
        public void CallingFileNotFound()
        {
            FileNotFound.Found();
        }

        //Handling Division and Input Errors
        public void CallingHandlingDivision()
        {
            HandlingDivision.Division();
        }

        //Creating and Handling a Custom Exception
        public void CallingCustomException()
        {
            CustomExcepiton.Method();
        }

        //Handling Multiple Exception
        public void CallingMultipleException()
        {
            MultipleException.HandlingMultipleException();
        }

        // Using using Statement for File Handling
        public void CallingUsingStatement()
        {
            UsingStatement.FileHandling();
        }

        //Handling Invalid Input in Interest Calculation
        public void CallingInvalidInput()
        {
            InvalidInput.Invalid();
        }

        //. Demonstrating finally Block Execution
        public void CallingFinallyBlock()
        {
            FinallyBlock.ExecuteFinally();
        }

        //Propagating Exceptions Across Methods
        public void CallingPropagating()
        {
            PropagatingExceptions.Execute();
        }

        //Using Nested try-catch Blocks
        public void CallingNestedTry()
        {
            NestedTryCatch.eEsted();
        }

        //Implementing a Bank Transaction System
        public void CallingBankTransaction()
        {
            Bank.BankTransaction();
        }
    }
}
