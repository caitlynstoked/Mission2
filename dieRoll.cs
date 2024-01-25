using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mission2
{
    internal class DieRoll
    {
        Random r = new Random();
        public int[] Die1Counter(int numRolls)
        {

            int[] results1 = new int[numRolls];

            for (int icounter = 0; icounter < numRolls; icounter++)
            {
                int die1 = r.Next(1, 7);

                results1[icounter] = die1++;
            }
            return results1;

        }
        public int[] Die2Counter(int numRolls)
        {

            int[] results2 = new int[numRolls];

            for (int icounter2 = 0; icounter2 < numRolls; icounter2++)
            {
                int die2 = r.Next(1, 7);

                results2[icounter2] = die2;
            }
             return results2;

        }
        //simulate the rill for the number of times the user specified
        public int[] RollBothDie(int numRolls)
        {
            int[] results1 = Die1Counter(numRolls);
            int[] results2 = Die2Counter(numRolls);
            int[] combinedResults = new int[numRolls];

            // Ensure both arrays have the same length
            if (results1.Length != results2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            // Iterate through the arrays and add corresponding elements
            for (int i = 0, j = 0; i < results1.Length; i++, j++)
            {
                combinedResults[i] = results1[i] + results2[j]; // Corrected index
            }

            // Display results in the specified format
            for (int sum = 2; sum <= 12; sum++)
            {
                int count = combinedResults.Count(r => r == sum);
                int percentage = (int)((count / (double)numRolls) * 100);

                Console.WriteLine($"{sum}: {new string('*', percentage)}");
            }
            return combinedResults;

        }


    }
}
