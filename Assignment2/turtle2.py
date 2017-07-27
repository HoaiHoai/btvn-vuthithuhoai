from turtle import*
import time
shape("turtle")
speed(-1)

color("red")
left(120)
for i in range(4):
    for j in range(0,4):
        forward(100)
        #time.sleep(1)
        if j%2==0:
            right(60)
        else:
            right(120)
    right(90)           

