using MoonSharp.Interpreter;
using System;
namespace CodeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lua Code Runner By ! EssaPrime#0001";
            Script script = new Script();
            Console.WriteLine(script.DoFile(args[0]));
            Console.ReadKey();
        }
    }
}
