using System;
using System.Collections.Generic;
using System.Text;

namespace DoublingTheValue
{
    class ArrayUtility
    {
        public static int[] GetArrayFromUserInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                array = new int[numberElements];
                Console.WriteLine("Enter the elements of the array separated by" +
                    " space, comma or semi-colon");
                String[] elements = Console.ReadLine().Trim().Split(' ', ';',',');
                for (int index = 0; index < numberElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }
            return array;
        }

        public static void DoublingValue(int[] array) {

            Console.WriteLine("Enter the value that has to be found");
            try {
                int value = int.Parse(Console.ReadLine().Trim());
                _FindDoubledUpValueInArray(array, value);
            }catch(Exception exception){
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
        }

        public static void _FindDoubledUpValueInArray(int[] array, int value) {
            while (true) {
                bool result = _InArray(array, value);
                if (!result) {
                    Console.WriteLine("DoublingUp stops at value "+value);
                    break;
                }
                value = 2 * value; 
            }
        }

        private static bool _InArray(int[] array, int value) {
            for (int index = 0; index < array.Length; index++) {
                if (array[index] == value) {
                    return true;
                }
            }
            return false;
        } 
    }
}
