﻿//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

string[] array = new string[]
{ 
    "world", 
    "abc", 
    "123", 
    "a", 
    "6", 
    ";", 
    "82", 
    "hello", 
};

string[] result = new string[array.Length]; 
int k = 0; 
 
for (int i = 0; i < array.Length; i++) 
{ 
    if (array[i].Length <= 3) 
    { 
        result[k] = array[i]; 
        k++; 
    } 
} 
for (int i = 0; i < k; i++) 
{ 
    Console.WriteLine(result[i]); 
}