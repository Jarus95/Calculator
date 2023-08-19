using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    public interface IReporter
    {
         void ShowGratitude();

         void RepotProgress(string message);

         void RepotResult(string result);

         int ReportError(string errorMessage);
    }
}
