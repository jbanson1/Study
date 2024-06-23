siblings = ['Joseph','Araba','Ekow','fifie']

print(f'{siblings[0].title()} is the first born')
print(f'{siblings[-1].title()} is the last born')

#Insert at specific index
siblings.insert(0,'Danni')
print(siblings)

#Delete
del siblings[-1]
print(siblings)

#Pop takes out the last value of the list and deletes it after storing it
x = siblings.pop()
print(f'{x.title()} is often the forgotten child')
print (siblings)

# remove item using name
siblings.remove('Joseph')
print(siblings)


#Add to list
siblings.append('Baki')
print(siblings)

