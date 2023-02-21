// See https://aka.ms/new-console-template for more information
using String_Operation;



//string input = "Ariqt InternationalA";
//string uniqueChars = "";
//for (int i = 0; i < input.Length; i++)
//{
//    if (!uniqueChars.Contains(input[i]))
//    {
//        uniqueChars += input[i];
//        break;
//    }
//}
//Console.Write(uniqueChars);


string input = "exxaamplestring";
Dictionary<char, int> charFrequency = new Dictionary<char, int>();

foreach (char letter in input)
{
    if (charFrequency.ContainsKey(letter))
    {
        charFrequency[letter]++;
    }
    else
    {
        charFrequency.Add(letter, 1);
    }
}

foreach (char c in input)
{
    if (charFrequency[c] == 1)
    {
        Console.WriteLine("First unique character: " + c);
        int index=input.IndexOf(c);
        Console.WriteLine("Index of Character is :"+index);
        break;
    }
}



//Class1 obj = new Class1();
//obj.find();

//string input = "example string";

//var uniqueChars = input.Select((letter, i) => new { Char = letter, Index = i })
//                      .Distinct()
//                      .ToList();

//foreach (var uniqueChar in uniqueChars)
//{
//    Console.WriteLine("Char: " + uniqueChar.Char + ", Index: " + uniqueChar.Index);
//    break;
//}
