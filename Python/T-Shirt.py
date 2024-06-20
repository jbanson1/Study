#An example of using keywords in order to pass values

size=input()
message=input()

def make_shirt(size,message):
    print(f"{size} is the size of the shirt and '{message}' will be printed on it")

if size == "L":
    make_shirt(size="L",message="I Love Python")

elif size =="M":
    make_shirt(size="L",message="I Love Python")

else:
    make_shirt(size,message)