# A simple rock, paper and scissors game

import random
import os

def Main():
    print("------------------------ RPS ------------------------\n")
    print("Choices: [rock | paper | scissors]") 
    user = input("Choose one of the above: ")

    choices = ['rock', 'paper', 'scissors']
    ai = random.choice(choices) # Generation of AI choice

    # Dumping invalid input
    if user not in choices:
        os.system('clear')  # Use 'cls' instead of 'clear' if you are using windows
        print("Error: User provided input does not match programmed inputs. Please check the capitalization or spelling.")
        quit(1)

    print(f"\nAI: {ai}\nUser: {user}\n")

    

    # Deciding who won:
    if user == ai:
        print("This game is a DRAW")
        quit(0)

    elif (
        user == 'paper' and ai == 'scissors' or
        user == 'scissors' and ai == 'rock' or 
        user == 'rock' and ai == 'paper'
    ): result = 'AI'

    else:
        result = 'USER'

    print(f"The {result} WON this game")


Main() # :D