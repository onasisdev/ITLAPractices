using System.ComponentModel.DataAnnotations;

List<decimal> userTypedNumbers = new List<decimal>();

int selectOperation;

int wantToContinue = 0;

decimal result = 0;

try
{
    Console.WriteLine(
        "This is a simple calculator that performs \naddition, subtraction, multiplication and division.\n"
        );


    Console.WriteLine("""

    Select the mathematical operation you would like to perform:
    1. Addition 2. Subtraction 3. Multiplication 4. Division

    """);

    selectOperation = Convert.ToInt32(Console.ReadLine());


    if (selectOperation <= 4)
    {
        Console.WriteLine("Enter the first number: ");
        userTypedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("Enter the second number: ");
        userTypedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("¿Do you want to continue inserting numbers? Select: 1.Yes or 2.No");
        wantToContinue = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("You need to select one of the options as described above.");
    }


    while (wantToContinue == 1)
    {
        Console.WriteLine("Enter another number: ");
        userTypedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("¿Do you want to continue inserting numbers? Select: 1.Yes or 2.No");
        wantToContinue = Convert.ToInt32(Console.ReadLine());
    }


    switch (selectOperation)
    {
        case 1:

            foreach (decimal userTypedNumber in userTypedNumbers)
            {
                result += userTypedNumber;
            }

            Console.WriteLine($"The result of the operation is {result}. ");

            break;

        case 2:

            var firstElementToCalcSubtraction = userTypedNumbers[0];

            for (int index = 1; index < userTypedNumbers.Count; index++)
            {
                firstElementToCalcSubtraction = firstElementToCalcSubtraction - userTypedNumbers[index];
                result = firstElementToCalcSubtraction;
            }

            Console.WriteLine($"The result of the operation is {result}. ");

            break;

        case 3:

            var firstElementToCalcMultiplication = userTypedNumbers[0];

            for (int index = 1; index < userTypedNumbers.Count; index++)
            {
                firstElementToCalcMultiplication = firstElementToCalcMultiplication * userTypedNumbers[index];
                result = firstElementToCalcMultiplication;
            }

            Console.WriteLine($"The result of the operation is {result}. ");

            break;

        case 4:

            var firstElementToCalcDivision = userTypedNumbers[0];

            for (int index = 1; index < userTypedNumbers.Count; index++)
            {
                firstElementToCalcDivision = firstElementToCalcDivision / userTypedNumbers[index];
                result = firstElementToCalcDivision;
            }

            Console.WriteLine($"The result of the operation is {result}. ");

            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("The input was not in correct format.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You can not divide by 0.");
}

Console.WriteLine("Press any key to exit.");

Console.ReadKey();
