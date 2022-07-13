#include <stdio.h>
#include <stdlib.h>


int sum(int,int);
int factorial(int);

int main()
{
int a = 10, b = 20;
printf("%d", a + b);
return 0;
}



int sum(int a,int b )
{
	return a + b;
}



int factorial (int number)
{
	return number * factorial(number - 1);
}
