using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Michael Le and Sijerina Nepal</remarks>
    /// <remarks>Date: 2024/06/11 </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "

            // Create long variable to hold item number

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
            Console.Write("Enter the item number of an appliance: ");
            if (!long.TryParse(Console.ReadLine(), out long itemNumber))
            {
                Console.WriteLine("Invalid item number format.");
                return;
            }
            Appliance foundAppliance = Appliances.FirstOrDefault(a => a.ItemNumber == itemNumber);
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
                return;
            }
            if (foundAppliance.IsAvailable)
            {
                foundAppliance.Checkout();
                Console.WriteLine("Appliance " + itemNumber + " has been checked out.");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            // Create list to hold found Appliance objects

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            Console.Write("Enter brand to search for: ");
            string brand = Console.ReadLine();
            List<Appliance> found = Appliances.Where(a => a.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "

            // Create variable to hold entered number of doors

            // Get user input as string and assign to variable

            // Convert user input from string to int and store as number of doors variable.

            // Create list to hold found Appliance objects

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            Console.Write("Enter number of doors: ");
            int numberOfDoors;
            if (!int.TryParse(Console.ReadLine(), out numberOfDoors))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }
            List<Appliance> found = Appliances
                .Where(a => a is Refrigerator refrigerator && (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors))
                .ToList();
            DisplayAppliancesFromList(found, 0);
        }

        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"

            // Get user input as string and assign to variable

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"

            // Get user input as string
            // Create variable to hold voltage

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            // Create found variable to hold list of found appliances.

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            Console.Write("Enter grade: ");
            string inputGrade = Console.ReadLine();
            string grade;
            switch (inputGrade)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residential";
                    break;
                case "2":
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            Console.Write("Enter voltage: ");
            string inputVoltage = Console.ReadLine();
            int voltage;
            switch (inputVoltage)
            {
                case "0":
                    voltage = 0;
                    break;
                case "1":
                    voltage = 18;
                    break;
                case "2":
                    voltage = 24;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            List<Appliance> found = Appliances
                .Where(a => a is Vacuum vacuum && (grade == "Any" || (vacuum.Grade == grade && (voltage == 0 || vacuum.BatteryVoltage == voltage))))
                .ToList();
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

            // Test input is "0"
                // Assign 'A' to room type variable
            // Test input is "1"
                // Assign 'K' to room type variable
            // Test input is "2"
                // Assign 'W' to room type variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");
            Console.Write("Enter room type: ");
            string input = Console.ReadLine();
            char roomType;
            switch (input)
            {
                case "0":
                    roomType = 'A';
                    break;
                case "1":
                    roomType = 'K';
                    break;
                case "2":
                    roomType = 'W';
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            List<Appliance> found = Appliances
                .Where(a => a is Microwave microwave && (roomType == 'A' || microwave.RoomType == roomType))
                .ToList();
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");
            Console.Write("Enter sound rating: ");
            string input = Console.ReadLine();
            string soundRating;
            switch (input)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }
            List<Appliance> found = Appliances
                .Where(a => a is Dishwasher dishwasher && (soundRating == "Any" || dishwasher.SoundRating == soundRating))
                .ToList();
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");
            Console.Write("Enter type of appliance: ");
            string inputType = Console.ReadLine();
            Console.Write("Enter number of appliances: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }
            List<Appliance> found = Appliances.Where(a =>
            {
                switch (inputType)
                {
                    case "0":
                        return true;
                    case "1":
                        return a is Refrigerator;
                    case "2":
                        return a is Vacuum;
                    case "3":
                        return a is Microwave;
                    case "4":
                        return a is Dishwasher;
                    default:
                        return false;
                }
            }).OrderBy(a => Guid.NewGuid()).Take(num).ToList();
            DisplayAppliancesFromList(found, num);
        }
    }
}
