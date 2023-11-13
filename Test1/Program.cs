namespace Test1;
class Program
{
	static void Main(string[] args)
	{
		MyFirstFunction();


		/*  int x;
		  int y;
		  x = 3;
		  y = x + 7;

		  Console.WriteLine(y);
		  Console.ReadLine();
	  */

		/*Console.WriteLine("What is your firstNsme?");
		Console.Write("Type your first name: ");
		string firstName;
		firstName = Console.ReadLine();

		Console.WriteLine("What is your lastName?");
		Console.Write("T ype your first name: ");
		string lastName;
		lastName = Console.ReadLine();


		Console.WriteLine("Hello," + firstName + " " + lastName);

		*/

		/*Console.WriteLine("MQ's giveaway");
		Console.Write("Choose between 1, 2, or 3: ");
		string userValue = Console.ReadLine();

		string message = (userValue == "1") ? "Car" : "keke";

		Console.Write("You won a ");
		Console.Write(message);
		Console.Write(".");
		*/

		/*  for (int i = 0; i < 10; i++)
		  {
			  if (i == 7)
			  {
				  Console.WriteLine("Found seven");
				  break;
			  }   
		  }
		 */

		/* int[] numbers = new int[] {0,1,2,3,4,5,6,7,8,9};

		 for (int i = 0; i < numbers.Length; i++)
		 {
			 Console.WriteLine("you won " + numbers[i]);
		 }

		 foreach( int number in numbers)
		 {
			 Console.WriteLine("you are " + number);

		}
	 */

		/* string sentence = "You have to work hard to make it in life";
		 char[] charArray = sentence.ToCharArray();
		 Array.Reverse(charArray);

	   string result = "";
		 foreach(char zigChar in charArray)
		 {
		   result += zigChar;
		   Console.WriteLine(zigChar);

	   }
	 */


		//string myString = String.Format("{0} = {1}", "first", "second");
		//string myString = String.Format("{0:c}", 123.45); /*dollar format */
		//string myString = String.Format("{0:N}", 1234567890); /*number format */
		//string myString = "You are \"a\" thief"; /*to use special character*/
		//string myString = String.Format("{0:P}", .123); /*as a percentage*/

		//string myString = "The new method of writing code is";
		//myString = myString.Substring(6, 14);
		//myString = myString.Replace("e","c");
		//myString = myString.Remove(0, 8);

	  /*  string myString = "";

		for(int i = 0; i < 100; i++)
		{
			myString += "--" + i.ToString();
		}

		Console.WriteLine(myString);
	  */



	}

	private static void MyFirstFunction()
	{
		Console.WriteLine("Hello my first function");
	}

	//static string MyName(string? name  = null)
	//{
	//    return name;
	//}
}

//public class Testing
//{
//    public static int TestName()
//    {
//        return 10;
//    }
//}

