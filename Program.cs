using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Print 1-255
            Console.WriteLine("=========> PRINT 1-255 <=========");
            for(int i = 1;i <=255;i++){
                Console.WriteLine(i);
            }

            // Print odd 1-255
            Console.WriteLine("=========> PRINT ODD 1-255 <=========");
            for(int i = 1;i <=255;i++){
                if(i%2 != 0){
                    Console.WriteLine(i);
                }
            }


            // Print sum
            Console.WriteLine("=========> PRINT SUM <=========");
            int sum = 0;
            for(int i = 1;i <=255;i++){
                sum += i;
                Console.WriteLine(i+" Sum: "+ sum);
            }



            // Iterate through an array
            Console.WriteLine("=========> ITERATE THROUGH ARRAY <=========");
            int[] arr = {1,3,5,7,9,13};
            for(int i = 0;i <arr.Length;i++){
                Console.WriteLine(arr[i]);
            }

            //Find Max
            int[] arr2 = {1,-3,5,7,9,-13,25,8,4};
            int temp = 0;
            for(int i = 0;i <arr.Length;i++){
                if(arr[i] > temp){
                    temp = arr[i];
                }
            }
            Console.WriteLine("=========> FIND MAX <=========");
            Console.WriteLine(temp);


            // Get Average
            int[] arr3 = {2,10,3};
            int sum3 = 0;
            for(int i = 0;i <arr3.Length;i++){
                sum3 += arr3[i];
            }
            Console.WriteLine("=========> GET AVERAGE <=========");
            Console.WriteLine(sum3/arr3.Length);

            // Array with Odd Numbers 1-255
            Console.WriteLine("=========> ARRAY ODD 1-255 <=========");
            List<int> tempList = new List<int>();
            for(int i = 1;i <=255;i++){
                if(i%2 != 0){
                    tempList.Add(i);
                }
            }
            int[] arr4 = tempList.ToArray();

            // Greater than Y
            int[] arr5 = {1,3,5,7};
            int Y = 3;
            int sum5 = 0;
            for(int i = 0;i <arr5.Length;i++){
                if(arr5[i] > Y){
                    sum5++;
                }
            }
            Console.WriteLine("=========> GREATER THAN Y <=========");
            Console.WriteLine(sum5);

            // Square the Values
            Console.WriteLine("=========> GET AVERAGE <=========");
            int[] arr6 = {1,5,10,-2};
            for(int i = 0;i <arr6.Length;i++){
                arr6[i] = arr6[i] * arr6[i];
                Console.WriteLine(arr6[i]);
            }

            // Eliminate Negative Numbers
            Console.WriteLine("=========> Eliminate Negative Numbers <=========");
            int[] arr7 = {1,5,10,-2};
            for(int i = 0;i <arr7.Length;i++){
                if(arr7[i] < 0){
                    arr7[i] = 0;
                }
                Console.WriteLine(arr7[i]);
            }

            // Min, Max, Average
            Console.WriteLine("=========> Min, Max, Average <=========");
            int[] arr8 = {1,5,10,-2};
            int min = 0;
            int max = 0;
            int avg = 0;
            int sum8 = 0;
            for(int i = 0;i <arr8.Length;i++){
                if(arr8[i] > max){
                    max = arr8[i];
                }
                if(arr8[i] < min){
                    min = arr8[i];
                }
                sum8 += arr8[i];
            }
            avg = sum8/arr8.Length;
            Console.WriteLine("Min: "+min);
            Console.WriteLine("Max: "+max);
            Console.WriteLine("Avg: "+avg);

            // Shifting the Values in an Array
            Console.WriteLine("=========> Shifting the Values in an Array <=========");
            int[] arr9 = {1,5,10,7,-2};
            for(int i = 0;i < arr9.Length;i++){
                if(i+1 == arr9.Length){
                    arr9[arr9.Length-1] = 0;
                } else {
                    arr9[i] = arr9[i+1];
                }
                Console.WriteLine(arr9[i]);
            }

            // Number to String
            Console.WriteLine("=========> Number to String <=========");
            int[] arr10 = {-1,-3,2};
            List<object> newList = new List<object>();
            for(int i = 0;i <arr10.Length;i++){
                if(arr10[i] < 0){
                    newList.Add("Dojo");
                } else {
                    newList.Add(arr10[i]);
                }
            }
            object[] newArr = newList.ToArray();
            for(int i = 0;i <newArr.Length;i++){
                Console.WriteLine(newArr[i]);
            }
        }
    }
}
