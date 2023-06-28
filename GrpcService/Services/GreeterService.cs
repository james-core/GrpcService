using Grpc.Core;
using GrpcService;

namespace GrpcService.Services
{
    /// <summary>
    ///  服务类 GreeterService ，服务类集成的 Greeter.GreeterBase 来自于根据proto文件自动生成的，生成的类在 obj\Debug\Protos\net6.0目录下
    /// </summary>
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}