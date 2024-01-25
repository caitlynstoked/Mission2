
using Mission2;

DieRoll dr = new DieRoll();


Console.WriteLine("Welcome to the dice throwing simulator!");

Console.WriteLine("How many dice rolls would you like to simulate?");

string stringRolls = Console.ReadLine();

int numRolls = 0;

Int32.TryParse(stringRolls, out numRolls);

//numRolls = int(int.Parse(numRolls));

dr.RollBothDie(numRolls);

Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");