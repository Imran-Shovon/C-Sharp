# C-Sharp

 Data Types:
1. Value Data Types
2. Reference Data Types
3. Pointer Data Type
4. Nullable Types

   => Value Data Types: Value Data Types will directly store the variable value in memory and accept both signed and unsigned literals.
   => Reference Data Types: Reference Data Types will contain a memory address of variable value because the reference types won’t store the variable value directly in memory. When you create a reference type variable, such as an object or a string, you are actually storing a reference (or pointer) to the location in memory where the data is held. The actual data for reference types is stored on the heap. The heap is a large pool of memory used for dynamic memory allocation. The built-in reference types are string and object.
   => Pointer Data Type: A pointer in C# holds the memory address of a value. Pointer operations are only allowed in an unsafe context, which must be explicitly declared.
   => Nullable Types: Allow value types to also hold null.

Variable: A variable is a name given to a memory location and all the operations done on the variable effects that memory location. In C#, all the variables must be declared before they can be used. It is the basic unit of storage in a program.

Types of Variables: 
1. Local variables
2. Instance variables or Non – Static Variables
3. Static Variables or Class Variables
4. Constant Variables
5. Readonly Variables
   =>Local variables: A variable defined within a block or method or constructor is called a local variable.
   => Instance Variables: Instance variables are non-static variables and are declared in a class but outside any method, constructor or block.
   => Static variables are also known as Class variables. If a variable is explicitly declared with the static modifier or if a variable is declared under any static block then these variables are known as static variables.
   => Constant Variables: A variable whose value cannot be changed after initialization and also must be initialized at the time of declaration.
   => ReadOnly Variable: If a variable is declared by using the readonly keyword then it will be read-only variables and these variables can’t be modified like constants but after initialization.

Implicitly Typed Local Variables: Implicitly typed variables are those variables that are declared without specifying the .NET type explicitly. In an implicitly typed variable, the type of the variable is automatically deduced at compile time by the compiler from the value used to initialize the variable. It is designed to handle some special-case situations like LINQ(Language-Integrated Query).

Dynamic Type: Dynamic Type is used to avoid the compile-time type checking. The compiler does not check the type of the dynamic type variable at compile time, instead of this, the compiler gets the type at the run time. the dynamic type behaves like object types.
   
