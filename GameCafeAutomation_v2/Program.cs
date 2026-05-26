using GameCafeAutomation_v2;
using System;
using System.Windows.Forms;

namespace GameCafeAutomation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}