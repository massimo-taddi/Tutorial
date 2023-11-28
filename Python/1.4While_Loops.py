#while

counter=0
while counter<=10 :
    print("hi" + str(counter))
    counter=counter+1

#break: it interrupts the cycle when it is read

enter=True
counter1=0
while enter==True:   
    if (counter1==10):
        #when counter 1 becomes 10 it reads "break" and goes outside the cycle
        break
    else:
        counter1+=1
        continue

    