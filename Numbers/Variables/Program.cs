object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a sting in an object
Console.WriteLine($"{name} is {height} meters tall");

//int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");