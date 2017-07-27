import turtle
import math

wn = turtle.Screen()
bo = turtle.Turtle()

bo.color("green", "yellow")
bo.begin_fill()
bo.forward(200)
bo.left(135)
bo.forward(200*math.sqrt(2))
bo.left(135)
bo.forward(200)
bo.end_fill()

turtle.mainloop()