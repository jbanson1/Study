#Dictionary within dictionaries
Users = {
    'Joseph':{'First_Name':'Joseph',
              'Last_Name':'Banson',
              'Age':29
              },
    'Azriel':{'First_Name':'Police',
              'Last_Name':'Officer',
              'Age':40
              },
    'Batman':{'First_Name':'Bruce',
              'Last_Name':'Wayne',
              'Age':35
              },
}

for user,details in Users.items():
    print('\n')
    print(f"Users alias is {user}")
    print(f"But their full name is {details['First_Name']} {details['Last_Name']}")
    print(f"dont forget they are {details['Age']} years old")