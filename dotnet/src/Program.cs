using Bogus;
using CommandLine;
using dotnet;


Console.OutputEncoding = System.Text.Encoding.UTF8;

Parser.Default.ParseArguments<CommandLineOptions>(args)
    .WithParsed(options =>
    {
        var faker = new Faker();

        string responsePhrase = faker.Hacker.Phrase();
        string responseName = faker.Name.FullName();

        Console.WriteLine($"Hi, {options.Name}. I'm {responseName}. {responsePhrase}");

    });
