using System.Runtime.InteropServices;

namespace ClickForPid
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        private void SetPID(string val)
        {
            pidDisplay.Text = "PID is "+ val;
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        private void button_Click(object sender, EventArgs e)
        {
            SetPID("...");
            this.button.LostFocus += Button_LostFocus;
        }

        private void Button_LostFocus(object? sender, EventArgs e)
        {
            Thread.Sleep(10);
            var ptr=GetForegroundWindow();
            if(ptr == IntPtr.Zero)
            {
                SetPID("unable to be determined");
            }
            else
            {
                GetWindowThreadProcessId(ptr, out uint lpdwProcessId);
                SetPID("" + lpdwProcessId);
            }
            this.button.LostFocus -= Button_LostFocus;
        }
    }
}