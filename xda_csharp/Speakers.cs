﻿using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Threading.Tasks;

namespace MTwExample
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

        public Speakers()
        {
            comFile = Form1.resourcesPath + "\\com.txt";
            string[] ports = getAvailableComs();

            com = getSavedCom();
            // MessageBox.Show(com);

            if (com.Length > 0)
                if (Array.IndexOf(ports, com) > -1)

                    if (openPort(com) != null)
                        isOpened = true;
        }
        static public string[] getAvailableComs()
        {
            return SerialPort.GetPortNames();

        }
        private string getSavedCom()
        {
            if (File.Exists(comFile) is true) return File.ReadAllText(comFile);
            else return "";
        }
         public async void stopspeaker()
        {
            _canceller.Cancel();
        }
        public Speakers openPort(string c)
        {
            try
            {
                sp = new System.IO.Ports.SerialPort(c, 250000, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

                sp.Open();
                com = c;

                return this;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                com = "";
                return null;
            }
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }
        private static byte[] hexstr2ByteArray(string str)
        {
            string[] hexValuesSplit = str.Split(' ');

            byte[] arr = new byte[hexValuesSplit.Length];

            int cnt = 0;
            foreach (String hex in hexValuesSplit)
            {
                arr[cnt] = Convert.ToByte(hex, 16);
                cnt++;
            }
            return arr; //return str.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
        }
        public bool reinitSpeakers(bool test = true)
        {
            if (sp.IsOpen is false)
                return false;
            //return true;


            string str;
            byte[] bytes;
            foreach (string speaker in available_speakers)
            {
                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

            }
            if (test)
            {
                foreach (string speaker in available_speakers)
                {
                    //startSpeaker(speaker);
                    //Thread.Sleep(2000);
                }
            }
            return true;
        }


        public async void startSpeaker(string speaker, string sound_speaker, int condition)
        {
            // if (sp == null)
            // return false;
            // if (sp.IsOpen is false)
            //  return false;

            string str, arr1, indata;
            int length_response;
            byte[] bytes;
            int dataLength = 0;
            if (condition == 1)
                str = "F5 02 " + speaker + " 21 " + sound_speaker + "05 04 F0";
            else
                str = "F5 02 FF 21 " + sound_speaker + "05 04 F0";
            bytes = hexstr2ByteArray(str);
            arr1 = "";
            indata = "";
            timer_index = 0;
            _canceller = new CancellationTokenSource();
            await Task.Run(() =>
            {
                if (sp != null)
                {
                    do
                    {
                        sp.Write(bytes, 0, bytes.Length);
                        Thread.Sleep(300);
                        timer_index++;
                        if (_canceller.Token.IsCancellationRequested)
                            break;
                    } while (true);
                }
            });
        }
        public async void startSpeaker_all2(string sound_speaker)
        {
            // if (sp == null)
            // return false;
            // if (sp.IsOpen is false)
            //  return false;

            string str1, str2, str3;
            int length_response;
            byte[] bytes1, bytes2, bytes3;
            int dataLength = 0;
            str1 = "F5 02 01 21 " + sound_speaker + "05 04 F0";
            bytes1 = hexstr2ByteArray(str1);
            str2 = "F5 02 02 21 " + sound_speaker + "05 04 F0";
            bytes2 = hexstr2ByteArray(str2);
            str3 = "F5 02 04 21 " + sound_speaker + "05 04 F0";
            bytes3 = hexstr2ByteArray(str3);
            timer_index = 0;
            _canceller = new CancellationTokenSource();
            await Task.Run(() =>
            {
                do
                {
                    sp.Write(bytes1, 0, bytes1.Length);
                    Thread.Sleep(300);
                    sp.Write(bytes2, 0, bytes2.Length);
                    Thread.Sleep(300);
                    sp.Write(bytes3, 0, bytes3.Length);
                    Thread.Sleep(300);
                    timer_index++;
                    if (_canceller.Token.IsCancellationRequested)
                        break;
                } while (true);
            });
        }

        public async void startSpeaker_all2(string[] sound_speakers)
        {
            // if (sp == null)
            // return false;
            // if (sp.IsOpen is false)
            //  return false;
            if (sound_speakers.Length != 3)
                throw new IndexOutOfRangeException("mandatory three values");

            string str1, str2, str3;
            int length_response;
            byte[] bytes1, bytes2, bytes3;
            int dataLength = 0;
            str1 = "F5 02 01 21 " + sound_speaker[0] + "05 04 F0";
            bytes1 = hexstr2ByteArray(str1);
            str2 = "F5 02 02 21 " + sound_speaker[1] + "05 04 F0";
            bytes2 = hexstr2ByteArray(str2);
            str3 = "F5 02 04 21 " + sound_speaker[2] + "05 04 F0";
            bytes3 = hexstr2ByteArray(str3);
            timer_index = 0;
            _canceller = new CancellationTokenSource();
            await Task.Run(() =>
            {
                do
                {
                    sp.Write(bytes1, 0, bytes1.Length);
                    Thread.Sleep(300);
                    sp.Write(bytes2, 0, bytes2.Length);
                    Thread.Sleep(300);
                    sp.Write(bytes3, 0, bytes3.Length);
                    Thread.Sleep(300);
                    timer_index++;
                    if (_canceller.Token.IsCancellationRequested)
                        break;
                } while (true);
            });
        }
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
