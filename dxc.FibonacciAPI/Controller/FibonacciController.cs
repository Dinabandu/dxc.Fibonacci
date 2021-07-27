using System.Web.Http;
using System.Threading.Tasks;
using duxc.FibonacciAPI.Infrastructure;
using dxc.FibonacciAPI.Service;

namespace dxc.FibonacciAPI.Controller
{
    public class FibonacciController : APIControllerBase
    {
        private ICalculate iCalculate;
        public FibonacciController()
        {
            iCalculate = new CalculateValue();
        }
        
        public const string GetCalc = "api/Fibonacci/GetCalc/{id:int=8}";

        
        [HttpGet]
        [Route(GetCalc)]
        public async Task<IHttpActionResult> GetFibonacci(int? id)
        {
            try
            {
                return ResponseJson(await iCalculate.CreateFibonacci(id));
            }
            catch (System.Exception ex)
            {
                return ResponseErrorJson(new dxc.FibonacciAPI.Models.CalculationResult(), ex.ToString());
            }
        }

        
    }
}
