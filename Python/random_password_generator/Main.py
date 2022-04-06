import random

def Main():
    choices = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]
    char = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
    special = ['_', '$', '#', '*']
    Mainchoice = [random.choice(choices), random.choice(choices), random.choice(choices), random.choice(choices)]
    MainChar = [random.choice(char), random.choice(char), random.choice(char)]
    specialMainChoice = random.choice(special)
    print(f"Here's your password: {Mainchoice[0]}{MainChar[1]}{Mainchoice[2]}{Mainchoice[3]}{MainChar[0]}{MainChar[1]}{Mainchoice[1]}{specialMainChoice}")



Main()