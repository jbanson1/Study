sandwich_orders = []
x = None

for z in range(3):
    print("we have ran out of pastrami")

while x != "no":
    x = input("What sandwiches do you like ")
    sandwich_orders.append(x)
    x = input("would you like to add to your order yes/no ")

    if sandwich_orders.__contains__('pastrami'):
        sandwich_orders.remove("pastrami")

print("I've made your sandwiches")
for deli in sandwich_orders:
    print (deli)