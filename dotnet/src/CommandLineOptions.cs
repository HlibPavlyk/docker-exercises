using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class CommandLineOptions
    {
        [Option('n', "name", Required = true, HelpText = "Enter your name")]
        public string? Name { get; set; }
    }
}
