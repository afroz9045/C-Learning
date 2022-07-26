using System.Collections;
using System.Collections.Generic;
using ArrarListLib;
using HashTableLib;
using StackLib;
using QueueLib;
using GenericListLib;
using DictionaryLib;
//int[] Arr = new int[3];
//Arr[0] = 10;
//Arr[1] = 20;
//Arr[2] = 30;
////Arr[3] = 50; //This is creating problem as this element is out of index
//Console.WriteLine(Arr[2]);


Console.WriteLine("Array List:");
ArrList.ArrListCreate();

Console.WriteLine("\nHash table:");
HashTable.CreateHashTable();

Console.WriteLine("\nNon generic stack:");
NonGenStack.StackDataShow();

Console.WriteLine("\nNon generic queue:");
NonGenQueue.ShowQueue();

Console.WriteLine("\nGeneric List:");
GenericList.ShowList();

Console.WriteLine("Dictionary:");
Dictionary.ShowDictionary();

