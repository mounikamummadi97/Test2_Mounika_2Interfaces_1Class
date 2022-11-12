// See https://aka.ms/new-console-template for more information
using Test2_Mounika_2Interfaces_1Class;


Calculate objCalculate = new Calculate();

int sum = ((Interface1)objCalculate).AddNumber(10, 20);
int subtract = ((Interface2)objCalculate).SubtractNumber(15, 10);
Console.Write("Value of sum: {0} and\n Value of subtract: {1} ", sum, subtract);
//Console.Read();

