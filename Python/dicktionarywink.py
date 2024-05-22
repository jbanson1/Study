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

