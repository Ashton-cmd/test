using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
            Random luckRNG = new Random();
            double luck = -5; // Change this value to test different luck levels (-100,100) Negative numbers make rarer items more common & vice versa
            luck = luck / 100;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string chesttext = "You found a chest!\n";
        WriteTextWithDelay(chesttext, 5);

        System.Threading.Thread.Sleep(300);
        Console.ForegroundColor = ConsoleColor.Cyan;
        string entertoopen = "Press Enter to open the chest.\n";
        WriteTextWithDelay(entertoopen, 5);

        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        
        Random amount = new Random();
        int maxdrops = 15;
        int totaldrops = amount.Next(2, maxdrops); 
        int luckdrops = Math.Clamp((int)((Math.Abs(luck)) * maxdrops), 0, maxdrops);
        totaldrops = totaldrops + luckdrops;
       // totaldrops += maxdrops;
        totaldrops = Math.Clamp(totaldrops, 1, maxdrops);
        Console.ForegroundColor = ConsoleColor.Red;
    
        WriteTextWithDelay($"Your current luck modifier is {Math.Abs(luck)*100}%\n", 5);
        

        string itemsgot = "You Found " + totaldrops + " drops!\n\n";
        WriteTextWithDelay(itemsgot, 5);
        Console.ResetColor();

        // Random Item Loop (totaldrops)
        for (int i = 0; i < totaldrops; i++)
        {
            // Initialize RNG
            Random dice = new Random();

            // Generate a random roll between 0 and 100
            double roll = dice.NextDouble() * 100;

            // Apply a luck modifier to the roll
            
            roll += roll * luck;

            // Round the roll to one decimal place and clamp it between 0.01 and 99.9
            roll = Math.Round(roll, 1);
            roll = Math.Clamp(roll, 0.01, 99.99);

            // Initialize rarity and weapon variables
            string rarity = "???";
            string weapon = "~~~";

            // Define lists of item names for each rarity
        List<string> MythicNames = new List<string>
        {
            "Excalibur", "Aegis of Gods", "Dragonheart Plate", "Celestial Bow", "Elixir of Immortality", "Gold Vault",
            "Phoenix Blade", "Divine Shield", "Heavenly Armor", "Starfire Bow", "Potion of Eternity", "Orb of Power",
            "Crown of Kings", "Wings of Valor", "Ring of Destiny", "Amulet of Ancients", "Sword of Light", "Shield of Ages",
            "Ethereal Armor", "Stellar Bow", "Elixir of Life", "Orb of Wisdom", "Crown of Glory", "Wings of Freedom",
            "Ring of Power", "Amulet of Eternity", "Blade of Phoenix", "Draconic Shield", "Titan Armor",
            "Eagle Bow", "Potion of Divinity", "Eternal Orb", "Ancient Crown", "Phoenix Wings",
            "Titan Ring", "Godly Amulet"
        };

        List<string> LegendaryNames = new List<string>
        {
            "Dragon Slayer", "Phoenix Feather Shield", "Titan Armor", "Eagle Eye Bow", "Potion of Invincibility", "Gold Hoard",
            "Thunderfury", "Lionheart Shield", "Warrior Armor", "Sunstrike Bow", "Elixir of Giants", "Gem of Bravery",
            "Cloak of Shadows", "Boots of Speed", "Gauntlets of Strength", "Helm of Wisdom", "Sword of Ancients",
            "Phoenix Guard", "Dragonplate", "Bow of Titans", "Potion of Power", "Gem of Wisdom",
            "Eagle Cloak", "Lion's Boots", "Bearclaw Gauntlets", "Wolf's Helm", "Dragonfang Blade",
            "Eagle Shield", "Bearhide Armor", "Wolfbow", "Potion of Strength", "Gem of Power",
            "Bearskin Cloak", "Wolfsbane Boots", "Eagle Gauntlets", "Bear King's Helm"
        };

        List<string> EpicNames = new List<string>
        {
            "Stormbringer", "Titan Guard", "Mystic Armor", "Shadow Bow", "Potion of Strength", "Gold Stash",
            "Frostbite Sword", "Guardian Shield", "Sorcerer Robe", "Moonlight Bow", "Elixir of Agility", "Crystal of Power",
            "Star Mantle", "Fortitude Greaves", "Defender Bracers", "Insight Circlet", "Sword of Shadows",
            "Guardian Shield", "Sorcerer's Plate", "Lunar Bow", "Potion of Agility", "Wisdom Crystal",
            "Starlight Mantle", "Greaves of Guardians", "Enchanted Bracers", "Moonlit Circlet",
            "Guardian Blade", "Mage's Shield", "Moonwoven Armor", "Astral Bow", "Potion of Wisdom",
            "Guardian's Crystal", "Mystic Mantle", "Moonlit Greaves", "Stellar Bracers",
            "Visionary Circlet"
        };

        List<string> RareNames = new List<string>
        {
            "Shadow Blade", "Guardian Aegis", "Knight Armor", "Hunter Bow", "Potion of Healing", "Gold Pouch",
            "Flamebrand", "Defender Shield", "Paladin's Plate", "Ranger's Bow", "Elixir of Vitality", "Endurance Stone",
            "Protector's Cape", "Swiftstep Sandals", "Dexterous Gloves", "Knowledge Crown", "Shadowfang",
            "Sentinel Shield", "Noble's Armor", "Tracker Bow", "Vitality Potion", "Sage Stone",
            "Protector Cape", "Champion's Sandals", "Ranger's Gloves", "Seeker Crown",
            "Knight's Sword", "Hunter's Shield", "Defender's Plate", "Champion Bow", "Wisdom Potion",
            "Runestone", "Noble Cape", "Pathfinder Sandals", "Guardian Gloves",
            "Warrior's Crown"
        };

        List<string> UncommonNames = new List<string>
        {
            "Ironclad Sword", "Steel Barrier", "Soldier's Armor", "Longbow", "Healing Herb", "Silver Coins",
            "Bronze Blade", "Iron Bastion", "Mercenary's Plate", "Recurve Bow", "Minor Healing Potion", "Restoration Herb",
            "Shadowcloak", "Wanderer's Boots", "Skill Gauntlets", "Scout's Helm", "Iron Blade",
            "Steel Shield", "Soldier's Plate", "Marksman's Bow", "Healing Herb", "Silver Shards",
            "Bronze Saber", "Iron Guard", "Plate of Resolve", "Hawkeye Bow", "Healer's Tonic",
            "Lifebloom Herb", "Pathfinder Cloak", "Traveler's Boots", "Warden's Gauntlets",
            "Adventurer's Helm", "Iron Saber", "Guardian Shield", "Forgemaster's Plate", "Hunter's Bow"
        };

        List<string> CommonNames = new List<string>
        {
            "Wooden Sword", "Leather Shield", "Peasant's Garb", "Shortbow", "Bread Loaf", "Gold Coins",
            "Rusty Dagger", "Wooden Buckler", "Cloth Armor", "Hunting Bow", "Red Apple", "Copper Coins",
            "Stone Axe", "Splintered Buckler", "Farmer's Tunic", "Slingshot", "Cheese Wheel", "Brass Coins",
            "Walking Stick", "Tattered Cloak", "Worn Boots", "Pebble Stone", "Water Flask", "Bronze Coin",
            "Wooden Club", "Leather Cap", "Villager's Shirt", "Hunting Knife", "Carrot Bunch", "Silver Piece",
            "Rusty Blade", "Cracked Shield", "Simple Tunic", "Traveler's Spear", "Boiled Potato", "Tin Coins",
            "Stone Hammer", "Splintered Helm", "Fieldworker's Hat", "Sling", "Milk Jar", "Copper Bits",
            "Tree Branch", "Torn Hat", "Rough Gloves", "Jagged Rock", "Glass Bottle", "Brass Trinket"
        };

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
            List<string> modifiers = new List<string>
            {
                "of Swiftness", "of Strength", "of Agility", "of Wisdom", "of Fortitude", "of Power",
                "of the Phoenix", "of the Dragon", "of the Great Dragon", "of the Titan", "of the Eagle", "of the Bear", "of the Wolf",
                "of the Lion", "of the Tiger", "of the Serpent", "of the Hawk", "of the Panther", "of the Leopard",
                "of the Fox", "of the Raven", "of the Owl", "of the Griffin", "of the Unicorn", "of the Hydra",
                "of the Kraken", "of the Minotaur", "of the Centaur", "of the Basilisk", "of the Chimera", "of the Cyclops",
                "of the Gorgon", "of the Harpy", "of the Manticore", "of the Pegasus", "of the Sphinx", "of the Wyvern"
            };
            // Determine if a modifier should be added, and make sure it isn't gold
            // if (!weapon.Contains("Coin") && !weapon.Contains("Gold") && !weapon.Contains("Silver") && dice.NextDouble() <= 0.2)
            // {
            //     string modifier = modifiers[dice.Next(0, modifiers.Count)];
            //     weapon += " " + modifier;
            // }

            // Determine if a second modifier should be added, and make sure it isn't gold
            if (!weapon.Contains("Coins") && !weapon.Contains("Gold") && !weapon.Contains("Silver") && !weapon.Contains("Pieces") && dice.NextDouble() <= 0.2)
            {
                string firstModifier = modifiers[dice.Next(0, modifiers.Count)];
                weapon += " " + firstModifier;

                // Determine if a second modifier should be added
                if (dice.NextDouble() <= 0.2)
                {
                    string secondModifier;
                    do
                    {
                        secondModifier = modifiers[dice.Next(0, modifiers.Count)];
                    } while (secondModifier == firstModifier);

                    if (firstModifier.Contains("of the ") && secondModifier.Contains("of the "))
                    {
                        weapon += " " + secondModifier.Replace("of ", "and ");
                    }
                    else if (!firstModifier.Contains("of the ") && !secondModifier.Contains("of the "))
                    {
                        weapon += " " + secondModifier.Replace("of", "and");
                    }
                }
            }

            // Get the color associated with the rarity tier
            var rarityColor = rarityColors.FirstOrDefault(rc => rc.Rarity == rarity).Color;

            // Set the console text color and print the result
           Console.ForegroundColor = rarityColor;
            WriteTextWithDelay($"You Rolled A: [{rarity}] {weapon} at a {roll}% chance!\n", 1);
            Console.ResetColor();
        }

        WriteTextWithDelay("\nPress any key to exit or Enter to restart...\n", 5);
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Main(args);
        }
    }

    static void WriteTextWithDelay(string text, int delay)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            System.Threading.Thread.Sleep(delay);
        }
    }
}
