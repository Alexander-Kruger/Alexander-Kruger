using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2_Attempt
{
    internal class Program
    {


        // Object to manage transactions

        static TransactionManager Manager = new TransactionManager();


        static void Main(string[] args)
        {
            // Amount of People added -----------------------
            Console.WriteLine("==================================");
            Console.WriteLine(" Please Enter amount of students ");
            Console.WriteLine("        Living together ");
            Console.WriteLine("==================================");
            int iAmountOfRoomates = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < iAmountOfRoomates + 1; i++)
            {
                Console.WriteLine("Please Enter Name of Student : " + i);
                string sName = Console.ReadLine();
                Student student = new Student { Index = (i), StudentName = sName, TotalContrubution = 0 };
                Manager.AddStudent(student);
            }




            // Main Menu ------------------------------------ 
            bool bExit = false;

            do
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("      BUDGET TRACKER SYSTEM");
                Console.WriteLine("==================================");
                Console.WriteLine("1 : Add Income");
                Console.WriteLine("2 : Add Expense");
                Console.WriteLine("3 : Show Transactions");
                Console.WriteLine("4 : Generate Summary");
                Console.WriteLine("5 : Exit");
                Console.WriteLine("==================================");
                Console.Write("Please choose an option: ");

                int iOption;

                // Prevent crashes from wrong input
                if (!int.TryParse(Console.ReadLine(), out iOption))
                {
                    Console.WriteLine("Invalid input. Press any key...");
                    Console.ReadKey();
                    continue;
                }


                switch (iOption)
                {
                    case 1:
                        AddIncome();
                        break;

                    case 2:
                        AddExpense();
                        break;

                    case 3:
                        ShowTransactionHistory();
                        break;

                    case 4:
                        GenerateReport();
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program...");
                        bExit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                if (!bExit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }


            } while (!bExit);
        }

        // ===========================
        // ADD INCOME
        // ===========================
        static void AddIncome()
        {
            Console.Clear();
            Console.WriteLine("ADD INCOME");

            Console.Write("Enter income description: ");
            string description = Console.ReadLine();

            Console.Write("Enter amount: ");
            double amount;

            while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("Invalid amount. Enter again: ");
            }

            string sChosen = Manager.DisplayStudentMenuAndReturnIndex(false);

            Transaction TempTransaction = new Transaction
            {
                Type = "Income",
                Category = "Income",
                PersonInCharge = sChosen,
                Description = description,
                Amount = amount
            };

            Manager.AddTransaction(TempTransaction);

            Console.WriteLine("Income added successfully!");
        }

        //=============================
        //         ADD EXPENSE
        //=============================


        //Method
        static void AddExpense()
        {
            Console.Clear();
            Console.WriteLine("ADD EXPENSE");

            Console.Write("Enter Expense Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter ammount: ");
            double amount;

            while (!double.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.Write("Invalid amount. Enter again: ");
            }

            string sChosen = Manager.DisplayStudentMenuAndReturnIndex(true);

            //List

            Console.WriteLine("\nSelect Expense Category");
            Console.WriteLine("1. Rent");
            Console.WriteLine("2. Groceries");
            Console.WriteLine("3. Utilities");
            Console.WriteLine("4. Entertainment");
            Console.WriteLine("5. Transport");
            Console.WriteLine("6. Other");

            Console.Write("Choose category: ");
            int categoryChoice;

            while (!int.TryParse(Console.ReadLine(), out categoryChoice)
                   || categoryChoice < 1
                   || categoryChoice > 6)
            {
                Console.Write("Invalid choice. Enter again: ");
            }

            string category = "";

            //Switch

            switch (categoryChoice)
            {
                case 1:
                    category = "Rent";
                    break;

                case 2:
                    category = "Groceries";
                    break;

                case 3:
                    category = "Utilities";
                    break;

                case 4:
                    category = "Entertainment";
                    break;

                case 5:
                    category = "Transport";
                    break;

                case 6:
                    category = "Other";
                    break;
            }

            Transaction TempTransaction = new Transaction
            {
                Type = "Expense",
                Category = category,
                PersonInCharge = sChosen,
                Description = description,
                Amount = amount
            };

            Manager.AddTransaction(TempTransaction);

            Console.WriteLine("Expense added successfully!");

        }

        // ===========================
        // SHOW TRANSACTIONS
        // ===========================
        static void ShowTransactionHistory()
        {
            Console.Clear();
            Console.WriteLine("TRANSACTION HISTORY");

            Manager.DisplayAll_Transactions();
        }

        // ===========================
        // GENERATE SUMMARY
        // ===========================
        static void GenerateReport()
        {
            Console.Clear();
            Console.WriteLine("SUMMARY REPORT");

            double totalIncome = Manager.CalcTotalIncome();
            double totalExpenses = Manager.CalcTotalExpenses();

            double groceries = Manager.GetTotalByCategory("Groceries");
            double rent = Manager.GetTotalByCategory("Rent");
            double utilities = Manager.GetTotalByCategory("Utilities");
            double transport = Manager.GetTotalByCategory("Transport");
            double entertainment = Manager.GetTotalByCategory("Entertainment");
            double other = Manager.GetTotalByCategory("Other");

            double balance = totalIncome - totalExpenses;

            Console.WriteLine("\n===== MONTHLY REPORT =====\n");

            Console.WriteLine("Total Income\t: R " +
                totalIncome.ToString("F2"));

            Console.WriteLine("Total Expenses\t: R " +
                totalExpenses.ToString("F2"));

            Console.WriteLine("Balance\t\t: R " +
                balance.ToString("F2"));

            Console.WriteLine("\n==== CATEGORY SUMMARY ====\n");

            Console.WriteLine("Rent\t\t: R " +
                rent.ToString("F2"));

            Console.WriteLine("Groceries\t: R " +
                groceries.ToString("F2"));

            Console.WriteLine("Utilities\t: R " +
                utilities.ToString("F2"));

            Console.WriteLine("Entertainment\t: R " +
                entertainment.ToString("F2"));

            Console.WriteLine("Transport\t: R " +
                transport.ToString("F2"));

            Console.WriteLine("Other\t\t: R " +
               other.ToString("F2"));


            Console.WriteLine("==========================");
            Console.WriteLine("\n== DEBT OWED PER STUDENT ==\n");
            Manager.DisplayIndividualDebt();

        }
    }

    // ===========================
    // TRANSACTION CLASS
    // ===========================
    class Transaction
    {
        public string Type { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public string PersonInCharge { get; set; }
    }

    class Student
    {
        public int Index { get; set; }
        public string StudentName { get; set; }
        public double TotalContrubution { get; set; }
    }


    class TransactionManager
    {

        private List<Transaction> transactions = new List<Transaction>();

        private List<Student> Students = new List<Student>();

        public string DisplayStudentMenuAndReturnIndex(bool isExpense)
        {
            Console.WriteLine("\nPlease Choose The number of the Student who made this transaction");
            if (isExpense) { Console.WriteLine("If the expense hasnt been paid yet, please enter '0' "); }

            foreach (Student s in Students)
            {
                Console.WriteLine($"{s.Index} : {s.StudentName}");
            }

            int IndexChosen;
            while (!int.TryParse(Console.ReadLine(), out IndexChosen)
                || IndexChosen < 0
                || IndexChosen > Students.Count)
            {
                Console.Write("Invalid choice. Enter again: ");
            }

            if (IndexChosen == 0)
            {
                return "To be determined";
            }
            else
            {

                foreach (Student s in Students)
                {
                    if (s.Index == IndexChosen)
                    {
                        return s.StudentName;
                    }
                }

                return ""; // Fallback return to satisfy the compiler
            }
        }

        public void AddTransaction(Transaction t)
        {
            transactions.Add(t);
            foreach (Student s in Students)
            {


                if (s.StudentName == t.PersonInCharge)
                {
                    s.TotalContrubution += t.Amount;
                    break;

                }

            }

        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        public void DisplayAll_Transactions()
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions found.");
            }

            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Type: " + transaction.Type);
                Console.WriteLine("Category: " + transaction.Category);
                Console.WriteLine("Description: " + transaction.Description);
                Console.WriteLine("Amount: R" + transaction.Amount);
                Console.WriteLine("Person Responsible: " + transaction.PersonInCharge);
            }
        }

        public double CalcTotalIncome()
        {
            double totalIncome = 0;
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Category == "Income")
                {
                    totalIncome += transaction.Amount;
                }
            }
            return totalIncome;
        }
        public double GetTotalByCategory(string categoryName)
        {
            double total = 0;
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Category == categoryName)
                {
                    total += transaction.Amount;
                }
            }
            return total;
        }

        public double CalcTotalExpenses()
        {
            double totalExpenses = 0;
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Category != "Income")
                {
                    totalExpenses += transaction.Amount;
                }
            }
            return totalExpenses;
        }

        public void DisplayIndividualDebt()
        {
            double totalExpenses = CalcTotalExpenses();

            double fairShare = totalExpenses / Students.Count;

            Console.WriteLine($"\nFair Share per person: R {fairShare:F2}");

            foreach (Student s in Students)
            {
                double status = fairShare - s.TotalContrubution;

                if (status > 0)
                    Console.WriteLine($"{s.StudentName} owes: R {status:F2}");
                else if (status < 0)
                    Console.WriteLine($"{s.StudentName} is owed: R {Math.Abs((status)):F2}");
                else
                    Console.WriteLine($"{s.StudentName} is settled.");
            }
        }




    }


}