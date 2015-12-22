using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dafinchi
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Default Form Constructor
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Public method to write messages to the Console Listbox
        /// </summary>
        /// <param name="message">String to be writen to Listbox</param>
        public void WriteLineToConsoleList(string message)
        {
            //  Write message to listbox, move the view to the bottom of the list, then unselect to clear the blue line.
            lstConsole.Items.Add(message);
            lstConsole.SelectedIndex = lstConsole.Items.Count - 1;
            lstConsole.SelectedIndex = -1;
        }
    }
}
