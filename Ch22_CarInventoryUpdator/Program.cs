using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace Ch22_CarInventoryUpdator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Car Inventory Updater ******");
            bool userDone = false;
            string userCommand = "";
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "uid=sa;pwd=123456;Initial Catalog=Cars;" +
                @"Data Source=SE140716;Connect Timeout=30";
            cn.Open();
            showInstructions();

            #region Get User Command
            do
            {
                Console.Write("please enter your command: ");
                userCommand = Console.ReadLine();
                Console.WriteLine();
                switch(userCommand)
                {
                    case "I":

                        break;
                    case "U":
                        break;
                    case "D":
                        break;
                    case "L":
                        break;
                    case "S":
                        break;
                    case "P":
                        break;
                }
            }
        }
        #region ShowInstructions method
        private static void showInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("I: Insert a new car");
            Console.WriteLine("U: Update an existing car.");
            Console.WriteLine("D: Delete an existing car.");
            Console.WriteLine("L: List current inventory.");
            Console.WriteLine("S: Show these instructions.");
            Console.WriteLine("P: Look up pet name for existing car");
            Console.WriteLine("Q: Quit program");
        }
        #endregion
    }
}
