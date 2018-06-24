using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    //Game configuration data
    string[] level1Passwords = { "books", "aisle", "self", "password", "font", "borrow" };
    string[] level2Passwords = { "prisoner", "handcuffs", "holster", "uniform", "arrest" };
    string[] level3Passwords = { "books", "aisle", "self", "password", "font", "borrow" };

    //Game State
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

	// Use this for initialization
	void Start () {
        ShowMainMenu("Leslie");
	}

   

    void ShowMainMenu (string UserName){
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello " + UserName);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu("Welcome Back!");
        }
        else if (currentScreen == Screen.MainMenu) 
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password){
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = level1Passwords[2];
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = level2Passwords[2];
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = level3Passwords[2];
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level Mr. Bond!");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have choosen level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Congratulations!");
        }
        else
        {
            Terminal.WriteLine("You have entered the wrong password.");
            Terminal.WriteLine("Please enter your password: ");
        }
    }
}
