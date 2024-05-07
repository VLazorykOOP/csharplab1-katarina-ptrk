//variant 10
static void task1() {
    Console.WriteLine("Task 1!");
    Console.Write("Input V: ");
    double v = Convert.ToDouble(Console.ReadLine());
    double a = Math.Pow(v, 1.0 / 3.0);
    Console.WriteLine($"The edge of a cube with volume {v} is equal to {a}");
}

static void task2() {
    Console.WriteLine("Task 2!");
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = (number / 10) + (number % 10);
    bool isOddSum = sum % 2 != 0;

    if (isOddSum) {
        Console.WriteLine($"Sum of digits of {number} is odd.");
    } else {
        Console.WriteLine($"Sum of digits of {number} is even.");
    }
}

static void task3() {
    Console.WriteLine("Task 3!");
    Console.Write("Input x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    if(y > -100 && y < 0) {
        if(y < -Math.Abs(x)) {
            Console.WriteLine("Inside area.");
        } else if(y == -Math.Abs(x)) {
            Console.WriteLine("On border.");
        } else {
            Console.WriteLine("Outside area.");
        }
    } else {
        Console.WriteLine("Outside area.");
    }
}

static void task4() {
    Console.WriteLine("Task 4!");
    Console.Write("Input n: ");
    double n = Convert.ToInt32(Console.ReadLine());
    DateTime currentDate = DateTime.Now;
    DateTime unknownDate = currentDate.AddDays(-n);
    Console.WriteLine($"Unknown date {n} days before: {unknownDate:d}");
}

static double task5(int a, int b) {
    Console.WriteLine("Task 5!");
    int sum = a + b;
    int squareOfSum = sum * sum;
    return squareOfSum;
}

static void task6() {
    Console.WriteLine("Task 6!");
    Console.Write("Input a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    double result = 5 + b/(b*b+1) + (a-b)/(a+b);
    Console.WriteLine($"Result: {result}");
}

Console.WriteLine("Lab 1!");
task1();
task2();
task3();
task4();
Console.WriteLine(task5(5,2));
task6();

