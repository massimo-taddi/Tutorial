enter=True
print("im a magician i can calculate evrything ")
firstValue=int(input("pls insert the first number"))
while enter:
    
    answer=int(input(("what do you want me to do with that value?\n 1-add a value \n 2-check if it is even \n 3-check if it is odd \n 4-multiply it \n 5- divide for a specified number \n")))

    if answer==1:
        secondValue=int(input("pls input the value you want me to sum "))
        sum=firstValue+secondValue
        print(str(sum) + " is the sum of the values")

    if answer==2:
        
        if(firstValue%2==0):
            print("the value is even")
        else:
            print("the value is odd")
    if answer==3:
        if(firstValue%2==1):
            print("the value is odd")
        else:
            print("the value is even")
            continue

    if answer==4:
        timesToMultiply=int(input("how many times you want me to multiply it?"))
        result=firstValue*timesToMultiply
        print(str(result) + " is the value multiplied ")

    if answer==5:
        valueToDivideFor=int(input(" pls insert the value you want me to divide the first value for "))
        result=firstValue/valueToDivideFor
        print(str(result) + " is the value divided")
    
    answer1=str(input(" do you want to continue?"))
    if answer1=="yes":
        continue
    else:
        enter=False

   