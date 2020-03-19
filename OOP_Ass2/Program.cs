using System;
using System.IO;

namespace OOP_Ass2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the variables here so they can be used in catch
            string file_1 = "";
            string file_2 = "";
            string[] user_input = { };
            bool different = false;
            try
            {
                //Loop the program until the user enters diff as the first word
                bool diff = false;
                while (diff == false)
                {
                    Console.Write(">: [Input] ");
                    //Read the users input and split each word into an array
                    user_input = Console.ReadLine().Split();
                    if (user_input[0] != "diff")
                    {
                        Console.WriteLine("diff command was not used, try again");
                    }
                    else
                    {
                        diff = true;
                    }
                }
                //Find the users inputs files and read their contents
                file_1 = File.ReadAllText(user_input[1]);
                file_2 = File.ReadAllText(user_input[2]);
                //Split each file up by each character and save it into an array
                char[] array_1 = file_1.ToCharArray();
                char[] array_2 = file_2.ToCharArray();

                //Loop through the first array checking each character against the second array
                for (int i = 0; i < array_1.Length; i++)
                {
                    if (array_1[i] == array_2[i])
                    {
                    }
                    else
                    {
                        //If the characters are different, change the bool to true
                        different = true;
                    }
                }
                //Loop through the second array checking each character against the first array
                //This is done in case the second array is the same up until the length of the first then different after
                for (int i = 0; i < array_2.Length; i++)
                {
                    if (array_1[i] == array_2[i])
                    {
                    }
                    else
                    {
                        //If the characters are different, change the bool to true
                        different = true;
                    }
                }
                //Depending on if the files are different or not, display the result to the user
                if (different == true)
                {
                    Console.WriteLine($">: [Output] {user_input[1]} and {user_input[2]} are different");
                }
                else
                {
                    Console.WriteLine($">: [Output] {user_input[1]} and {user_input[2]} are not different");
                }
            }
            //If one file is longer than the other you will get this exception. Display that the files are different to the user
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine($">: [Output] {user_input[1]} and {user_input[2]} are different");
            }
            //If the user entered a file that does not exist, display this error
            catch(FileNotFoundException)
            {
                Console.WriteLine($"The file you entered was not found, please check all spelling");
            }
            //For all other errors that may occur, display this error
            catch(Exception e)
            {
                Console.WriteLine($"ERROR: {e}");
            }
        }
    }
}
