import turtle
wn = turtle.Screen()
bo = turtle.Turtle()

bo.color("green", "yellow")
bo.begin_fill()
for i in range(4):
	bo.forward(200)
	bo.left(90)
bo.end_fill()

turtle.mainloop()