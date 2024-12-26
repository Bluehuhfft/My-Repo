// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{

    switch (i) {
        case 1:
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
        break;


        case 2:
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
        break;

        case 3:
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
        break;

        case 4:
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;

        default:
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do {
Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();

if (readResult != null)
    menuSelection = readResult;
else
    break;
Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press <enter> to proceed."); Console.Read();

switch (menuSelection) {
    case "1": //List Current pet info.
        for (int i = 0; i < maxPets; i++) {
            Console.WriteLine("");
            if (ourAnimals[i, 0] != "ID #: ") {
                for (int j = 0; j < 6; j++) {
                Console.WriteLine(ourAnimals[i, j]);
                }

            }
        }
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
    case "2": // Add a new animal to array.
        string anotherPet = "y";
        int petCount = 0;
        for (int k = 0; k < maxPets; k ++) {
            if (ourAnimals[k, 0] != "ID #: ") {
                petCount += 1;
            }
        }

        if (petCount < maxPets) {
            Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        }

        while (anotherPet == "y" && petCount < maxPets) {
            bool validEntry = false;
            do {
                Console.WriteLine("\nEnter 'dog' or 'cat' to begin new entry: ");
                readResult = Console.ReadLine();

                if (readResult != null) {
                    if (readResult.ToLower().Trim() != "dog" && readResult.ToLower().Trim() != "cat") {
                        validEntry = false;
                    }
                    else {
                        animalSpecies = readResult.ToLower().Trim();
                        validEntry = true;
                        animalID = animalSpecies.Substring(0,1) + (petCount + 1).ToString();
                    }
                }
            } while (validEntry != true);

            do {
                int petAge;
                Console.WriteLine("Enter the pet age or enter <?> if unknown: ");
                readResult = Console.ReadLine();

                if (readResult != null) {
                    if (readResult == "?") {
                        validEntry = true;
                        animalAge = readResult;
                    }
                    else  {
                        validEntry = int.TryParse(readResult, out petAge);
                    }
                }
            } while (validEntry != true);

            do {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken): ");
                readResult = Console.ReadLine();

                if (readResult != null) {
                    animalPhysicalDescription = readResult.ToLower();
                    if (readResult == "") {
                        animalPhysicalDescription = "tbd";
                    }
                }

            } while (animalPhysicalDescription == "");

            do {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level): ");
                readResult = Console.ReadLine();

                if (readResult != null) {
                    animalPersonalityDescription = readResult.ToLower();
                    if (readResult == "") {
                        animalPersonalityDescription = "tbd";
                    }
                }
            } while (animalPersonalityDescription == "");

            do {
                Console.WriteLine("Enter a nickname for the pet: ");
                readResult = Console.ReadLine();

                if (readResult != null) {
                    animalNickname = readResult.ToLower();
                    if (readResult == "") {
                        animalNickname = "tbd";
                    }
                } 
            } while (animalNickname == "");
            
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            petCount += 1;
            if (petCount < maxPets) {
                Console.WriteLine("Do you want to enter information for another pet? [y/n]");

                do {
                    readResult = Console.ReadLine();
                    if (readResult != null) {
                        anotherPet = readResult.ToLower().Trim();
                    }
                } while (anotherPet != "y" && anotherPet != "n");
            }
            
        }

        if (petCount >= maxPets) {
            Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
        }

        break;
    case "3": // Ensure physical descriptions are complete.
        Console.WriteLine("Check back soon!");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
    case "4": // Ensure nicknames and personality descriptions are complete.
        Console.WriteLine("Come back in a month's time!");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
    case "5": // Edit an animal's age.
        Console.WriteLine("Come back in a month's time!");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
    case "6": // Edit an animal's personality description.
        Console.WriteLine("Come back in a month's time!");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
    case "7": // Display all cats with a specified characteristic.
        Console.WriteLine("Come back in a month's time!");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
    case "8": // Display all dogs with a specified charactertistic. 
        Console.WriteLine("Come back in a month's time!");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;

    case "exit":
        break;

    default:
        Console.WriteLine("Invalid");
        Console.WriteLine("Press the Enter key to continue.");
        Console.ReadLine();
        break;
        
}
} while (readResult!= "exit");