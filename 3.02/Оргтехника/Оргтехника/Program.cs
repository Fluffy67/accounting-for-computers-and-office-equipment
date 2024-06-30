using System;
using System.Windows.Forms;

namespace Оргтехника
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Beginning());
        }
      
    }
    static class DB
    {
        public static string connectionString = @"Data Source=OficeEqipment.db;Integrated Security=False; MultipleActiveResultSets=True";

    }
    static class Inputs_table
    {
        public static string main = "Inputs";
        public static string Id = "Id";
        public static string Email = "Email";
        public static string Password = "Password";
    }
    static class Tables_table
    {
        public static string main = "Tables";
        public static string Id = "Id";
        public static string Code = "Code";
        public static string Name = "Name";
        public static string DateJfPurchase = "DateJfPurchase";
        public static string NumberOfEquipment = "NumberOfEquipment";
        public static string EquipmentNumber = "EquipmentNumber";
    }
}
