siblings = ['Joseph','Araba','Ekow','fifie']

print(f'{siblings[0].title()} is the first born')
print(f'{siblings[-1].title()} is the last born')

#Add to list
siblings.append('Baki')
print(siblings)

#Insert at specific index
siblings.insert(0,'Danni')
print(siblings)

#Delete
del siblings[-1]
print(siblings)
