
# Random Sentence Generator

This console application generates a random sentence using the provided name.

## Tech Stack:

- .NET
- C#
- Bogus (for generating random sentences)
- CommandLineParser (for handling command line arguments)

## How to run it?

Firstly, clone this repo:

```bash
git clone https://github.com/HlibPavlyk/docker-exercises.git
```

### Move to the Desired Directory

#### Windows:

```bash
cd docker-exercises\dotnet\src
```

#### Linux:

```bash
cd docker-exercises/dotnet/src
```

### Installing .NET SDK

#### Windows:

1. Download and install the .NET SDK from [here](https://dotnet.microsoft.com/download).
2. Open a command prompt (CMD).

#### Linux:

1. Follow the instructions to install the .NET SDK for your specific Linux distribution from [here](https://docs.microsoft.com/en-us/dotnet/core/install/linux).
2. Open a terminal.

### Building the Project

Once the .NET SDK is installed, build the project:

```bash
dotnet build
```

### Running the Application

To run the application and generate a random sentence using the provided name, use the following commands:

```bash
dotnet run -- -name <name>
```

### Exploring the Help Section

To display the help section and see the available options:

```bash
dotnet run -- -help
```

```
dotnet 1.0.0+cc834005fefb49b05051833bf6f30e1cd7bd4f84
Copyright (C) 2024 dotnet

  -n, --name    Required. Enter your name

  --help        Display this help screen.

  --version     Display version information.

```

## Example

Let's generate a random sentence using the name "Olha":

```bash
dotnet run -- -n Olha
```

### Result:

```
Hi, Olha. I'm Tad Dicki. You can't copy the bandwidth without hacking the 1080p RSS bandwidth!
```

and try running it again:

```
Hi, Olha. I'm Natasha Kassulke. Try to reboot the AGP monitor, maybe it will reboot the back-end monitor!
```

