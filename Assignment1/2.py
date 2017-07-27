import math							#library needed to use method acos

pi = math.acos(-1)					#get pi value 3.1459265359 (arc cosine of -1 = pi)
radius = float(input("Radius? "))	#read input 'radius' from user
area = radius ** 2 * pi 			#calculate area r^2*pi 
print("Area = %.2f" % area) 		#print out with 2 numbers after decimal point 