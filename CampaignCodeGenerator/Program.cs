// See https://aka.ms/new-console-template for more information
using CampaignCodeGenerator;

Console.WriteLine("Do you want to generate or validate codes? (G or V)");

switch (Console.ReadLine())
{
    case "G":
        Console.WriteLine("How many codes do you want to generate? (Between 1-1000)");
        var key = Convert.ToInt32(Console.ReadLine());
        if (key > 1000)
            Console.WriteLine("You have to enter number between 1 and 1000.");
        else
        {
            var result = Generate.GenerateCodes(key);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        break;
    case "V":
        Console.WriteLine("Enter the code you want to validate:");
        Console.WriteLine(Validate.ValidateCode(Console.ReadLine()));
        break;
    default:
        Console.WriteLine("Invalid character");
        break;
}

Console.ReadLine();
