# Creating a dictionary 
# A collection of key value pairs
Aliens = {'colour':'red','height':'2'}
print (Aliens['colour'])
print (Aliens['height'])

#Adding values to dictionaries
Aliens['origin']='deep space'
Aliens['deadly']='No'

print(Aliens)

#Assign/Modify values within dictionaries
Aliens['deadly']='Yes Runn!!!!'
print(Aliens)

# Removing a keyvalue P
del Aliens['height']
print(Aliens)

#Use get to retrieve values and handle exceptions.Get takes 2 arguments.
thatone = Aliens.get('height','No information about height in the db')
print(thatone)

#Iterating through dictionaries
Person = {
    'Name':'Joe',
    'Age':'29',
    'Sex':'M'
}
#The property key and value within the loop can be replaced with other variables
for key,value in Person.items():
    print(key.title().strip() +" " +value)

#sort the values before iterating through them
Workers = {
    'Joseph':'Dev',
    'Baki':'Wrestler',
    'Fifie':'Con Man',
    'Ekow':'Economist'
}

# Use items to provide 2 values
for worker,job in sorted(Workers.items()):
    print(worker + ' and their chosen career is' + job)

# Use key to provide key value only
for worker in sorted(Workers.keys()):
    print(worker + " is a hard worker")

# Use values to provide value only
for worker in sorted(Workers.values()):
    print(worker + " is a hard job")
