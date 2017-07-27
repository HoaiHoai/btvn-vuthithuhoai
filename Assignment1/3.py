T_celsius = float(input("Enter the temperature in Celsius? "))	#read temperature in C
T_fahrenheit = 9.0/5.0 * T_celsius + 32							#calculate F by C
print(T_celsius, " (C) = ", '%.2f' % T_fahrenheit, " (F)")		#print output