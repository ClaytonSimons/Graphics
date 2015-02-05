/*
 * Assignment: Graphics Quaternion Lab3 
 * Class: Graphics
 * Date: 1/31/15
 * Description: Shows the functionality of a quaternion class.  This allows the user to enter quaternion or scalar values, and 
 *  perform operations like quaternion addition, multiplication, rotation about an arbitrary axis, etc...
 * 
 * Author: Clayton Simons
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsQuaternionLab3
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
