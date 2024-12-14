
using C_Sharp_Basic.Variables;
using C_Sharp_Basic.DataType;
using System.ComponentModel.DataAnnotations;
using C_Sharp_Basic.Operators;
using C_Sharp_Basic.Loops;

//Problem solve
//Variable myobj = new();
//myobj.DisplayAge();
//myobj.SetAge(age: 10);
//myobj.DisplayAge();


//Data types
//DataTypes dataTypesobj = new DataTypes();
//dataTypesobj.GetDataTypesOutputs();

//TypesOfVariables
//TypesOfVariables typesOfVariables = new TypesOfVariables();
//instance variable
//typesOfVariables.age = 20;
//Constant variable cannot be acces through instance variable like below.
//Console.WriteLine(typesOfVariables.PI);

//Implicitly Typed Local Variables
//var implicitlyTypedVariable = 20;
// Not allowed
//var data = { 23, 24, 10 };
// Allowed 
//var data = new int[] { 23, 34, 455, 65 };
//TypesOfVariables.addStr("Shovon ", "Biswas");
//TypesOfVariables.addStr(100, 300);
//Creating Binary literals
//var binaryLiteral1 = 0b1001;
//Console.WriteLine("Value of Num1 is: " + binaryLiteral1);
//var binaryLiteral2 = 0b_010_000_000_000_000_000_000_000_000;
//Console.WriteLine("Value of Num1 is: " + binaryLiteral2);

//Multiply
//Operators operators = new();
//operators.Add(10, 20);
//operators.Subtract(30, 20);
//operators.Multiply(30, 20);
//operators.Divide(30, 20);
//Unary Operators
//Increment ++  Decrement --
//int number = 20, result;
////preDecrement
//result = --number;
//Console.WriteLine(result);
////Post Decrement
//result = number--;
//Console.WriteLine(result);
////Post Increment
//result = number++;
//Console.WriteLine(result);
////Pre Increment
//result = ++number;
//Console.WriteLine(result);

////IfStatement
//IfStatement agecheck = new();
//agecheck.AgeIs18orNot(23);
//agecheck.AgeIs18orNot(32);
//agecheck.AgeIs18orNot(12);
//agecheck.AgeIs18orNot(2);

////Switch Statement
//SwitchStatement switchStatementobj = new SwitchStatement();
//switchStatementobj.FruitCheck("Banana");
//switchStatementobj.CheckNumberOrNot("Shovon");
//switchStatementobj.CheckNumberOrNot(20);


////While loop 
//WhileLoop whileLoop = new WhileLoop();
//whileLoop.WhileLoopCheck();


////For Loop
//string[] fruits = { "Apple", "Banana", "Cherry" };
//ForLoop forLoopObj = new();
//forLoopObj.ForLoopCheck(fruits);


////Do While Loop
//DoWhileLoop doWhileLoopObj = new();
//doWhileLoopObj.DoWhileLoopCheck(1);

////For Each Loop
//ForEachLoop forEachLoopobj = new();
//forEachLoopobj.ForEachLoopCheck();
//forEachLoopobj.IteratingDictionary();


//ThrowStatement
string subject = null;
ThrowStatement throwStatementobj = new();
try
{
    throwStatementobj.displaySubject(subject);
}
catch(Exception exp)
{
    Console.WriteLine(exp.Message);
}


