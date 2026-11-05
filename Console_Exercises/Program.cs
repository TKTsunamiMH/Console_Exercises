// Purpose: Use the "Console.WriteLine()" method to train your comprehension of how expressions evaluate and in which order operators have priority.

// Exercise 1
Console.WriteLine("Hello, World!");
Console.WriteLine(2 + 4);
Console.WriteLine("2" + "4");
Console.WriteLine(2 + "4");
Console.WriteLine("2" + 4 + 7);
Console.WriteLine(3 + 5 + "=" + 3 + 5);
Console.WriteLine(6 + 2 + "3");
Console.WriteLine("Two" + "Three");
Console.WriteLine(1 + 2 + "Three");
Console.WriteLine(4 > 2);
Console.WriteLine(34 < 32 + 4);
Console.WriteLine(33 != 33);
Console.WriteLine(34 - 2 == 36);
Console.WriteLine(34 + 2 != 36);
Console.WriteLine(34 + 2 >= 36);
Console.WriteLine(34 - 2 > 36);
Console.WriteLine(4 == 4 ? "One" :  "Two");

// Exercise 2
Console.WriteLine(1 + " " + "=");
Console.WriteLine(3 + 6 * 2);
Console.WriteLine("2" + 3 * 2);
Console.WriteLine(2 + 3 + "4" + 4 / 2);
// This line is commented out because it will throw an error due to invalid operation between string and integer
// Console.WriteLine("2" + 7 - 4);
Console.WriteLine(7 / 3);
Console.WriteLine(2 * ( 4 + 2));
Console.WriteLine(3 + ( 5 + "G"));
Console.WriteLine(1+ 4 / 3);
Console.WriteLine(3 == 3 && 4 != 6);
Console.WriteLine(3==4 || 4 != 4);
Console.WriteLine(4 > 9 ? "Lucene" : 4 + 89);

// Exercise 3
Console.WriteLine("No" + " " + "way");
Console.WriteLine(4 + 6);
Console.WriteLine("3" + "9");
Console.WriteLine(1123 + "23");
Console.WriteLine("43" + 2 + 5);
Console.WriteLine(100 + " " + "+");
Console.WriteLine(56 + 5 * 6);
Console.WriteLine("1" + 1 * 1);
Console.WriteLine(1 + 11 + "1" + 11 / 11);
// This line is commented out because it will throw an error due to invalid operation between string and integer
// Console.WriteLine("34" + 2 - 1);
Console.WriteLine(13 / 2);
Console.WriteLine(4 * ( 5 - 3));
Console.WriteLine(9 + ( 2 + "OH"));
Console.WriteLine(12 + 12 / 4);
Console.WriteLine(9 == 9 && 893 != 891 + 2);
Console.WriteLine(8 == 4 / 2 || 4 != 4 / 2);
Console.WriteLine(2 + 8 + "=" + 2 + 8);
Console.WriteLine(45 - 40 == 50 ? 3 + 6 : 6 + "3");

// Own Exercise
int myFirstExample = 5;
int mySecondExample = 10;
Console.WriteLine(myFirstExample);
Console.WriteLine(myFirstExample + mySecondExample);
myFirstExample = 7;
Console.WriteLine(myFirstExample);