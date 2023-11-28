#a normal problem which can occur often is that we want to concatenate a int variable to a string so for example
phrase="what is equal to 5+5?"
answer=10

#print(phrase+answer) #this line of code qill produice a error because phyton cant read it for 2 different type we need to convert the int to string

#the correct method to sum strings and covert is

print(phrase + str(answer))

#we can actually save values as string too and convert them as int

example_Value="13"

print(example_Value  * 3) #it multiply the string
print(int(example_Value)*3) # it multiply the value

#\n is considered as "new line" it allows you to 
#go down by 1 line inside the string 


#evry line of code that we use for input phyton reads it as a "string" if we want to specify if that has to be read as a int or a str
#we must put the syntax this way 
#int(input("how old are you")) in this simple example we ask in the console "how old are you" then we input the value
#and it gets treated as int since we put int outside the()





