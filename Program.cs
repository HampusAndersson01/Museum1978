using System;

string currentRoom = "entrance";
char keyPressed;
int moves = 0;
bool fire = false;
var random = new Random();

while (true){
    switch (currentRoom){
        case "entrance":
            Console.Clear();
            if(random.Next(0, 9) == 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The room is on fire, evacuate quickly\n");
                Console.ResetColor();
                if(!fire){
                    fire = true;
                    moves = 0;
                }
            }
            Console.WriteLine("WELCOME TO TOBACCO AND SALT MUSEUM!");
            Console.WriteLine("You are now in the entrance, what would you like to do?");
            Console.WriteLine("1. Go to exhibition hall 1");
            Console.WriteLine("2. Go to exhibition hall 2");
            Console.WriteLine("3. Go to café");
            Console.WriteLine("4. Leave museum\n");
            Console.WriteLine("A. Examine Salt Sculpture");
            Console.WriteLine("B. Look at Cigars");
            keyPressed = Console.ReadKey().KeyChar;
            Console.Clear();
            moves++;
            switch (keyPressed){
                case '1':
                    currentRoom = "exhibition hall 1";
                    break;
                case '2':
                    currentRoom = "exhibition hall 2";
                    break;
                case '3':
                    currentRoom = "café";
                    break;
                case '4':
                    if(fire){
                        Console.WriteLine($"You took {moves} move(s) to evacuate.");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                    }
                    Environment.Exit(0);
                    break;
                case 'a' or 'A':
                    Console.WriteLine("Multiple sculptures made of salt");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 'b' or 'B':
                    Console.WriteLine("Old Cigars");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
            break;
        case "exhibition hall 1":
            Console.Clear();
            if(random.Next(0, 9) == 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The room is on fire, evacuate quickly\n");
                Console.ResetColor();
                if(fire){
                    moves = 0;

                }else{
                    fire = true;
                }
            }
            Console.WriteLine("WELCOME TO TOBACCO AND SALT MUSEUM!");
            Console.WriteLine("You are now in exhibition hall 1, what would you like to do?");
            Console.WriteLine("1. Go to Café");
            Console.WriteLine("2. Go to Entrance\n");
            Console.WriteLine("A. Look at Saltwater evaporate");
            keyPressed = Console.ReadKey().KeyChar;
            Console.Clear();
            moves++;
            switch (keyPressed){
                case '1':
                    currentRoom = "café";
                    break;
                case '2':
                    currentRoom = "entrance";
                    break;
                case 'a' or 'A':
                    Console.WriteLine("Saltwater slowly evaporating");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            break;
        case "exhibition hall 2":
            Console.Clear();
            if(random.Next(0, 9) == 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The room is on fire, evacuate quickly\n");
                Console.ResetColor();
                if(fire){
                    moves = 0;

                }else{
                    fire = true;
                }
            }
            Console.WriteLine("WELCOME TO TOBACCO AND SALT MUSEUM!");
            Console.WriteLine("You are now in exhibition hall 2, what would you like to do?");
            Console.WriteLine("1. Go to entrance\n");
            Console.WriteLine("A. Examine Pipes");
            Console.WriteLine("B. Look at Pictures of Himalaya");
            keyPressed = Console.ReadKey().KeyChar;
            Console.Clear();
            moves++;
            switch (keyPressed){
                case '1':
                    currentRoom = "entrance";
                    break;
                case 'a' or 'A':
                    Console.WriteLine("Old pipes");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 'b' or 'B':
                    Console.WriteLine("Old pictures of Himalaya");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
            break;
        case "café":
            Console.Clear();
            if(random.Next(0, 9) == 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The room is on fire, evacuate quickly\n");
                Console.ResetColor();
                if(fire){
                    moves = 0;

                }else{
                    fire = true;
                }
            }
            Console.WriteLine("WELCOME TO TOBACCO AND SALT MUSEUM!");
            Console.WriteLine("You are now in the café, what would you like to do?");
            Console.WriteLine("1. Go to exhibition hall 1");
            Console.WriteLine("2. Go to entrance\n");
            keyPressed = Console.ReadKey().KeyChar;
            Console.Clear();
            moves++;
            switch (keyPressed){
                case '1':
                    currentRoom = "exhibition hall 1";
                    break;
                case '2':
                    currentRoom = "entrance";
                    break;


                default:
                    break;
            }
            break;
        case "gift shop":
            Console.Clear();
            if(random.Next(0, 9) == 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The room is on fire, evacuate quickly\n");
                Console.ResetColor();
                if(fire){
                    moves = 0;

                }else{
                    fire = true;
                }
            }
            Console.WriteLine("WELCOME TO TOBACCO AND SALT MUSEUM!");
            Console.WriteLine("You are now in the gift shop, what would you like to do?");
            Console.WriteLine("1. Go to café\n");
            keyPressed = Console.ReadKey().KeyChar;
            Console.Clear();
            moves++;
            switch (keyPressed){
                case '1':
                    currentRoom = "café";
                    break;

                default:
                    break;
            }
            break;
        default:
            break;
    }
}