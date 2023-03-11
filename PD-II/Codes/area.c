#include <stdio.h>
#define pi 3.14

float area(const int r){

    float result;
    result = pi * (r * r);
    return result;
}

void main(){

    int radius;
    float result;
    printf("Enter a radius: ");
    scanf("%d",&radius);

    result = area(radius);
    
    printf("Area of the circle with the radius of %d is : %.2f",radius, result);
}

