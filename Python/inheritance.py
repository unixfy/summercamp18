import random
from copy import deepcopy

class Person(object):
    def __init__(self, name, age):
        self.name = name
        self.age = age
        
    def Print(self):
        print("Name: %s, Age: %d" % (self.name, self.age))
        
class Student(Person): 
    def __init__(self, name, age, id, classes):
        Person.__init__(self, name, age) #Inherit From Person
        self.id = id
        self.classes = classes
    def Print(self):
        print("Name: %s, Age: %d, Student ID: %d" % (self.name, self.age, self.id))
    def PrintClasses(self):
        for c in self.classes:
            print(c)
        
    
if __name__ == "__main__":
#    people = [\
#    Person("Bob", 1),\
#    Person("Joe", 2),\
#    Person("John", 3),\
#    Person("Eric", 4129412741421047124726412649),\
#    Student("Ada", 64, 59, ["Math", "History"])
#    ]        
    all_classes = ["Math", "History", "Deutsch", "Esports", "Playing Games In Class"]
    for i in range (10):
        student_name = "Student %d" %(random.randint(0,1000))
        student_age = random.randint(500,10000)
        student_id = random.randint(100000,200000000)
                                    
        student_classes = deepcopy(all_classes)
        random.shuffle(student_classes)
        student_classes = student_classes[:3]
        
        student = Student(student_name, student_age, student_id, student_classes)
        students = []
        students.append(student)
    for student in students:
        student.Print()
        student.PrintClasses()
        print("-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-")
            # Loop over each person and print their...stuff
#for person in people:
#    person.Print()
    
#print("Classes:")
#people[4].PrintClasses()