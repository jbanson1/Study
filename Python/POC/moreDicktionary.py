#Iterate through a nested dictionaries
person1 = {'Name':'Joe', 'Age':'29','Sex':'M'}
person2 = {'Name':'Baki', 'Age':'30','Sex':'F'}
person3 = {'Name':'Fifie', 'Age':'21','Sex':'M'}
people = [ person1,person2,person3]

for person in people:
    print (person)

#creating an army of Joes
army = []
for soldier in range(30):
    person1 = {'Name':'Joe', 'Age':'29','Sex':'M'}
# Can only append to a list
    army.append(person1)
print(army)

for x in people[:2]:
    print(x)

# A list within a dictionary
companies = {'BMW':['7 series','M5'],
             'Lamborghini':['Aventador','Hurrican'],
             'Rolls Royce':['Ghost','Phantom']
             }

companies['VW']=['golf','sierra 6']

print(companies)

for company,types in companies.items():
    print('\n')
    print(company+' produces :')
    for type in types:
        print(type)
        