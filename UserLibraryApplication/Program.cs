using System;

namespace UserLibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserLibraryApp libraryApp = new UserLibraryApp();
            libraryApp.Start();
            CommonClasses.StandardMessages.ExitMessage();
        }
    }
}
