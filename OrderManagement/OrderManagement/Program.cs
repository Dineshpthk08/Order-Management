using OrderManagement.Concretion;
using System;
using System.Diagnostics;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
            Console.ReadLine();
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------Welcome to Order Management System---------------------");
            Console.WriteLine("Please select appropriate options from below to start processing your Order:");
            Console.WriteLine("1 - Processing a Physical Product");
            Console.WriteLine("2 - Processing a Book");
            Console.WriteLine("3 - Processing a Membership");
            Console.WriteLine("4 - Processing a MembershipUpgrade");
            Console.WriteLine("5 - Processing a LearningToSki");
            Console.WriteLine("6 - Exit Application");

            switch (Console.ReadLine())
            {
                case "1":
                    ProcessPhysicalProduct();
                    return false;
                case "2":
                    ProcessBook();
                    return false;
                case "3":
                    ProcessMembership();
                    return false;
                case "4":
                    ProcessMembershipUpgrade();
                    return false;
                case "5":
                    ProcessLearningToSki();
                    return false;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        public static void ProcessPhysicalProduct()
        {
            ProcessPhysicalProduct processPhysicalProduct = new ProcessPhysicalProduct();
            Console.WriteLine(processPhysicalProduct.GeneratePackingSlip(true));
        }

        public static void ProcessBook()
        {
            ProcessBook processBook = new ProcessBook();
            Console.WriteLine(processBook.CreateDuplicatePackingSlip(true));
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
