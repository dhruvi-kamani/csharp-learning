using csharpbasics;

var derivedClass = new DerivedClass();
derivedClass.Name = "Dhruvi"; // Base class properties accessible through inheritance
derivedClass.Surname = "Kamani"; // Parent class properties also accessible

System.Console.WriteLine(derivedClass.GetFullName()); // interface methods callable

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


