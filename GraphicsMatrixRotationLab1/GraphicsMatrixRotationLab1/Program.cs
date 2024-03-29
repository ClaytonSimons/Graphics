﻿/*
 *Project: Matrix4 class example
 *Assignment: Lab2
 *Author: Clayton Simons
 *Last Modification: 1/20/15
 *Description: Allows the user to use the different functions of the Matrix4 class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsMatrixRotationLab1
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
            Application.Run(new Form1());
        }
    }
}
