using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClickTest
{
    public partial class MagicClicker : Form
    {
        Point clickLocation = new Point( 0, 0 );
        Random r = new Random();

        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHTUP = 16;
        const int INPUT_MOUSE = 0;
        const int RECORD_RIGHT_CLICK = 1;
        const int RECORD_LEFT_CLICK = 2;
        const int START_CLICKING = 3;

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        }

        public MagicClicker ()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, RECORD_RIGHT_CLICK, 0, (int)Keys.F6);
            RegisterHotKey(this.Handle, RECORD_LEFT_CLICK, 0, (int)Keys.F5);
            RegisterHotKey(this.Handle, START_CLICKING, 0, (int)Keys.F8);
        }

        // background button actions
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == RECORD_RIGHT_CLICK)
            {
                listMousePoints.Items.Add(string.Format("right;{0};{1};{2}", Cursor.Position.X, Cursor.Position.Y, Convert.ToInt32(numPixelOffput.Value)));
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == RECORD_LEFT_CLICK)
            {
                listMousePoints.Items.Add(string.Format("left;{0};{1};{2}", Cursor.Position.X, Cursor.Position.Y, Convert.ToInt32(numPixelOffput.Value)));
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == START_CLICKING)
            {
                clickSequence();
            }
            base.WndProc(ref m);
        }

        private void clickSequence()
        {
            for (int loop = 0; loop < numLoopCount.Value; loop++)
            {
                foreach (string s in listMousePoints.Items)
                {
                    string[] sArr = s.Split(';');
                    Cursor.Position = new Point(
                        Convert.ToInt32(sArr[1]) + r.Next(-Convert.ToInt32(sArr[3]), Convert.ToInt32(sArr[3])),
                        Convert.ToInt32(sArr[2]) + r.Next(-Convert.ToInt32(sArr[3]), Convert.ToInt32(sArr[3]))
                        );

                    //set up the INPUT struct and fill it for the mouse down
                    INPUT i = new INPUT();
                    i.type = INPUT_MOUSE;
                    i.mi.dx = 0;
                    i.mi.dy = 0;
                    // TODO: change to handle right down as well
                    i.mi.dwFlags = sArr[0] == "left" ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_RIGHTDOWN;
                    i.mi.dwExtraInfo = IntPtr.Zero;
                    i.mi.mouseData = 0;
                    i.mi.time = 0;
                    // send the input 
                    SendInput(1, ref i, Marshal.SizeOf(i));
                    // sleep to simulate holding down the mouse
                    System.Threading.Thread.Sleep(60 + r.Next(-15, 15));
                    //set the INPUT for mouse up and send it
                    // TODO: change to handle right up as well
                    i.mi.dwFlags = sArr[0] == "left" ? MOUSEEVENTF_LEFTUP : MOUSEEVENTF_RIGHTUP;
                    SendInput(1, ref i, Marshal.SizeOf(i));
                    // sleep for designated time
                    System.Threading.Thread.Sleep(Convert.ToInt32(timeClickDelay.Value) + r.Next(0, Convert.ToInt32(timeClickVariance.Value)));
                }
            }
        }
        
        #region List Mouse Points
        private void listMousePoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 'c')
                {
                    listMousePoints.Items.Add(listMousePoints.Items[listMousePoints.SelectedIndex]);
                }
                else if (e.KeyChar == 'd')
                {
                    for (int i = listMousePoints.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        listMousePoints.Items.RemoveAt(listMousePoints.SelectedIndices[i]);
                    }
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region Menu List Actions
        private void saveScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Magic Clicker Script|*.mcs";
            saveDialog.Title = "Select a script";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                Scripting.Scripting.SaveScript(saveDialog.FileName, listMousePoints, txtScriptNotes, timeClickDelay, timeClickVariance, numPixelOffput, numLoopCount);
            }
        }
        private void loadScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadDialog = new OpenFileDialog();
            loadDialog.Filter = "Magic Clicker Script|*.mcs";
            loadDialog.Title = "Select script to load";
            loadDialog.ShowDialog();

            if (loadDialog.FileName != "")
            {
                Scripting.Scripting.LoadScript(loadDialog.FileName, listMousePoints, txtScriptNotes, timeClickDelay, timeClickVariance, numPixelOffput, numLoopCount);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region DLL Import Functions
        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion        
    }
}
