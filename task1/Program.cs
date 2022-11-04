Console.WriteLine("введите 5-ти значное число ");

int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int rev = 0;
int dig;
while(num > 0)
{
    dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}

if(temp == rev)
{
Console.WriteLine (" число палиндром ");
}

else
{
Console.WriteLine (" число не палиндром ");
}