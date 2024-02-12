

Console.Write("Enter a number: ");
string inputNumber = Console.ReadLine();
int number = Convert.ToInt32(inputNumber);

bool isPrime = true;
int count = number/2;
for(int i=2; i<=count; i++)
{
    if(number%i==0)
    {
        isPrime=false;
        break;
    }
}

if(isPrime)
{
    System.Console.WriteLine("This is prime number");
}
else
{
    System.Console.WriteLine("This is not prime number");
}

