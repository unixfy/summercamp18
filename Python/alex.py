# Hello World :)
print("Hello World!")

# True? False?
x = True
y = 3.14

#if x:
#    print("X was TRUE!")
#else:
#    print("lol nope")
    
#if (y <= 2.7182818284590452353602874713527):
#    print("y is less than Euclid's number :(")
#else:
#    print("y is greater than Euclid's number :)")
    
# RANGES!
#for i in range(100):
#    print(i)
#    
#numbers = range(100)
#for i in numbers:
#    print(i)
    
#for i in len(numbers):
#    print(numbers[i])

# While Loop
#done = False
#i = 0
#while not done:
#    print("I am not done...")
#    
#    # Adds 1 to i
#    i += 1
#    if i > 10:
#        done = True
#        print("i'm done :)")

# Hip Hip ARRAY
#my_array = ["This", "is", "fun", "really"]
#my_array.append("BUTITSBETTERPLAYINGGAMES")
#
#print(my_array)
#print (my_array[0]) # Print the first element
#
## For loop
#for thing in my_array:
#    print(thing)

# Functions
def neat_function(loop):
    for i in range(0,loop):
        print("%d is the best number!" % i)
# Run the function 1000 times
#neat_function(1000)
# Main Function (the function that runs first)
if __name__ == "__main__":
    print("this is the main function")
    neat_function(1000)
