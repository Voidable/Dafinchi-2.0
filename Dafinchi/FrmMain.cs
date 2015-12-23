using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinchAPI;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Dafinchi
{
    public partial class FrmMain : Form
    {
        private Finch _dafinchi;

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

        /// <summary>
        /// Method to connect to Finch
        /// </summary>
        public void ConnectToFinch()
        {
            WriteLineToConsoleList("Connecting to Finch...");
            _dafinchi = new Finch();

            if (_dafinchi.connect())
            {
                WriteLineToConsoleList("Connected.");
            }
            else
            {
                WriteLineToConsoleList("Something bad happened. Unable to Connect to Finch");
            }

        }

        /// <summary>
        /// Method to verify controller is connected.
        /// </summary>
        public bool VerifyControllerConnection()
        {
            WriteLineToConsoleList("Checking for controller...");

            if (GamePad.GetState(PlayerIndex.One).IsConnected)
            {
                WriteLineToConsoleList("Controller found.");
                return true;
            }
            else
            {
                WriteLineToConsoleList("Unable to detect controller.");
                return false;
            }
        }

        /// <summary>
        /// Method that gets right thumbstick position and returns as a StickPoint.
        /// </summary>
        /// <returns></returns>
        public StickPoint GetRightStickPosition()
        {
            StickPoint point = new StickPoint();
            point.X = GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.X;
            point.Y = GamePad.GetState(PlayerIndex.One).ThumbSticks.Right.Y;
            return point;
        }

        public void MotorSpeedCalc(double x, double y, out int L, out int R)
        {
            int maxSpeed = byte.MaxValue;

            int forwardSpeed;

            // Forward speed, (Y-Axis) can be half of the max speed.
            forwardSpeed = (int)(y * maxSpeed) / 2;

            // Positive X means turn right
            if (x > 0)
            {
                L = forwardSpeed + (int)(Math.Abs(x * maxSpeed) / 2);
                R = forwardSpeed;
            }
            else if (x < 0)
            {
                R = forwardSpeed + (int)(Math.Abs(x * maxSpeed) / 2);
                L = forwardSpeed;
            }
            else
            {
                L = forwardSpeed;
                R = forwardSpeed;
            }

        }

        public void DriveFinch()
        {
            StickPoint point = GetRightStickPosition();

            int left, right;

            MotorSpeedCalc(point.X, point.Y, out left, out right);

            txbX.Text = point.X.ToString();
            txbY.Text = point.Y.ToString();

            txbLeft.Text = left.ToString();
            txbRight.Text = right.ToString();

            _dafinchi.setMotors(left, right);
        }

        public void ApplicationLogic()
        {
            ConnectToFinch();

            if (!VerifyControllerConnection())
            {
                return;
            }

            else
            {
                WriteLineToConsoleList("Everything seems all set, starting update loop.");
                tmrUpdate.Enabled = true;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ApplicationLogic();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            DriveFinch();
        }
    }
}
