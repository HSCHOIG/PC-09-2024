﻿// See https://aka.ms/new-console-template for more information

#region Exploring unary operators
int a = 3;
int b = a++;

Console.WriteLine($"a is {a}, b is {b}");
#endregion

#region Exploring unary operators
int c = 3;
int d = ++c;

//prefix means increment c before assigning it.
Console.WriteLine($"c is {c}, d is {d}");
#endregion

//Ejercicios operadores aritmeticos binary
int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");

double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f = {g / f}");

//Ejercicios operadores de asignacion
int p = 6;
p += 3; //Equivalent to: p = p + 3;
p -= 3; //Equivalent to: p = p - 3;
p *= 3; //Equivalent to: p = p * 3;
p /= 3; //Equivalent to: p = p / 3;

//Operadores que utilizan null
string? authorName = ReadLine();
//Prompt user to enter an author name
// The maxLength variable will be length of authorName if it is
// Not Null, or 30 if authorName is null.
int maxLength = authorName?.Length?? 30;
// The authorName variable will be "unknown" if authorName was null.
authorName ??= "unknown";

//Operadores Logicos
bool p = true;
bool q = false;

Console.WriteLine($"AND | p | q");
Console.WriteLine($"p | {p & p, -5} | {p & q, -5}");
Console.WriteLine($"q | {q & p, -5} | {q & q, -5}");
Console.WriteLine();
Console.WriteLine($"OR | p | q");
Console.WriteLine($"p | {p | p, -5} | {p | q, -5} ");
Console.WriteLine($"q | {q | p, -5} | {q | q, -5} ");
Console.WriteLine();
Console.WriteLine($"XOR | p | q");
Console.WriteLine($"p | {p }");