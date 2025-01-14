using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
                        .AddTransient<SimpleGreeting>()
                        .BuildServiceProvider();

var simpleGreeting = serviceProvider.GetRequiredService<SimpleGreeting>();

Console.WriteLine(simpleGreeting.Greet("Mario"));
