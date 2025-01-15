using Microsoft.Extensions.DependencyInjection;
using The_Greeting_Kata;

var serviceProvider = new ServiceCollection()
                        .AddSingleton<SimpleGreeting>()
                        .AddSingleton<NullNameHandler>()
                        .AddSingleton<ToUpperHandler>()
                        .BuildServiceProvider();

var simpleGreeting = serviceProvider.GetService<SimpleGreeting>();
var nullNameHandler = serviceProvider.GetService<NullNameHandler>();
var upperHandler = serviceProvider.GetService<ToUpperHandler>();

nullNameHandler.SetNextHandler(upperHandler);
upperHandler.SetNextHandler(simpleGreeting);

Console.WriteLine(simpleGreeting.Greet("Bob"));
Console.WriteLine(nullNameHandler.Greet(null)); 
Console.WriteLine(simpleGreeting.Greet("BOB")); 
