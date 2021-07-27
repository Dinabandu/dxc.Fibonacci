using System.Web.Http;
using System.Threading.Tasks;
using dxc.FibonacciAPI.Models;
namespace dxc.FibonacciAPI.Service
{
    interface ICalculate
    {
        Task<CalculationResult> CreateFibonacci(int? enterdValue);
    }
}
