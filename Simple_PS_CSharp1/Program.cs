namespace Simple_PS_CSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q_1
            Console.WriteLine("My name is Ahmed");
            Console.WriteLine("I am 21 years old");
            Console.WriteLine("My favourite hobby is football");
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_2
            int x; double y; string s; bool b;
            x = 5; y = 10.5; s = "NONE"; b = true;
            Console.WriteLine("int value is " + x);
            Console.WriteLine("double value is " + y);
            Console.WriteLine("string value is " + s);
            Console.WriteLine("boolean value is " + b);
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_3
            Console.Write("Please enter a temperature value in celsius: ");
            double temp_in_celsisus = double.Parse(Console.ReadLine());
            double temp_in_fahrenheit = (temp_in_celsisus * 1.8) + 32;
            double formatted_temp_in_fahrenheit = Math.Round(temp_in_fahrenheit, 2);
            Console.WriteLine("Temperature " + temp_in_celsisus + " in celsius = " + formatted_temp_in_fahrenheit + " in fahrenheit");
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_4
            Console.Write("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double add, subt, mult, div;
            add = num1 + num2;
            subt = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            Console.WriteLine($""""
                {num1} + {num2} = {add}
                {num1} - {num2} = {subt}
                {num1} x {num2} = {mult}
                {num1} / {num2} = {div} 
                """");
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_5
            Console.Write("Please enter rectangle length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Please enter rectangle width: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double formatted_area = Math.Round(area, 2);
            Console.WriteLine("Rectangle area is: " + formatted_area);
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_6
            Console.Write("Please enter a number to check if it is even or odd: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_7
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("You are eligible to vote");
            else
                Console.WriteLine("You are NOT eligible to vote");
            #endregion
            Console.WriteLine("--------------------------");
            #region Q_8
            Console.WriteLine("Please enter your score from 0 to 100: ");
            double score = double.Parse(Console.ReadLine());
            if (score >= 90)
                Console.WriteLine("You got grade A");
            else if (score >= 80)
                Console.WriteLine("you got grade B");
            else if (score >= 70)
                Console.WriteLine("you got grade C");
            else if (score >= 60)
                Console.WriteLine("you got grade D");
            else
                Console.WriteLine("Fail");
            #endregion
        }
    }
}
