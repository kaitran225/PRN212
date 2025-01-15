using System;
internal class EXE01
{
    private static bool PrintRangedNums()
    {
        Console.Write("Enter lower bound: ");
        int? n = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter upper bound: ");
        int? m = int.Parse(Console.ReadLine().Trim());
        if (n < m)
        {
            for (int i = (int)n; i <= m; i++)
            {
                Console.WriteLine(i);
            }
            return true;
        }
        else
        {
            Console.WriteLine(" Lower bound should not be either equal nor larger than upper bound");
            return false;
        }
    }
    private static void Main(string[] args)
    {

        while (true)
        {
            if (PrintRangedNums()) {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break; }
        }
    }
}


class Program
{
    static void Exercise1()
    {
        Console.WriteLine("\nPrint numbers from n to m");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static void Exercise2()
    {
        Console.WriteLine("\nPrint odd numbers between n and m");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            if (i % 2 != 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static void Exercise3()
    {
        Console.WriteLine("\nPrint even numbers in reverse from m to n");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = m; i >= n; i--)
        {
            if (i % 2 == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static void Exercise4()
    {
        Console.WriteLine("\nCalculate sum of numbers from n to m");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum: {sum}");
    }

    static void Exercise5()
    {
        Console.WriteLine("\nPrint numbers divisible by k between n and m");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int sum = 0;
        Console.WriteLine($"Numbers divisible by {k}:");
        for (int i = n; i <= m; i++)
        {
            if (i % k == 0)
            {
                Console.Write($"{i} ");
                sum += i;
            }
        }
        Console.WriteLine($"\nSum: {sum}");
    }

    static void Exercise6()
    {
        Console.WriteLine("\nCount numbers divisible by both x and y between n and m");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        int count = 0;
        Console.WriteLine($"Numbers divisible by both {x} and {y}:");
        for (int i = n; i <= m; i++)
        {
            if (i % x == 0 && i % y == 0)
            {
                Console.Write($"{i} ");
                count++;
            }
        }
        Console.WriteLine($"\nCount: {count}");
    }

    static void Exercise7()
    {
        Console.WriteLine("\nCalculate average of k numbers");
        Console.Write("Enter k (number of values to input): ");
        int k = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            sum += double.Parse(Console.ReadLine());
        }

        double average = sum / k;
        Console.WriteLine($"Average: {average:F2}");
    }

    static void Exercise8()
    {
        Console.WriteLine("\nFind largest and smallest among k numbers");
        Console.Write("Enter k (number of values to input): ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter number 1: ");
        double first = double.Parse(Console.ReadLine());
        double min = first;
        double max = first;

        for (int i = 2; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            double num = double.Parse(Console.ReadLine());
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine($"Smallest number: {min}");
        Console.WriteLine($"Largest number: {max}");
    }

    static void Exercise9()
    {
        Console.WriteLine("\nCalculate averages and count numbers");
        Console.Write("Enter k (number of values to input): ");
        int k = int.Parse(Console.ReadLine());

        double positiveSum = 0, negativeSum = 0;
        int positiveCount = 0, negativeCount = 0;
        int evenCount = 0, oddCount = 0;

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                positiveSum += num;
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeSum += num;
                negativeCount++;
            }

            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"Average of positive numbers: {(positiveCount > 0 ? positiveSum / positiveCount : 0):F2}");
        Console.WriteLine($"Average of negative numbers: {(negativeCount > 0 ? negativeSum / negativeCount : 0):F2}");
        Console.WriteLine($"Even numbers count: {evenCount}");
        Console.WriteLine($"Odd numbers count: {oddCount}");
    }

    static void Exercise10()
    {
        Console.WriteLine("\nCount positive odd and negative even numbers");
        Console.Write("Enter k (number of values to input): ");
        int k = int.Parse(Console.ReadLine());

        int positiveOddCount = 0, negativeEvenCount = 0;

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num % 2 != 0)
                positiveOddCount++;
            else if (num < 0 && num % 2 == 0)
                negativeEvenCount++;
        }

        Console.WriteLine($"Positive odd numbers: {positiveOddCount}");
        Console.WriteLine($"Negative even numbers: {negativeEvenCount}");
    }

    static void Exercise11()
    {
        Console.WriteLine("\nCount vowels and spaces in a sentence");
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int vowels = 0, spaces = 0;
        foreach (char c in sentence.ToLower())
        {
            if ("aeiou".Contains(c)) vowels++;
            if (c == ' ') spaces++;
        }

        Console.WriteLine($"Number of vowels: {vowels}");
        Console.WriteLine($"Number of spaces: {spaces}");
    }

    static void Exercise12()
    {
        Console.WriteLine("\nProcess student names and scores");
        Console.Write("Enter number of students: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter passing score: ");
        double passingScore = double.Parse(Console.ReadLine());

        string[] names = new string[k];
        double[] scores = new double[k];
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");
            names[i] = Console.ReadLine();
            Console.Write($"Enter score for {names[i]}: ");
            scores[i] = double.Parse(Console.ReadLine());
            sum += scores[i];
        }

        Console.WriteLine("\nPassing students:");
        for (int i = 0; i < k; i++)
        {
            if (scores[i] >= passingScore)
                Console.WriteLine(names[i]);
        }
        Console.WriteLine($"Average score: {sum / k:F2}");
    }

    static void Exercise13()
    {
        Console.WriteLine("\nCheck if word is palindrome");
        Console.Write("Enter a word: ");
        string word = Console.ReadLine().ToLower();

        bool isPalindrome = true;
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine($"'{word}' is {(isPalindrome ? "" : "not ")}a palindrome");
    }

    static void Exercise14()
    {
        Console.WriteLine("\nCount words in a sentence");
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine().Trim();

        string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Number of words: {words.Length}");
    }

    static void Exercise15()
    {
        Console.WriteLine("\nCheck if number is prime");
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Not prime");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine($"{num} is {(isPrime ? "" : "not ")}prime");
    }

    static void Exercise16()
    {
        Console.WriteLine("\nCalculate factorial");
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{n}! = {factorial}");
    }

    static void Exercise17()
    {
        Console.WriteLine("\nReverse number digits");
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }

        Console.WriteLine($"Reversed number: {reversed}");
    }

    static void Exercise18()
    {
        Console.WriteLine("\nConvert decimal to binary");
        Console.Write("Enter a decimal number: ");
        int num = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(num, 2);
        Console.WriteLine($"Binary equivalent: {binary}");
    }

    static void Exercise19()
    {
        Console.WriteLine("\nBasic Calculator");
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Console.ReadLine()[0];
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        double result = op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };

        if (double.IsNaN(result))
            Console.WriteLine("Invalid operation");
        else
            Console.WriteLine($"Result: {result}");
    }

    static void Exercise20()
    {
        Console.WriteLine("\nProcess number digits");
        Console.Write("Enter a number: ");
        string numStr = Console.ReadLine();
        int num = int.Parse(numStr);

        // Reverse digits
        int reversed = 0;
        int tempNum = num;
        while (tempNum > 0)
        {
            reversed = reversed * 10 + tempNum % 10;
            tempNum /= 10;
        }

        // Find smallest and largest digit
        int smallest = 9, largest = 0;
        int sum = 0;
        foreach (char c in numStr)
        {
            int digit = c - '0';
            smallest = Math.Min(smallest, digit);
            largest = Math.Max(largest, digit);
            sum += digit;
        }

        Console.WriteLine($"Reversed number: {reversed}");
        Console.WriteLine($"Smallest digit: {smallest}");
        Console.WriteLine($"Largest digit: {largest}");
        Console.WriteLine($"Sum of digits: {sum}");
    }

    static void Exercise21()
    {
        Console.WriteLine("\nGeometric Shape Calculator");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Circle");
        Console.WriteLine("4. Triangle");
        Console.Write("Choose shape (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter side length: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {side * side:F2}");
                Console.WriteLine($"Perimeter: {4 * side:F2}");
                break;
            case 2:
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {length * width:F2}");
                Console.WriteLine($"Perimeter: {2 * (length + width):F2}");
                break;
            case 3:
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {Math.PI * radius * radius:F2}");
                Console.WriteLine($"Perimeter: {2 * Math.PI * radius:F2}");
                break;
            case 4:
                Console.Write("Enter base: ");
                double base_ = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Enter side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side 2: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {0.5 * base_ * height:F2}");
                Console.WriteLine($"Perimeter: {base_ + side1 + side2:F2}");
                break;
        }
    }

    static void Exercise22()
    {
        Console.WriteLine("\n3D Shape Volume Calculator");
        Console.WriteLine("1. Sphere");
        Console.WriteLine("2. Cylinder");
        Console.WriteLine("3. Cone");
        Console.WriteLine("4. Rectangular Box");
        Console.Write("Choose shape (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Volume: {(4.0 / 3.0) * Math.PI * Math.Pow(radius, 3):F2}");
                break;
            case 2:
                Console.Write("Enter radius: ");
                radius = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Volume: {Math.PI * radius * radius * height:F2}");
                break;
            case 3:
                Console.Write("Enter radius: ");
                radius = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Volume: {(1.0 / 3.0) * Math.PI * radius * radius * height:F2}");
                break;
            case 4:
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Volume: {length * width * height:F2}");
                break;
        }
    }

    static void Exercise23()
    {
        Console.WriteLine("\nFind prime numbers in range");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers:");
        for (int num = n; num <= m; num++)
        {
            if (num <= 1) continue;
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.Write($"{num} ");
        }
        Console.WriteLine();
    }

    static void Exercise24()
    {
        Console.WriteLine("\nProcess numbers until -1");
        List<double> numbers = new List<double>();

        while (true)
        {
            Console.Write("Enter a number (-1 to stop): ");
            double num = double.Parse(Console.ReadLine());
            if (num == -1) break;
            numbers.Add(num);
        }

        if (numbers.Count > 0)
        {
            Console.WriteLine($"Average: {numbers.Average():F2}");
            Console.WriteLine($"Maximum: {numbers.Max():F2}");
            Console.WriteLine($"Minimum: {numbers.Min():F2}");
        }
        else
        {
            Console.WriteLine("No numbers entered");
        }
    }

    static void Exercise25()
    {
        Console.WriteLine("\nBank Account System");
        double balance = 0;

        while (true)
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option (1-4): ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 4) break;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine("Deposit successful");
                    }
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    if (withdraw > 0 && withdraw <= balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine("Withdrawal successful");
                    }
                    else
                        Console.WriteLine("Insufficient funds");
                    break;
                case 3:
                    Console.WriteLine($"Current balance: ${balance:F2}");
                    break;
            }
        }
    }

    static void Exercise26()
    {
        Console.WriteLine("\nNumber Guessing Game");
        Console.Write("Enter minimum number: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter maximum number: ");
        int max = int.Parse(Console.ReadLine());

        Random random = new Random();
        int target = random.Next(min, max + 1);
        int attempts = 0;

        while (true)
        {
            Console.Write("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess == target)
            {
                Console.WriteLine($"Correct! You took {attempts} attempts");
                break;
            }
            else if (guess < target)
                Console.WriteLine("Higher!");
            else
                Console.WriteLine("Lower!");
        }
    }

    static void Exercise27()
    {
        Console.WriteLine("\nText File Analysis");
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        try
        {
            string text = File.ReadAllText(path);
            string[] lines = File.ReadAllLines(path);
            string[] words = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words.OrderByDescending(w => w.Length).First();

            Console.WriteLine($"Number of lines: {lines.Length}");
            Console.WriteLine($"Number of words: {words.Length}");
            Console.WriteLine($"Number of characters: {text.Length}");
            Console.WriteLine($"Longest word: {longestWord}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Exercise28()
    {
        Console.WriteLine("\nStudent Grades Dictionary");
        Dictionary<string, double> students = new Dictionary<string, double>();

        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter grade: ");
            double grade = double.Parse(Console.ReadLine());
            students[name] = grade;
        }

        Console.Write("Enter threshold grade: ");
        double threshold = double.Parse(Console.ReadLine());

        Console.WriteLine("\nStudents above threshold:");
        foreach (var student in students.Where(s => s.Value >= threshold))
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }

        var topStudent = students.OrderByDescending(s => s.Value).First();
        Console.WriteLine($"\nHighest grade: {topStudent.Key} ({topStudent.Value})");
    }

    static void Exercise29()
    {
        Console.WriteLine("\nCSV Product Analysis");
        Console.Write("Enter CSV file path: ");
        string path = Console.ReadLine();
        Console.Write("Enter price threshold: ");
        double threshold = double.Parse(Console.ReadLine());

        try
        {
            string[] lines = File.ReadAllLines(path);
            double totalValue = 0;

            Console.WriteLine("\nProducts above threshold:");
            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] parts = lines[i].Split(',');
                string name = parts[0];
                double price = double.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                if (price > threshold)
                    Console.WriteLine($"{name} - ${price}");

                totalValue += price * quantity;
            }

            Console.WriteLine($"\nTotal inventory value: ${totalValue:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Exercise30()
    {
        Console.WriteLine("\nFibonacci Number");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        long result = Fibonacci(n);
        Console.WriteLine($"The {n}th Fibonacci number is: {result}");
    }

    static long Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Exercise31()
    {
        Console.WriteLine("\nGCD Calculator");
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = CalculateGCD(a, b);
        Console.WriteLine($"GCD of {a} and {b} is: {gcd}");
    }

    static int CalculateGCD(int a, int b)
    {
        if (b == 0) return a;
        return CalculateGCD(b, a % b);
    }

    static void Exercise32()
    {
        Console.WriteLine("\nTower of Hanoi");
        Console.Write("Enter number of disks: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nSteps to solve Tower of Hanoi with {n} disks:");
        SolveTowerOfHanoi(n, 'A', 'C', 'B');
    }

    static void SolveTowerOfHanoi(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {destination}");
            return;
        }

        SolveTowerOfHanoi(n - 1, source, auxiliary, destination);
        Console.WriteLine($"Move disk {n} from {source} to {destination}");
        SolveTowerOfHanoi(n - 1, auxiliary, destination, source);
    }
}