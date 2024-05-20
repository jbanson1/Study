name = input("What's your position")

match name:
    case "1"|"2"|"3":
        print("On Pole")
    case "4":
        print("Dani Ric")
    case "5":
        print("Oscar P")
    case _:
        print("SMH your slow")