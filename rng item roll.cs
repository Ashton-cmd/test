using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize RNG
        Random dice = new Random();
        
        // Generate a random roll between 0 and 100
        double roll = dice.NextDouble() * 100;
        
        // Apply a luck modifier to the roll
        double luck = -10.5;
        luck = luck / 100;
        roll += roll * luck;

        // Round the roll to one decimal place and clamp it between 0.01 and 99.9
        roll = Math.Round(roll, 1);
        roll = Math.Clamp(roll, 0.01, 99.9);

        // Initialize rarity and weapon variables
        string rarity = "???";
        string weapon = "~~~";

        // Define lists of weapon names for each rarity
        List<string> MythicNames = new List<string> { "Excalibur", "Aegis of the Gods" };
        List<string> LegendaryNames = new List<string> { "Dragon Slayer", "Phoenix Feather Shield" };
        List<string> EpicNames = new List<string> { "Stormbringer", "Titan's Guard" };
        List<string> RareNames = new List<string> { "Shadow Blade", "Guardian's Aegis" };
        List<string> UncommonNames = new List<string> { "Ironclad Sword", "Steel Barrier" };
        List<string> CommonNames = new List<string> { "Wooden Sword", "Leather Shield" };

        // Define rarity colors
        List<(string Rarity, ConsoleColor Color)> rarityColors = new List<(string, ConsoleColor)>
        {
            ("Mythic", ConsoleColor.Yellow),
            ("Legendary", ConsoleColor.Red),
            ("Epic", ConsoleColor.DarkMagenta),
            ("Rare", ConsoleColor.Blue),
            ("Uncommon", ConsoleColor.Green),
            ("Common", ConsoleColor.Gray)
        };

        // Determine the rarity and weapon based on the roll
        switch (roll)
        {
            case >= 0 and < 2:
                rarity = "Mythic";
                weapon = MythicNames[dice.Next(0, MythicNames.Count)];
                break;
            case >= 2 and < 10:
                rarity = "Legendary";
                weapon = LegendaryNames[dice.Next(0, LegendaryNames.Count)];
                break;
            case >= 10 and < 30:
                rarity = "Epic";
                weapon = EpicNames[dice.Next(0, EpicNames.Count)];
                break;
            case >= 30 and < 50:
                rarity = "Rare";
                weapon = RareNames[dice.Next(0, RareNames.Count)];
                break;
            case >= 50 and < 70:
                rarity = "Uncommon";
                weapon = UncommonNames[dice.Next(0, UncommonNames.Count)];
                break;
            case >= 70 and < 100:
                rarity = "Common";
                weapon = CommonNames[dice.Next(0, CommonNames.Count)];
                break;
            default:
                rarity = "How did you even roll this?";
                break;
        }

        // Get the color associated with the rarity tier
        var rarityColor = rarityColors.FirstOrDefault(rc => rc.Rarity == rarity).Color;

        // Set the console text color and print the result
        Console.ForegroundColor = rarityColor;
        Console.WriteLine($"You Rolled A: {rarity} {weapon} at a {roll}% chance!");
        Console.ResetColor();
    }
}
