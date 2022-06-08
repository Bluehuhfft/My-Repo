import random, os

choices = ['R', 'P', 'S']
cc = random.choice(choices)
os.system('cls')
user = input("Choose: [R/P/S]: ")

if user not in choices:
    print("Err: Choice not matched\n")
    quit(1)

print(f"CC: {cc}")

if user == cc:
    print("Draw\n")
    quit(0)

elif (
    user == 'R' and cc == 'S' or user == 'S' and cc == 'P' or user == 'P' and cc == 'R'
):
    win = "USER"

else:
    win = "CC"


print(f'{win} won the game!\n')