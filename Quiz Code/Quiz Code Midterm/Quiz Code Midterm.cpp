//Kimberly Hansuwan 100752265
//Game Engines Quiz

#define EXPORT_API __declspec(dllexport)
#include <stdlib.h>    
#include<iostream>

extern "C"
{


    float EXPORT_API RandomNumber(float min, float max) {

        srand(time(NULL));

        int range = (max - min) + 1;

        return float(rand() % range + int(min));
    }
}

int main()
{

   
}