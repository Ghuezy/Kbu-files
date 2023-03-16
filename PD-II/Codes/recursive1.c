#include <stdio.h>

int rec1(int x);
int main(){

    int x;
    int result;

    printf("Enter a number: ");
    scanf("%d", &x);

    result = rec1(x);
    printf(("%d"), result);

    return 0;
}

int rec1(int x)
{
    int result;
    if ( x <= 0)
    {
        result = 0;
    } else
    {
        result = rec1(x - 1) + 2;
    }

    return result;
}