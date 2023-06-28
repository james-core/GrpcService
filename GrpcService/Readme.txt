一.NET Core 的 gRPC 功能如下：

Grpc.AspNetCore 一个用于在ASP.NET Core承载gRPC服务的框架，将 gRPC和ASP.NET Core
功能集成在一起，如：日志、依赖注入、身份认证和授权。
Grpc.Net.Client 基于HttpClient （HttpClient现已支持HTTP/2）的 gRPC客户端
Grpc.Net.ClientFactory
与gRPC客户端集成的HttpClientFactory，允许对gRPC客户端进行集中配置，并使用DI注入到应用程序中


二.使用 ASP.NET Core 创建 gRPC 服务

配置文件 appsettings.json ，多了Kestrel 启用 HTTP/2 的配置，因为 gRPC 是基于 HTTP/2 来通信的

PB协议文件 greet.proto 用于自动生成服务、客户端和消息（表示传递的数据）的C# Class

三.创建 gRPC 客户端