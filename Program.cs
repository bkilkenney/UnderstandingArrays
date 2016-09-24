using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] frontNine = new int [] { 4, 6, 3, 4, 4, 5, 3, 4, 5 }; /*declaring and assigning value to a new array with 9 elements. Putting 9 inside []
            //                                                            wouldn't hurt but it's not necessary*/

            //Console.WriteLine("I got a " +frontNine[3]+ " on the 4th hole.  Which is the element \nat the index of 3 in this array.");
            ////Prints the element at the index of 3.  Output: 4
            //Console.ReadLine();

            //Console.WriteLine("There are " +frontNine.Length+ " elements in this array");
            //Console.ReadLine();

            //Console.WriteLine("I shot a " +frontNine.Sum() + " on the front nine.");



            //*************************New array of strings below***************************************


            //string[] familiyMembers = new string[] { "Mom", "Dad", "Ryan", "Max", "Brad" };

            //for (int i = 0; i < familiyMembers.Length; i++) //will loop through array until it reaches the max length.   
            //{
            //    Console.WriteLine(familiyMembers[i]); //Family member at the index of i
            //}


            //************************Another way to print all the values of an array below***********************

            string[] familiyMembers = new string[] { "Mom", "Dad", "Ryan", "Max", "Brad" };

            foreach (string name in familiyMembers)  //Made up temporary variable "name" on the fly, it only exists in this loop
            {
                Console.WriteLine(name); //This is more efficient than the for loop, less going on. 
            }
            Console.ReadLine();


            //************************Reverse method below*****************************

            //string rollingStones = "You can't always get what you want, \nyou cant always get what you want, \nyou can't always get what you want, \nbut if you try sometimes, \nyou just might find, \nyou get waht you need.";
            //Console.WriteLine(rollingStones);
            //Console.ReadLine();

            //using .ToCharArray method to convert a string to array and reverse it below: 

            //char[] charArray = rollingStones.ToCharArray();
            //Array.Reverse(charArray);

            //foreach (char stonesChar in charArray)  //stonesChar is temporary, only used in scope of this loop
            //{
            //    Console.Write(stonesChar);  //In a foreach, the temporary var will usually be what you want to print, in this case stonesChar
            //}
            //Console.ReadLine();
            //Console.ReadLine();

            //Console.WriteLine(charArray[101]); /*Just double-checking that every letter in the entire string is an element of this array.
            //                                   It's not very efficient though, collections will work better
            //Console.ReadLine(); 
        }
    }
}
