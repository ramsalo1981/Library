﻿using System;

namespace LibraryApplication2
{
    public partial class LibraryApp
    {
        public void Start()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainChoiceMenu();
            CommonClasses.StandardMessages.ExitMessage();
        }
    }
}