using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace NotamatikProject.App_Classes
{
    class Mp3Player
    {
        static Mp3Player mp3 = new Mp3Player();
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }
        public void play()
        {
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }
        public void stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }



        public static void notaCal(Nota nota,int gecikme)
        {
            mp3.open(nota.yol);
            mp3.play();
            Thread.Sleep(gecikme);
            mp3.stop();
        }
        public static void gamCal(Gam gam, List<int> armoni,List<int> uzunluklar )
        {
            int index = 0;
            int index2 = 0;
            foreach (int item in armoni)
            {
                index += item;
                Mp3Player.notaCal(gam.notaSesleri[index % 14],uzunluklar[index2]);
                index2++;
            }
        }

    }
}
