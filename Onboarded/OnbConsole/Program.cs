// See https://aka.ms/new-console-template for more information
using OnbConsole;

Console.WriteLine("Onboarded App");

const string filepath = @"C:\Users\user\Downloads\outputURN\output\";
var fr = new FormRunner();

var x = fr.ExtractForm(filepath);
var validCnh = fr.ValidateCnh(x);
Console.WriteLine("Programa terminado com sucesso");



