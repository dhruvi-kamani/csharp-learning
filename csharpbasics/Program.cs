using csharpbasics;
using csharpbasics.classTypes;
using SampleProject;
using System;

var derivedClass = new DerivedClass();
derivedClass.Name = "Dhruvi"; // Base class properties accessible through inheritance
derivedClass.Surname = "Kamani"; // Parent class properties also accessible

Console.WriteLine(derivedClass.GetFullName()); // interface methods callable

var financeWorker = new FinanceWorker();
financeWorker.work();   // call the abstract method
financeWorker.Exercise(); // call the regular method

var personInformation = new PersonInformation();
var age = personInformation.Age; // Able to get
// personInformation.Age = 20; // Will fail because of encapsulation
personInformation.Salary = 50000;
// var Salary = personInformation.Salary; // Will fail because of encapsulation

var bank = new Bank();
bank.getInterestRate(); //output: 10;

var bank1 = new IciciBank();
bank1.getInterestRate(); //output: 5;

var bank2 = new HdfcBank();
bank2.getInterestRate(); //output: 7;

var instance = new PartialClass();
instance.Prop1 = 14;
instance.Prop2 = 15;
// Both properties accesssible

//public class SealedParentClass : SealedClass      // can not inherit from sealed classes
//{

//}

//var instance2 = new StaticClass();  // can not create instance from static classes
StaticClass.Surname = "Kamani";    // static class properties and methods can be directly accessed through class name

var instance3 = new PublicClass();  // public class in other projects are accessible
//var instance4 = new InternalClass();   // internal class are not accessible in other projects


var status = ApplicationStatus.Running;   // instead of using number 2 we use enums to make code readable
System.Console.WriteLine(status);

var user = new User("Dhruvi", "Kamani", Gender.Female);   // record is same as class but all values must be provided on initialization

var list = new List<string>();   // this way we can create new list
var days = new List<string>()
{
    "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
};      // this way we can create new list and initialize at the same time

days.Add("Sunday"); // this way we can add new item to the list

days.Remove("Monday");  // this way we can remove an item from the list

var day = days[0];   // this way we can get a day with particular index which starts with 0

var index = days.IndexOf("Wednesday");    // this way we can get the index of particular day

days.RemoveAt(index);  // this way we can remove a day using index


void logger(string message)
{
    Console.WriteLine(message);
}

var delegateSample = new DelegateSample(logger); // Passing logger function to delegate
delegateSample.LogSomething();
