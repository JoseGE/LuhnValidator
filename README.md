# LuhnValidator

This project allow you to validate real IDs.

The LuhnValidator is based in the Luhn algorithm to validate the number of an Identification Card. To use the methods of the LuhnValidator class you must:

1. Install the "Luhn Validator" in the Nuget Package
2. Add it to the Dependencies of your project
3. In the Project you must use the "using LuhnValidator;" statement

## Installation

1. Open NuGet Package Manager.
2. Search for LuhnValidation
3. Install

> ``Install-Package LuhnValidator -Version 1.0.0``

## Creating an instance of the class

The class name is IdCardValidator, so for creating an instance of the class you must type:

`IdCardValidator luhn = new IdCardValidator();`

Validating a ID number
After creating the object the way to validate the id number is the following

`luhn.ValidateIdCard("##########")`

With the number to verify as the parameter of the method as a string.The method returns true if the idcard is valid and false if is not.

> For more details visit our [blog](https://medium.com/@arielcruz07/nuget-para-el-algororitmo-de-luhn-2b22e9369be0).