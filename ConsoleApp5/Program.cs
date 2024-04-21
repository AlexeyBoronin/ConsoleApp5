using Grpc.Net.Client;
using GreeterClientApp;

using var channel = GrpcChannel.ForAddress("https://localhost:7141");
var client=new Greeter.GreeterClient(channel);
Console.WriteLine("Введите имя: ");
var name=Console.ReadLine();
var reply=await client.SayHelloAsync(new HelloRequest { Name = name });
Console.WriteLine($"Ответ сервера: {reply.Message}");
Console.ReadKey();
