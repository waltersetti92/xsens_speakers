using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace dll_example_mtw_64
{
    public class Speakers : IDisposable
    {
        private SerialPort sp;
        private string com = "";
        public readonly string comFile;
        public bool isOpened = false;
        public string sound_speaker = " ";
        public string sound_time = "00";
        public static string[] available_speakers = new string[3] { "02", "01", "04" };
        private CancellationTokenSource _canceller;
        public int timer_index = 0;
        ~Speakers()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (sp != null)
                    if (sp.IsOpen)
                    {
                        sp.Close();
                        sp.Dispose();
                    }
            }
            // free native resources
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
