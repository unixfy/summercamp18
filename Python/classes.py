class MyClass(object):
    def __init__(self, name, age): # Self is VERY IMPORTANT!111
        self.x = 1 # A variable INSIDE THE CLASS
        self.name = name
        self.age = age
    def Print(self):
        print(self.name, self.age)
        
if __name__ == "__main__":
    people = [\
             MyClass("Bob", 1),\
             MyClass("Joe", 2),\
             MyClass("John", 3),\
             MyClass("Eric", 4129412741421047124726412649)
             ]
    # Loop over each person and print their...stuff
    for person in people:
        person.Print()
#    my_class = MyClass("My Name", 346)
#my_class.Print()
        