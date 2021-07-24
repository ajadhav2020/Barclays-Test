using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDetails fileDetails = new FileDetails();
            string output = string.Empty;
            int size = 0;

            try
            {
                //Task 1 : Here we are comparing 1st argumanet exactly with '-v' as per the problem statement and return output
                // from Version() method if its true.
                if (args[0] != null)
                {
                    if (args[0].ToLower().Equals("-v"))
                    {
                        output = fileDetails.Version(args[1]);
                        Console.WriteLine("TASK 1 ---");
                        Console.WriteLine("The output of the 1st Task from FileDetails.Version method is : " + output);
                    }

                }

                //Task 2 : Here we are checking if 1st argumanet has given character in it or not. 
                // and as per the problem statement we are returning the output from Version() or Size() accordingly..

                if (args[0] != null)
                {
                    if (args[0].ToLower().Contains('s'))
                    {
                        size = fileDetails.Size(args[1]);
                        Console.WriteLine("TASK 2 ---");
                        Console.WriteLine("The output of the end Task from FileDetails.Size method is : " + size);
                    }
                    else
                    {
                        output = fileDetails.Version(args[1]);
                        Console.WriteLine("TASK 2 ---");
                        Console.WriteLine("The output of the 2nd Task from FileDetails.Version method is : " + output);
                    }

                }
                Console.Read();
            }
            catch(Exception ex)
            {
            }
            
        }
    }
}
