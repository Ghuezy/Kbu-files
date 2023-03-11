#include <stdio.h>
#include <time.h>
#include <stdlib.h>

void main() {

    int dice1,dice2;
    int totalNumber,totalNumber2;

    srand(time(NULL));

    dice1 = rand() % 6 + 1;
    dice2 = rand() % 6 + 1;

    totalNumber = dice1 + dice2;

    switch (totalNumber) {

        case 7:
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You WON!!!");
            break;
        case 11:
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You WON!!!");
            break;
        case 2:
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You LOST!!!");
            break;
        case 3:
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You LOST!!!");
            break;
        case 12:
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You LOST!!!");
            break;
    }

    printf("Dice 1: %d \n", dice1);
    printf("Dice 2 : %d \n",dice2);
    printf("Total : %d \n\n",totalNumber);

    dice1 = rand() % 6 + 1;
    dice2 = rand() % 6 + 1;

    totalNumber2 = dice1 + dice2;

    if (totalNumber2 != 7){
        if (totalNumber == totalNumber2){
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You WON!!!");
        } else {
            printf("Dice 1: %d \n", dice1);
            printf("Dice 2 : %d \n",dice2);
            printf("You LOST!!!\n");
            totalNumber2 = 7;
        }

        totalNumber2 = 7;

    } else {

        printf("Dice 1: %d \n", dice1);
        printf("Dice 2 : %d \n",dice2);
        printf("You LOST!!!\n");

        printf("Thanks for playing!");
    }
}