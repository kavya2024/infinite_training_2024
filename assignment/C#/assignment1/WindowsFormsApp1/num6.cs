using System;  // Importing necessary namespaces

public class num6 // Declaration of the Exercise20 class
{
    public static void Main()  // Main method, entry point of the program
    {
        int dayno;  // Declaration of a variable to store the day number

        Console.Write("\n\n");  // Printing new lines
        Console.Write("Accept day number and display its equivalent day name in word:\n");  // Displaying the purpose of the program
        Console.Write("----------------------------------------------------------------");  // Displaying a separator
        Console.Write("\n\n");

        Console.Write("Input Day No : ");  // Prompting user to input a day number
        dayno = Convert.ToInt32(Console.ReadLine());  // Reading the input and converting it to an integer

        switch (dayno)  // Switch statement based on the entered day number
        {
            case 1:
                Console.Write("Monday \n");  // Displaying "Monday" for day number 1
                break;
            case 2:
                Console.Write("Tuesday \n");  // Displaying "Tuesday" for day number 2
                break;
            case 3:
                Console.Write("Wednesday \n");  // Displaying "Wednesday" for day number 3
                break;
            case 4:
                Console.Write("Thursday \n");  // Displaying "Thursday" for day number 4
                break;
            case 5:
                Console.Write("Friday \n");  // Displaying "Friday" for day number 5
                break;
            case 6:
                Console.Write("Saturday \n");  // Displaying "Saturday" for day number 6
                break;
            case 7:
                Console.Write("Sunday  \n");  // Displaying "Sunday" for day number 7
                break;
            default:
                Console.Write("Invalid day number. \nPlease try again ....\n");  // Handling invalid day numbers
                break;
        }
    }
}
