
const double TAX_RATE = 0.0675;
double mealCost;
double tax;
double tip;
double totalbill;

Console.WriteLine("Enter the total cost of the meal.");
mealCost = Convert.ToDouble(Console.ReadLine());
tax = mealCost * TAX_RATE;
tip = mealCost * 0.2;
totalbill = mealCost + tax + tip;

Console.WriteLine($"The meal cost is: {mealCost}");
Console.WriteLine($"The tax is: {tax}");
Console.WriteLine($"The tip is: {tip}");
Console.WriteLine($"The total bill is: {totalbill}");
