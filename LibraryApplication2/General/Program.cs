using Serilog;
using System;

namespace LibraryApplication2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
           .MinimumLevel.Debug()
           .WriteTo.MongoDB("mongodb://localhost/serilog-db", collectionName: "applog")
           .CreateLogger();

            log.Fatal("Fatal mvc");

            Log.CloseAndFlush();
            LibraryApp libraryApp = new LibraryApp();
            libraryApp.Start();
        }
        
    }
}
