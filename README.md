# Pierre's Bakery

#### Epicodus Code Review #7: Test-Driven Development with C#

#### By Shannon Lee

#### _Table of Contents_

1. [Description](#description)
2. [Technologies Used](#technologies)
3. [Setup/Installation Requirements](#setup)
4. [Additional Setup/Installation Note for Windows Users](#windows)
5. [Specifications](#specs)
6. [Known Bugs](#bugs)
7. [License](#license)
8. [Contact Information](#contact)


## Description <a id="description"></a>

This is a console application built using C# for a hypothetical bakery, Pierre's Bakery, that sells bread and pastries. It asks for the user's orders of pastries and bread, and returns the total price. A single loaf of bread costs $5, and there is a buy 2 get 1 free deal. Pastries are 1 for $2 or 3 for $5. This aim of this project is to demonstrate understanding of test-driven development in C#. 

## Technologies Used <a id="technologies"></a>

* C#
* .NET 5
* MSBuild
* MSTest
* git

## Setup/Installation Requirements <a id="setup"></a>

Setup requirements
* Make sure that .NET Software Development Kit 5 has been installed to your local machine. 

Installation
* Clone this repository to your machine `$ git clone https://github.com/shanole/PierresBakeryCR`
* In the terminal, navigate to the project directory `$ cd PierresBakeryCR/PierresBakery`
* Compile code by running command `$ dotnet build`
* Run program with command `$ dotnet run`

Running tests with MSTest
* Navigate to the tests directory `PierresBakeryCR/PierresBakery.Tests`
* Run command `$ dotnet restore` to install MSTest frameworks
* Run command `$ dotnet test` to execute unit tests.


## Specifications <a id="specs"></a>

All unit testing was done with MSTest. To see full specs, 

Please refer to the .cs files in the `PierresBakeryCR/PierresBakery.Tests/ModelTests` direct for a comprehensive breakdown of all specs for this project. All tests were run through MSTest.

__Unit testing for Bread class__
* For Bread constructor
  1. Bread constructor should return instance of Bread object.
  2. Getting the BreadOrders property should return number of orders of bread.
* For CalculatePrice() method
  1. 1 order of bread should equal $5
  2. 2 orders of bread should equal $10
  3. 3 orders of bread should equal $10
  4. 6 orders of bread should equal $20
  5. 7 orders of bread should equal $25

__Unit testing for Pastry class__
* For Bread constructor
  1. Pastry constructor should return instance of Pastry object.
  2. Getting the PastryOrderes property should return number of orders of pastries.
* For CalculatePrice() method
  1. 1 pastry should equal $2
  2. 2 pastries should equal $4
  3. 3 pastries should equal $5
  4. 6 pastries should equal $10
  5. 5 pastries should equal $9

## Known Bugs <a id="bugs"></a>
* None known at this time. If you find one, please don't hesitate to contact me about it!

## License <a id="license"></a>
*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) 2021 Shannon Lee

## Contact Information <a id="contact"></a>
**_Shannon Lee [mailto](mailto:shannonleehj@gmail.com)_**