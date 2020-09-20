using OrderManagement.Concretion;
using System;
using System.Diagnostics;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------Welcome to Order Management System---------------------");
                Console.WriteLine("Please select appropriate options from below to start processing your Order:");
                Console.WriteLine("1 - Processing a Physical Product");
                Console.WriteLine("2 - Processing a Book");
                Console.WriteLine("3 - Processing a Membership");
                Console.WriteLine("4 - Processing a MembershipUpgrade");
                Console.WriteLine("5 - Processing a LearningToSki");

                switch (Console.ReadLine())
                {
                    case "1":
                        ProcessPhysicalProduct();
                        break;
                    case "2":
                        ProcessBook();
                        break;
                    case "3":
                        ProcessMembership();
                        break;
                    case "4":
                        ProcessMembershipUpgrade();
                        break;
                    case "5":
                        ProcessLearningToSki();
                        break;
                    default:
                        break;
                }

                do
                {
                    Console.WriteLine("\nDo you want to continue - Yes or No?");
                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, Please say Yes or No");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }

        public static void ProcessPhysicalProduct()
        {
            ProcessPhysicalProduct processPhysicalProduct = new ProcessPhysicalProduct();
            Commision commision = new Commision();
            Console.WriteLine(processPhysicalProduct.GeneratePackingSlip(true));
            Console.WriteLine(commision.CommisionPayment());
        }

        public static void ProcessBook()
        {
            ProcessBook processBook = new ProcessBook();
            Commision commision = new Commision();
            Console.WriteLine(processBook.CreateDuplicatePackingSlip(true));
            Console.WriteLine(commision.CommisionPayment());
        }

        public static void ProcessMembership()
        {
            ProcessMembership processMembership = new ProcessMembership();
            Console.WriteLine(processMembership.ActivateMembership(true));
            Console.WriteLine(processMembership.EmailOwner(true));
        }

        public static void ProcessMembershipUpgrade()
        {
            MembershipUpgrade processMembershipUpgrade = new MembershipUpgrade();
            Console.WriteLine(processMembershipUpgrade.UpgradeMembership(true));
            Console.WriteLine(processMembershipUpgrade.EmailOwner(true));
        }
        public static void ProcessLearningToSki()
        {
            LearningToSki processLearningToSki = new LearningToSki();
            Console.WriteLine(processLearningToSki.AddFreeFirstAidVideo(true));
        }
    }
}
