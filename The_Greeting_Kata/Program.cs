using Microsoft.Extensions.DependencyInjection;
using The_Greeting_Kata.Handlers;

var serviceProvider = new ServiceCollection()
    .AddSingleton<NullNameHandler>()
    .AddSingleton<MixedNameHandler>()
    .AddSingleton<ShoutingNameHandler>()
    .AddSingleton<NormalNameHandler>()
    .BuildServiceProvider();

var nullNameHandler = serviceProvider.GetService<NullNameHandler>();
var shoutingNameHandler = serviceProvider.GetService<ShoutingNameHandler>();
var normalNameHandler = serviceProvider.GetService<NormalNameHandler>();
var mixedNameHandler = serviceProvider.GetService<MixedNameHandler>();

nullNameHandler.SetNextHandler(mixedNameHandler);
mixedNameHandler.SetNextHandler(shoutingNameHandler);
shoutingNameHandler.SetNextHandler(normalNameHandler);

var greetingService = new GreetingService(nullNameHandler);

Console.WriteLine(greetingService.Greet(["Bob"]));
Console.WriteLine(greetingService.Greet([null]));
Console.WriteLine(greetingService.Greet(["JERRY"]));
Console.WriteLine(greetingService.Greet(["Jill", "Jane"]));
Console.WriteLine(greetingService.Greet(["Amy", "Brian", "Charlotte"]));
Console.WriteLine(greetingService.Greet(["Amy", "BRIAN", "Charlotte"]));
Console.WriteLine(greetingService.Greet(["Bob", "Charlie, Dianne"]));
Console.WriteLine(greetingService.Greet(["Bob", "\"Charlie, Dianne\""]));
    


