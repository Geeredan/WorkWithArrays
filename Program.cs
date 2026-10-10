
//// Task 1: An array of 10 elements and even indices

//Console.WriteLine("--- Task 1: Array and even indices ---");
//// Ccreate an array of 10 elements of type int.
//int[] numbers = new int[10];

//// Create a Random object to generate random numbers
//Random random = new Random();

//// Fill the array with random numbers from -10 to 10
//// Next(-10, 11) -> generates numbers from -10 to 10 (11 is excluded)
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(-10, 11);
//}

//Console.WriteLine("Array elements with even indices (0, 2, 4, 6, 8):");

//// Output elements with even indices
//for (int i = 0; i < numbers.Length; i += 2)
//{
//    Console.WriteLine($"Indices {i}: {numbers[i]}");
//}

///////////////////////////////////////////////////////////////////////////////////

// Task 2: Checking the sum of array elements


//Console.WriteLine("--- Task 2: cheking sum---");

//// Create and populate the array (as in Task 1)
//int[] numbers = new int[10];
//Random random = new Random();

//for (int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i] = random.Next(-10, 11);
//        Console.Write(numbers[i] + " ");
//    }
//Console.WriteLine();

//// Count sum of all elemrnts
//int sum = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        sum = sum + numbers[i];
//    }

//if (sum >= 0)
//    {
//        Console.WriteLine($"Sum of elements = {sum}. The sum is a non-negative number.");
//    }
//    else
//    {
//        Console.WriteLine($"Sum of elements = {sum}. The sum is a negative number..");
//    }

/////////////////////////////////////////////////////////////////////////////////////////////

////Task 3: 9x9 Two-Dimensional Array (Multiplication Table)

//Console.WriteLine("--- Task 3: Multiplication Table 9x9 ---");

//// We create a 9x9 two-dimensional array
//int[,] matrix = new int[9, 9];

//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        matrix[i, j] = (i + 1) * (j + 1);
//    }
//}
//// Display the array on the screen
//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        Console.Write(matrix[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
////////////////////////////////////////////////////////////////////

//// Task 4: 5x5 Two-Dimensional Array (Maximum/Minimum)

//Console.WriteLine("--- Task 4 - searching for min and max in array 5x5 ---");

//    int[,] matrix = new int[5, 5];
//    Random random = new Random();

//// Fill the array with random numbers from 1 to 100
//for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            matrix[i, j] = random.Next(1, 101);
//            Console.Write(matrix[i, j] + "\t");
//        }
//        Console.WriteLine();
//    }

//// Initialize the variables with the first element of the array
//int max = matrix[0, 0];
//int min = matrix[0, 0];

//// Variables for storing coordinates
//int maxRow = 0, maxCol = 0;
//int minRow = 0, minCol = 0;


//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            if (matrix[i, j] > max)
//            {
//                max = matrix[i, j];
//                maxRow = i;
//                maxCol = j;
//            }

//            if (matrix[i, j] < min)
//            {
//                min = matrix[i, j];
//                minRow = i;
//                minCol = j;
//            }
//        }
//    }

//    Console.WriteLine($"\nа) Max element {max}");
//    Console.WriteLine($"б) Min element: {min}");
//    Console.WriteLine($"в) Coordinates of the min element: row{minRow}, column {minCol}");
//    Console.WriteLine($"г) Coordinates of the max element: row {maxRow}, column {maxCol}");

////////////////////////////////////////////////////////////////////////////////////////////

// Task 5: Enum (Day of the week)

// We create an enum (enumeration) for the days of the week


enum DayOfWeek {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
public class WorkWithArrays
{
    public static void Main()
    {

        Console.WriteLine("--- Task 5: Determining the day of the week ---");

        Console.Write("Enter the number of days: ");
        int days = int.Parse(Console.ReadLine());

        int dayIndex = days % 7;

        DayOfWeek resultDay = (DayOfWeek)dayIndex;

        Console.WriteLine($" In {days} it will be {resultDay}");
    }
}