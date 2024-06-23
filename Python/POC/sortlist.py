# Sorted temporarily sorts the items in a list
cars = ["BMW","Porshe","Bugatti","Rolls Royce","Audi"]
print(sorted(cars))

# Sort permanently sorts items in a list
#extend rather than append to add multiple items to the list
cars.extend(('Mercedes','VW','Maclaren'))
cars.sort()
print(cars)

#reverse the order 
cars.reverse()
print(cars)

#Find Length of List
print(len(cars))

#range creates a range between 1 and 5 NOT including 5
x = range(1,5)
print(x)

