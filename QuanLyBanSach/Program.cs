﻿using System;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Quản_lý.frmThongTin_Sach());
        }
    }
}