************Problem: Employee monthly payslip****************
When I input the employee's details: first name, last name, annual salary(positive integer) and super rate(0% - 50% inclusive), payment start date,
the program should generate payslip information with name, pay period,  gross income, income tax, net income and super.
The calculation details will be the following:
•       pay period = per calendar month
•       gross income = annual salary / 12 months
•       income tax = based on the tax table provide below
•       net income = gross income - income tax
•       super = gross income x super rate
Notes: All calculation results should be rounded to the whole dollar. If >= 50 cents round up to the next dollar increment, otherwise round down.

************Solution************
MonthlyPayslip. Application is written in Visual Studio 2017( Community version) .It contains three projects:-
1) MonthlyPayslip.Application  ( Console Application to read input text file and generate output text file.)
2) MonthlyPayslip.calculator  (Class library having income tax calculation logic and payslip generator engine, Helpers, Entities)
3) MonthlyPayslip.Tests (Test for calculator)


************How to run this project************

1) Open "MonthlyPayslip.Application.sln" to load the project (it is main solution file in root folder )
2) Before running the project, place the Input.txt file containing inputs in C:/Users/UserName/Documents
3) Run the console application , it will show the output file path in console window, press enter to close the console window
4) Output.txt file will be generated in same location.




