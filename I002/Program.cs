﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I002
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>\
        public static BuyProduct DialogProduct;
        public static SellProductForm DialogCounteragent;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}