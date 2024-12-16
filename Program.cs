/*
You are a student who has recently taken an exam with your classmates.
However, the professor has not yet provided the students with a sorted list of exam scores.
To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
This way, you can obtain the sorted list of scores and see how you performed compared to your classmates.
Also, you choose selection sort since that is an easy way of implementation
*/

//nested for loop
//run through array and make temp array
//not bubble sort?

namespace Assignment_7._1_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hardcode example
            int[] exams = { 7, 12, 9, 11, 3 }; //these scores are terrible

            //printing arrays
            Console.WriteLine("Assignment 7.1 Question 1 Selection Sorting example:");
            Console.WriteLine("");
            Console.WriteLine("Initial scores: " + string.Join(", ", exams));
            SelectionSort(exams);
            Console.WriteLine("");
            Console.WriteLine("Selection Sorted Scores: " + string.Join(", ", exams));
        }
        static void SelectionSort(int[] scores)
        {
            int n = scores.Length;

            //typical loop through array
            for (int i = 0; i < n - 1; i++)
            {
                //define for movement
                int Index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[Index])
                    {
                        Index = j;
                    }
                }
                //another loop of its own - circular logic?
                int temp = scores[Index];
                scores[Index] = scores[i];
                scores[i] = temp;
            }
        }
    }
}
