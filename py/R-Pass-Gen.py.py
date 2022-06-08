import random

s = ['@', '#', '!', '$', '*', '-', '_']
l = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'h']
n = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0]

print(f"{random.choice(n)}{random.choice(s) + random.choice(l) + random.choice(l) + random.choice(l) + random.choice(l) + random.choice(s)}{random.choice(n)}")

