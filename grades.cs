using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLists
{
    class Program
    {
        static void Main()
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;
            // Array of student grades
            int[] sophia = new int[5] { 93, 87, 98, 95, 100 };
            int[] nicolas = new int[5] { 80, 83, 82, 88, 85 };
            int[] zahirah = new int[5] { 84, 96, 73, 85, 79 };
            int[] jeong = new int[5] { 90, 92, 98, 100, 97 };
          // Add the arrays up
            int sophiaSum = sophia.Sum();
            int nicolasSum = nicolas.Sum();
            int zahirahSum = zahirah.Sum();
            int jeongSum = jeong.Sum();
          // Get average grade for the total assignments
            decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal) jeongSum / currentAssignments;
          // Instantiate  final grade variables for use in switch cases
            string sophiafinalgrade;
            string nicolasfinalgrade;
            string zahirahfinalgrade;
            string jeongfinalgrade;
          // Switch case for sophia
            switch (sophiaScore)
            {
                case >= 83 and <= 86:
                    sophiafinalgrade = "B";
                    break;
                case >= 87 and <= 89:
                    sophiafinalgrade = "B+";
                    break;
                case >= 90.0m and <= 92m:
                    sophiafinalgrade = "A-";
                    break;
                case >= 93.0m and <= 96m:
                    sophiafinalgrade = "A";
                    break;
                case >= 97.0m and <= 100m:
                    sophiafinalgrade = "A+";
                    break;
                default:
                    sophiafinalgrade = "B-";
                    break;

            }
           // Switch case for nicolas
            switch (nicolasScore)
            {
                case >= 83 and <= 86:
                    nicolasfinalgrade = "B";
                    break;
                case >= 87 and <= 89:
                    nicolasfinalgrade = "B+";
                    break;
                case >= 90.0m and <= 92m:
                    nicolasfinalgrade = "A-";
                    break;
                case >= 93.0m and <= 96m:
                    nicolasfinalgrade = "A";
                    break;
                case >= 97.0m and <= 100m:
                    nicolasfinalgrade = "A+";
                    break;
                default:
                    nicolasfinalgrade = "B-";
                    break;

            }
              // Switch case for zahirah
            switch (zahirahScore)
            {
                case >= 83 and <= 86:
                    zahirahfinalgrade = "B";
                    break;
                case >= 87 and <= 89:
                    zahirahfinalgrade = "B+";
                    break;
                case >= 90.0m and <= 92m:
                    zahirahfinalgrade = "A-";
                    break;
                case >= 93.0m and <= 96m:
                    zahirahfinalgrade = "A";
                    break;
                case >= 97.0m and <= 100m:
                    zahirahfinalgrade = "A+";
                    break;
                default:
                    zahirahfinalgrade = "B-";
                    break;

            }
             // Switch case for jeong
            switch (jeongScore)
            {
                case >= 83 and <= 86:
                    jeongfinalgrade = "B";
                    break;
                case >= 87 and <= 89:
                    jeongfinalgrade = "B+";
                    break;
                case >= 90.0m and <= 92m:
                    jeongfinalgrade = "A-";
                    break;
                case >= 93.0m and <= 96m:
                    jeongfinalgrade = "A";
                    break;
                case >= 97.0m and <= 100m:
                    jeongfinalgrade = "A+";
                    break;
                default:
                    jeongfinalgrade = "B-";
                    break;

            }
            // Write grades to Command Line
            Console.WriteLine($"Sophia: {sophiafinalgrade}");

            Console.WriteLine($"Nicolas: {nicolasfinalgrade}");

            Console.WriteLine($"Zahirah: {zahirahfinalgrade}");

            Console.WriteLine($"Jeong: {jeongfinalgrade}");


        }
    }
}
