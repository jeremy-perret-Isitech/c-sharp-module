namespace GameOfTheLife
{
    internal class Programm
    {

        static void Main(string[] args)
        {
            displayMenu(10, 20);
        }

        /// Initialise Cellule grid with given rows and colonnes. Each Cellule is created with state dead.
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
            
            return grid;
        }

        /// Display the grid of Cellule, the "if" display the grid with the cursor (for classic mode), the else display the gird without cursor.  
        static int[]? displayGrid(Cellule[,] grid, int rows, int columns, int[]? cursorPosition = null)
        {
            clearDisplay();
            if(cursorPosition != null)
            {
                for(int row = 0; row < rows; row++)
                {
                    string line = "";
                    for(int column = 0; column < columns; column++)
                    {
                        if(cursorPosition[0] == row && cursorPosition[1] == column)
                        { 
                            line += "+";
                        }else
                        {
                            line += formatCellule(grid[row, column].getState());
                        }
                    }
                    Console.WriteLine(line);
                }
                return cursorPosition;
            }else
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
                return null;
            }
        }

        /// Cast the state of a cellule to square of color (alive: black, dead: white).
        static string formatCellule(string celluleState)
        {
            return celluleState == "alive" ? "@" : "`";
        }


        /// Update of the default size of the grid, with a small error handling, in case of error the concerned property keeps its default value.
        static (int, int) ChangeSettings(int defaultRows, int receivedColumns)
        {
            int newRows;
            int newColumns;
            Console.WriteLine("How many rows :");
            try
            {
                newRows = Int32.Parse(Console.ReadLine());
            }
            catch (Exception expection)
            {
                Console.WriteLine("Invalid value. Rows number keep to default");
                newRows = defaultRows;
            }
            
            Console.WriteLine("How many columns :");
            try
            {
                newColumns = Int32.Parse(Console.ReadLine());
            }
            catch (Exception expection)
            {
                Console.WriteLine("Invalid value. Columns number keep to default");
                newColumns = receivedColumns;
            }
            return (newRows, newColumns);
        }

        static void clearDisplay(){
            Console.Clear();
        }

        public static void startGame(Cellule[,] grid, int rows, int columns){

            Console.WriteLine(@"
            Controls :
            - Wait until generation be done to leave or use 'Ctrl+c' to force close
            Press any key to continue");
            Console.ReadKey();

            bool loop = true;
            while(loop){
                displayGrid(grid, rows, columns);

                var lastGrid = grid;

                grid = nextGeneration(grid, rows, columns);

                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(.5));

                if(gameEnded(grid, rows, columns, lastGrid)){
                    loop = false;
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                }

            }

            Console.WriteLine(@"            The simulation is finished
            Click on any button to back to the menu");
            Console.ReadKey();

            /// pass the ranks and collums as parameters to keep this configuration for the future game
            displayMenu(rows, columns);
        }

        public static Cellule[,] nextGeneration(Cellule[,] grid, int rows, int columns)
        {
            Cellule[,] nextGeneration = createGrid(rows, columns);

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    var aliveNeighbors = 0;
                    int left = -1;
                    int right = 1;
                    int top = -1;
                    int bottom = 1;

                    /// To not test the neighbors of the cells outside the grid on the edges.
                    if(row == 0){
                        left = 0;
                    }
                    if (row == rows - 1){
                        right = 0;
                    }
                    if(column == 0 ){
                        top = 0;
                    }
                    if(column == columns - 1){
                        bottom = 0;
                    }

                    /// get the neighbors of the current cellule who is alive
                    for (int neighborsX = left ; neighborsX <= right; neighborsX++)
                    {
                        for (int neighborsY = top; neighborsY <= bottom; neighborsY++)
                        {
                            aliveNeighbors += grid[row + neighborsX, column + neighborsY].getState() == "alive" ? 1 : 0;
                        }
                    }

                    Cellule currentCellule = grid[row, column];

                    aliveNeighbors -= currentCellule.getState() == "alive" ? 1 : 0;
    
                    if (currentCellule.getState() == "alive" && aliveNeighbors < 2)
                    {
                        nextGeneration[row, column].setState("dead");
                    }
                    else if (currentCellule.getState() == "alive" && aliveNeighbors > 3)
                    {
                        nextGeneration[row, column].setState("dead");
                    }
                    else if (currentCellule.getState() == "dead" && aliveNeighbors == 3)
                    {
                        nextGeneration[row, column].setState("alive");
                    }else{
                        nextGeneration[row, column] = currentCellule;
                    }
                }
            }

            return nextGeneration;
        }

        public static bool gameEnded(Cellule[,] grid, int rows, int columns, Cellule[,] lastGrid) {
            bool isEqual = true;
            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    if(grid[row, column] != lastGrid[row, column]){
                        isEqual = false;
                        break;
                    }
                }
            }
            return isEqual;
        }

        public static Cellule[,] fillGrid(Cellule[,] grid, int rows, int columns, bool randomizes = false){
            clearDisplay();
            if(!randomizes){
                int [] cursorPosition = new int[] { 0, 0 };

                
                Console.WriteLine(@"
                Controls : 
                - Press the directional arrows to move
                - Use 'Space' to change state of the selected cellule
                - Use 'Enter' to start the simulation
                
                Press any key to continue");

                Console.ReadKey();

                bool loop = true;
                while(loop == true){
                    displayGrid(grid, rows, columns, cursorPosition);
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.UpArrow:
                            if(cursorPosition[0] > 0){
                                cursorPosition[0]--;
                            }
                            break;
                        case ConsoleKey.DownArrow: 
                            if(cursorPosition[0] < rows - 1){
                                cursorPosition[0]++;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if(cursorPosition[1] > 0){
                                cursorPosition[1]--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if(cursorPosition[1] < columns - 1){
                            cursorPosition[1]++;
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            grid[cursorPosition[0], cursorPosition[1]].toggleState();
                            break;
                        case ConsoleKey.Enter:
                        loop = false;
                            break;
                    }
                }
            }else{
                /// Randomize grid cellule state
                Random randomizer = new Random();
                int multiplier = 5;

                for(int row = 0; row < rows; row++)
                {
                    for(int m = 0; m < multiplier; m++)
                    {
                        int indexColumn = randomizer.Next(0, columns);
                        
                        grid[row, indexColumn].setState("alive");
                    }
                }
            }
            
            return grid;
        }

        static (int, int)? displayMenu(int receivedRows = 10, int receivedColumns = 20)
        {
            clearDisplay();
            int defaultRows = receivedRows;
            int defaultColumns = receivedColumns;
            
            Cellule[,] grid = createGrid(defaultRows, defaultColumns);
            string? choice = "";

            Console.WriteLine(@"
            Le jeu de la vie en console.
            By Jeremy PERRET RPI_DEV
            ");

            Console.WriteLine(@"
            ---------- Menu ----------
            1- Start (Classic)
            2- Start (Random) /// ToDo
            3- Change Row and Columns
            4- Exit
            
            Settings : Rows = {0}, Columns = {1}", defaultRows, defaultColumns);

            while (choice == "")
            {
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        grid = fillGrid(grid, defaultRows, defaultColumns);
                        startGame(grid, defaultRows, defaultColumns);
                        break;
                    case "2":
                        grid = fillGrid(grid, defaultRows, defaultColumns, true);
                        startGame(grid, defaultRows, defaultColumns);
                        break;
                    case "3":
                        (int newRows, int newColumns) = ChangeSettings(defaultRows, defaultColumns);
                        return displayMenu(newRows, newColumns);
                    case "4":
                        return null;
                    default:
                        choice = "";
                        break;
                };

                if(choice == "") { Console.WriteLine("Please select a valid option"); }
            }            
            return (defaultRows, defaultColumns);
        }
    }
}

