// See https://aka.ms/new-console-template for more information
using Harsha_Vowel_Consonants;
using System;

Console.WriteLine("Hello, World!");

string name = "Matt";
string surName = "azee";
string gender = "m";
string dob = "1/1/1900";
string GenerateFiscalCode()
{
    string surnameCode = FiscalCodeGenerator.GenerateSurnameCode(surName);
    string nameCode = FiscalCodeGenerator.GenerateNameCode(name);
    string dateCode = FiscalCodeGenerator.GenerateDateCode(gender, dob);
    return surnameCode + nameCode+dateCode ;
}
var record= GenerateFiscalCode();
Console.WriteLine(record);

