
using C_Sharp_Basic.Variables;
using C_Sharp_Basic.DataType;
using System.ComponentModel.DataAnnotations;

//Problem solve
//Variable myobj = new();
//myobj.DisplayAge();
//myobj.SetAge(age: 10);
//myobj.DisplayAge();


//Data types
//DataTypes dataTypesobj = new DataTypes();
//dataTypesobj.GetDataTypesOutputs();

//TypesOfVariables
TypesOfVariables typesOfVariables = new TypesOfVariables();
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
var binaryLiteral1 = 0b1001;
Console.WriteLine("Value of Num1 is: " + binaryLiteral1);
var binaryLiteral2 = 0b_010_000_000_000_000_000_000_000_000;
Console.WriteLine("Value of Num1 is: " + binaryLiteral2);






