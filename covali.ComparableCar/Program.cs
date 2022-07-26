using covali.ComparableCar;

Console.WriteLine("***** Fun with Object Sorting*****\n");
Console.WriteLine("Ilixa pokazhi YXO");
Car[] myAuto = new Car[5];
myAuto[0] = new Car("Rusty",55,1);
myAuto[1] = new Car("Mary", 49, 234);
myAuto[2] = new Car("Viper", 95, 34);
myAuto[3] = new Car("Rusty", 40, 4);
myAuto[4] = new Car("Chucky", 44, 5);
Array.Sort(myAuto);
foreach (Car c in myAuto)
{
    Console.WriteLine($"{c.CurrentSpeed}, {c.PetName}");
}
Console.ReadLine();


