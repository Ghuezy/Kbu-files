#include <stdio.h>

int expo(int ,int );

int expo(int number,int power)
{
    int result;
    if (power == 0)
    {
        return 1;
    }
    else if (power == 1)
    {
        return number;
    }
    else
    {
        return number * expo(number,power-1);
    }
    
    
}

void main()
{
    
    int number;
    int power;
    int result;

    printf("Enter a number : ");
    scanf("%d",&number);
    printf("Enter a exponential : ");
    scanf("%d",&power);

    printf("%d",expo(number,power));
}
