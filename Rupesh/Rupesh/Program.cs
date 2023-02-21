using Rupesh;


var PersonObject = new Person("Shabbir", "Ansari");
DoChanges(PersonObject);
Console.WriteLine(PersonObject.FirstName);
Console.WriteLine(PersonObject.LastName);

void DoChanges(Person obj)
{
    obj.FirstName = "Ansari";
    obj.LastName = "Shabbir";
}
