using System;
using System.Collections.Generic;


class Driver
{
  public static void Main (string[] args) {
    
    string mainMenu = "1) Add a Player Character. \n2) Remove a Player Character. \n3) Roll Initiative! \n4) Show Initiative Order. \n0) Exit. \nPlease Choose an Option: ";
    
    RandomNumber diceRoller = new RandomNumber();
    List<PlayerCharacter> adventuringParty = new List <PlayerCharacter>();
    
    Console.Write(mainMenu);
    string chosenMenuOption = Console.ReadLine();
    
    do {
      Console.Clear();
      switch (chosenMenuOption) {
        
        case ("1"):
          Console.Write("What is the Character's Name: ");
          string inputName = Console.ReadLine();
          PlayerCharacter newCharacter = new PlayerCharacter(inputName);
          adventuringParty.Add(newCharacter);
          Console.Write(mainMenu);
          chosenMenuOption = Console.ReadLine();
          break;
          
        case ("2"):
          break;
          
        case ("3"):
          for (int i = 0; i < adventuringParty.Count; i++) {
            adventuringParty[i].rollForInitiative(diceRoller);
          }
          Console.WriteLine("Initiative Rolled!");
          Console.Write(mainMenu);
          chosenMenuOption = Console.ReadLine();
          break;
          
        case ("4"):
        Console.WriteLine("Determining Order...");
        adventuringParty.Sort();
          for (int i = 0; i < adventuringParty.Count; i++) {
            Console.WriteLine(string.Format("{0} {1}", adventuringParty[i].PlayerCharacterName, adventuringParty[i].Initiative));
          }
          Console.Write(mainMenu);
          chosenMenuOption = Console.ReadLine();
          break;
          
        case ("0"):
          Console.WriteLine("Exiting...");
          break;
          
        default:
          break;
      }
    } while (chosenMenuOption !=  "0");
      
    }
}








