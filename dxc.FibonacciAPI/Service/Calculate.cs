using System;
using System.Text;
using System.Threading.Tasks;
using dxc.FibonacciAPI.Models;

namespace dxc.FibonacciAPI.Service
{
    /// <summary>
    /// CalculateValue
    /// </summary>
    public class CalculateValue : ICalculate
    {
        private const int defaultValue = 8; // As per the default value given in the document   
        public async Task<CalculationResult> CreateFibonacci(int? enterdValue)
        {
            try
            {
                if (enterdValue <= 0)
                throw new Exception("Please enter a value greater than 0");
            else if (enterdValue == 1)
                return new CalculationResult() { Result = "0" };
                
            int first = 0, second = 1, sum, Limit = enterdValue.Value;
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}, {1}", first, second);
            while (Limit > 2)
            {
                sum = first + second;
                result.AppendFormat(", {0}", sum);
                first = second;
                second = sum;
                Limit--;
            }
            return new CalculationResult() { Result=result.ToString()};
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}