using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMachine_WindowsForm
{
    public enum PaymentType
    {
        Coins,
        Card
    }
    public enum BuyGoodParameter
    {
        Id = 0,
        Count = 1
    }
    public class Vending
    {
        public static int[] getChange = { 1, 2, 5, 10 };

        public static int balance = 0;
        public static int[] coinsQuantity = { 0, 0, 0, 0 };
        public static int[] coinsValue = { 1, 2, 5, 10 };

        public static PaymentType payment = PaymentType.Card;

        public static string[] names = { "Chocolate", "Soda" };
        public static int[] prices = { 50, 70 };
        public static int[] availableQuantity = { 10, 15 };

        /// <summary>
        /// Converts string to int if this is posible 
        /// </summary>
        /// <returns></returns>
        private static int Readint()
        {
            int result = 0;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("not a number");
            }
            return result;
        }
        /// <summary>
        /// return name of product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string GetName(int id)
        {
            Validate(id);
            return names[id];
        }
        /// <summary>
        /// Check if product name is in stock
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static bool Exist(int id)
        {
            return id >= 0 && id < names.Length;
        }
        /// <summary>
        /// Check if all nessasary terms is done to buy product
        /// </summary>
        /// <param name="command"></param>
        private static void ExecuteCommand(string command)
        {
            if (command == "Add money")
            {
                switch (payment)
                {
                    case PaymentType.Coins:
                        for (int i = 0; i < coinsValue.Length; i++)
                        {
                            Console.WriteLine($"{coinsValue[i]}");
                            int count = 0;
                            while (!int.TryParse(Console.ReadLine(), out count))
                            {
                                Console.WriteLine("not a number");
                            }
                            coinsQuantity[i] += count;
                            balance += count * coinsValue[i];
                        }
                        break;
                    case PaymentType.Card:
                        Console.WriteLine("How many money you want to take?");
                        int balanceDelta = 0;
                        while (!int.TryParse(Console.ReadLine(), out balanceDelta))
                        {
                            Console.WriteLine("not a number");
                        }
                        balance += balanceDelta;
                        Console.WriteLine("Thank you for buying");
                        break;
                    default:
                        break;
                }
            }
            else if (command == "Get change")
            {
                balance = 0;
            }
            else if (command.StartsWith("BuyGood"))
            {
                string[] rowData = command.Substring("BuyGood".Length).Split(' ');
                if (rowData.Length != 2)
                {
                    Console.WriteLine("Wrong command argument");
                    return;
                }
                int id = 0;
                if (!MapParametr(rowData, out id, BuyGoodParameter.Id))
                {
                    return;
                }
                int count = 0;
                if (!MapParametr(rowData, out id, BuyGoodParameter.Count))
                {
                    Console.WriteLine("There are not enough products");
                    return;
                }
                if (Exist(id))
                {
                    Console.WriteLine("There is no this type of product");
                    return;
                }
                if (IsAvailableQuantity(id, count))
                {
                    Console.WriteLine("Not enough products");
                    return;
                }
                int totalPrice = GetTotalPrice(prices[id], count);
                if (balance >= totalPrice)
                {
                    balance -= totalPrice;
                    availableQuantity[id] -= count;
                }
            }
        }
        /// <summary>
        /// Check if id is not out of range
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static string Validate(int id)
        {
            if (!Exist(id))
            {
                throw new ArgumentOutOfRangeException("id");
            }
            else
            {
                return "OK";
            }
        }
        /// <summary>
        /// Give price
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static int GetPrice(int id)
        {
            Validate(id);
            return prices[id];
        }
        /// <summary>
        /// Check if count of products have in stocks
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static int GetAvailableQuantity(int id)
        {
            Validate(id);
            return availableQuantity[id];
        }
        /// <summary>
        /// Read command for method ExecuteCommand
        /// </summary>
        /// <returns></returns>
        private static string ReadCommand()
        {
            Console.WriteLine("Enter the command");
            return Console.ReadLine();
        }
        /// <summary>
        /// Give total price
        /// </summary>
        /// <param name="price"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private static int GetTotalPrice(int price, int count)
        {
            if (price < 0 || count < 0)
            {
                return 0;
            }
            return price * count;
        }
        /// <summary>
        /// Check if quantity is available
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private static bool IsAvailableQuantity(int id, int count)
        {
            return Exist(id) && (count >= 0 && count < GetAvailableQuantity(id));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowParams"></param>
        /// <param name="container"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private static bool MapParametr(string[] rowParams, out int container, BuyGoodParameter parameter)
        {
            int index = (int)parameter;
            string name = Enum.GetName(typeof(BuyGoodParameter), parameter);
            if (!int.TryParse(rowParams[index], out container))
            {
                return false;
            }
            return true;
        }
        static void Main()
        {
            string comand = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Balance = {balance}");

                string command = ReadCommand();
                ExecuteCommand(command);

                Console.ReadKey();
            }
        }
    }
}
