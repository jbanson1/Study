
z = []

def format_items(x,y):
    return (f"{x}, {y}")

for i in range(3):
    x = input("Insert a country ")
    y = input("insert the countries capital ")
    z.append(format_items(x,y))

for a in z:
    print(a)