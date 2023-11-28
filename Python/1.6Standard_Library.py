#phyton has many many libraries that we can use
#this lesson is to give an example how to import libraries
#in our project
import random

for number in range(11):
    variable=random.randint(1,100)
    print(variable)

#we can also specify what to import into our project 
#specifically from a module for example 
from math import sqrt
#we are asking the program to import a specifyed function
#from the module math
print(sqrt(49))