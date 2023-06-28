using Grpc.Core;
using GrpcService;

namespace GrpcService.Services
{
    /// <summary>
    ///  ������ GreeterService �������༯�ɵ� Greeter.GreeterBase �����ڸ���proto�ļ��Զ����ɵģ����ɵ����� obj\Debug\Protos\net6.0Ŀ¼��
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