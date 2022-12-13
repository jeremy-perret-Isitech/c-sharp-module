using System;
using Grid;

namespace GameOfTheLife
{
    internal class Programm
    {

        static void Main(string[] args)
        {
            displayMenu();
            int rows = 20;
            int columns = 40;
            Cellule[,] grid = createGrid(rows, columns);

            displayGrid(grid, rows, columns);
        }

        static Cellule[,] createGrid(int rows, int columns)
        {
            Cellule[,] grid = new Cellule[rows, columns];

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    grid[row, column] = new Cellule();
                }
            }
            
            return grid; // Need to be initialised with contructor like "new Cellule()"
        }

        static void displayGrid(Cellule[,] grid, int rows, int columns)
        {
            for(int row = 0; row < rows; row++)
            {
                string line = "";
                for(int column = 0; column < columns; column++)
                {
                    line += formatCellule(grid[row, column].getState());
                }
                Console.WriteLine(line);
            }
        }

        static string formatCellule(string celluleState)
        {
            return celluleState == "alive" ? "⬛" : "⬜";
        }

        static void displayMenu()
        {
            Console.WriteLine(@"
            Le jeu de la vie en console.
            By Jeremy PERRET RPI_DEV
            ");

            // Keep space at left of the "Menu" line
            Console.WriteLine(@"            ---------- Menu ----------
            1- Start (Classic)
            2- Start (Random) /// ToDo
            3- Change Settings
            4- Exit
            
            Settings : Rows = {0}, Columns = {1}");
            string? choice = "";
            while (choice == "")
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        choice = "";
                        break;
                }

                if(choice == "") { Console.WriteLine("Veuillez choisir une options"); }
            }
        }
    }
}