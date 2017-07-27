import turtle
wn = turtle.Screen()
bo = turtle.Turtle()
numberofCircle = 6

bo.color("green")

for i in range(numberofCircle):
	bo.circle(100)
	bo.left(360/numberofCircle)

turtle.mainloop()
