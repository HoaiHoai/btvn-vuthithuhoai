height = int(input("What is your height (cm)?: "))
weight = int(input("What is your weight (kg)?: "))
height = height/100
bmi = weight / pow(height,2)
print("Your bmi is "+str(bmi))
print("You are ", end="")
if bmi<16:
    print("severely underweight")
elif bmi>=16 and bmi<18.5:
    print("underweight")
elif bmi>=18.5 and bmi<25:
    print("normal")
elif bmi>=25 and bmi<30:
    print("overweight")
else:
    print("obese")
    
print("----------")

print("Hello", end="") 
print(", my name", end="")
print(" is Hoài Hoài", end="")

print("----------")

st = ''
for i in range(40):
    st+='*'
print(st)
print()
st1 = ''
for i in range(40):
    if (i%2==0):
        st1+="x"
    else:
        st1+="*"
print(st1)
print()
st2 = ''
for i in range(10):
    for j in range(10):
        if (j%2==0):
            st2+='x'
        else:
            st2+='*'
    st2+='\n'
print(st2)
