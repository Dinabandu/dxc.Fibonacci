using System.Web.Http;
using dxc.FibonacciAPI.Infrastructure.Communicator;
using System.Web.Http.Results;

namespace duxc.FibonacciAPI.Infrastructure
{
    public class APIControllerBase : ApiController
    {
        protected JsonResult<BaseResponse<T>> ResponseJson<T>(T payload)
        {
            var response = new BaseResponse<T>()
            {
                Success = true,
                Payload = payload,
                ErrorMessage = null
            };
            return Json(response,SeriallizerConfig.CamelCaseSerializer());
        }

        protected JsonResult<BaseResponse<T>> ResponseErrorJson<T>(T payload, string errorMsg)
        {
            var response = new BaseResponse<T>()
            {
                Success = false,
                Payload = payload,
                ErrorMessage = errorMsg
            };
            return Json(response, SeriallizerConfig.CamelCaseSerializer());
        }
    }
}