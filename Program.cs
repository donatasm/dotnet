using System;
using System.Runtime.InteropServices;

namespace DotNet
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FortyTwo());
        }

        [DllImport("libdotnet.dylib", EntryPoint = "FortyTwo")]
        private static extern int FortyTwo();
    }
}
