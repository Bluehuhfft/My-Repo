import random 
import os

def Loop():
    choices = ['paper', 'rock', 'scissors'] # Only three main choices, if user input does not match them, program will be terminated

    user = input("Choices: rock/paper/scissors | Choose one: ")

    if user not in choices: # Please configure this based on your OS
        os.system('clear')
        os.system('cls') 
        print('\nError: Input and Programmed choices do not match, program terminated')

    aiChoice = random.choice(choices)

    print(f'AI: {aiChoice}\nUser: {user}') # Printing user and AI choices, for information to the user

    if user == aiChoice:
        print('\nResult: Draw') # Result: Draw

    elif(user == choices[1] and aiChoice == choices[0] or user == choices[0] and aiChoice == choices[2] or user == choices[2] and aiChoice[1] ):
        print('\nResult: AI won the game') # Result: AI won

    else:
        print('\nResult: User won the game') # Result: User won

    late = input('Another Game? [Y/N]:')

    if late == 'y' or 'Y': # Please configure this based on your OS
        os.system('clear')
        os.system('cls')
        Loop()

    else: # Please configure this based on your OS
        os.system('clear')
        os.system('cls') 
        quit(0)


Loop()

    
