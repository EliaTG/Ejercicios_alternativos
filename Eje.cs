using System;

namespace EjerciciosAlternativos
{
class Program{
static void Main(string[] args){

//Ejercicio #1
int num_entero;
Console.WriteLine("Escribe un numero entero: ");
num_entero = int.Parse(Console.ReadLine());
if(num_entero % 2 == 0){
Console.WriteLine("El numero introducido es par: "+num_entero);
}else{
  Console.WriteLine("El numero introducido es impar: "+num_entero);
}
/*
//Ejercicio #2
Console.WriteLine("Escribe un numero entero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe otro numero entero: ");
int num2 = int.Parse(Console.ReadLine());
int result = num1%num2; 
if(result == 0){
Console.WriteLine(num1 + " es múltiplo de " + num2);
}else{
Console.WriteLine(num1 + " No es múltiplo de " + num2);
}
*/
//Ejercicio#4
/*
Console.WriteLine("Escribe un numero entero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe otro numero entero: ");
int num2 = int.Parse(Console.ReadLine());
if(num2 > 0){
int result = num1 / num2;
Console.WriteLine("El resultado de la division es: "+result);
}
else{
Console.WriteLine("Error!! No se puede dividir entre cerooooo");
}*/
//Ejercicio #5
/*
Console.WriteLine("INGRESE DOS NUMEROS CORTOS");
Console.WriteLine("Escribe el primer numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe el sNUMEROS ");
int num2 = int.Parse(Console.ReadLine());
if(num1 == num2){
Console.WriteLine(num1+" es igual a: "+num2);
}
else if(num1 > num2){
Console.WriteLine(num1+" Es mayor que "+num2);
}else{
  Console.WriteLine(num2+" Es mayor que "+num1);
}*/
/*
//Ejercicio #6
int a;
int b;
t c;
Console.WriteLine("Escribe el primer numero: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe el segundo numero: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe el tercer numero: ");
c = int.Parse(Console.ReadLine());

if(a > b && a > c){  
Console.WriteLine("Numeros ingresados: "+a+','+b+','+c);
Console.WriteLine("El es el mayor: "+a);
}  
else if(b > a && b > c){  
Console.WriteLine("Numeros ingresados: "+a+','+b+','+c);
Console.WriteLine("El es el mayor: "+b);
}
else if(c > a && c > b){
Console.WriteLine("Numeros ingresados: "+a+','+b+','+c);
Console.WriteLine("El es el mayor: "+c);
}  
}
*/
//Ejercicio #10
/*
Console.WriteLine("Escribe un numero entero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escribe otro numero entero: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 < num2){
Console.WriteLine("El primer numero es el menor: "+num1);
}else{
Console.WriteLine("El segundo numero es el menor: "+num2);
}
*/
}}
 }
    
