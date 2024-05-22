x = int(input("What is x"))
y = int(input("What is y"))

if x < y:
    print ("x is less than y")

elif x > y:
    print ("y is less the x")

else :
    print ("They are the same")

# Using If statements and loops
cake = ['eggs','sugar','milk','flour','Bowl']
pancake = ['eggs','sugar','milk','water']

pancake.reverse()

for item in cake:
    for item2 in pancake:
        if item == item2:
            print("A pancake is a cake")

#
x = [1,2,3,4,5]
for item in x:
    if item == 2:
        print("light work")
    else:
        print("I guess not soo light")