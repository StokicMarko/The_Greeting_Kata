using Microsoft.Extensions.DependencyInjection;
using The_Greeting_Kata;

var serviceProvider = new ServiceCollection()
                        .AddTransient<SimpleGreeting>()
                        .AddTransient<NullNameHandler>()
                        .BuildServiceProvider();

var simpleGreeting = serviceProvider.GetRequiredService<SimpleGreeting>();
var nullNameHandler = serviceProvider.GetRequiredService<NullNameHandler>();

simpleGreeting.SetNextHandler(nullNameHandler);

Console.WriteLine(simpleGreeting.Greet("Bob"));
Console.WriteLine(simpleGreeting.Greet(null)); 
