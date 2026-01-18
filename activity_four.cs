List<int> numbers = new List<int>();
string zero_indicator = "number";
Console.WriteLine("Enter 0 to end program and print a list of numbers.");
do
{
    Console.Write("Enter a number: ");
    int add_to_list = int.Parse(Console.ReadLine());
    if (add_to_list != 0)
    {
        numbers.Add(add_to_list);

    }
    else
    {
        zero_indicator = "zero";
    }

} while (zero_indicator != "zero");

numbers.Sort();
Console.WriteLine("Your Sorted list is: ");

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}