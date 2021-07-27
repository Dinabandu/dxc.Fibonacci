using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace dxc.FibonacciAPI.Infrastructure.Communicator
{
    public static class SeriallizerConfig
    {
        public static JsonSerializerSettings CamelCaseSerializer()  
        {
         return new JsonSerializerSettings(){Formatting=Formatting.Indented,ContractResolver=new CamelCasePropertyNamesContractResolver()} ;
        }
    }
}

