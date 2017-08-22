using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using WMPLib;

namespace Vocals {
    [Serializable]
    public class Command {

        public string commandString;
        public List<Actions> actionList;


        public bool answering { get; set; }

        public string answeringString { get; set; }

        public bool answeringSound { get; set; }

        public string answeringSoundPath { get; set; }

        public static WMPLib.WindowsMediaPlayer wplayer { get; set; }

        public static int counter { get; set; } = 0;

        public static Command lastCommand { get; set; }
        public static Command nextCommand { get; set; }

        public Command() {

        }

        public Command(string commandString, List<Actions> actionList) {
            this.commandString = commandString;
            this.actionList = actionList;
            this.answering = false;
            this.answeringString = "";
        }

        public Command(string commandString, List<Actions> actionList, bool answering, string answeringString, bool answeringSound, string answeringSoundPath) {
            this.commandString = commandString;
            this.actionList = actionList;
            this.answering = answering;
            this.answeringString = answeringString;
            if (answeringString == null) {
                answeringString = "";
            }
            this.answeringSound = answeringSound;
            this.answeringSoundPath = answeringSoundPath;
            if(answeringSoundPath == null){
                answeringSoundPath = "";
            }
        }

        ~Command() {

        }

        public override string ToString() {
            string returnString = commandString + " : " + actionList.Count.ToString();
            if (actionList.Count > 1) {
                returnString += " actions";
            }
            else {
                returnString += " action";
            }

            return returnString;
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowThreadProcessId(IntPtr a, IntPtr b);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentThreadId();

        [DllImport("user32.dll")]
        static extern bool AttachThreadInput(IntPtr a, IntPtr b, bool c);

        public static void forceSetForegroundWindow(IntPtr hWnd)
        {
            IntPtr mainThreadId = GetCurrentThreadId();
            IntPtr foregroundThreadID = GetWindowThreadProcessId(GetForegroundWindow(), IntPtr.Zero);
            if (foregroundThreadID != mainThreadId)
            {
                AttachThreadInput(mainThreadId, foregroundThreadID, true);
                SetForegroundWindow(hWnd);
                AttachThreadInput(mainThreadId, foregroundThreadID, false);
            }
            else
                SetForegroundWindow(hWnd);
        }


        public void perform(IntPtr winPointer) {

            IntPtr remember = GetForegroundWindow();

            forceSetForegroundWindow(winPointer);

            System.Threading.Thread.Sleep(300);

            nextCommand = this;
            while (nextCommand != null)
            {
                Command perf = nextCommand;
                nextCommand = null;
                perf.perform();
            }

            if (!hasRepeatAction())
                lastCommand = this;

            System.Threading.Thread.Sleep(300);

            forceSetForegroundWindow(remember);
        }

        public void perform() {
            foreach (Actions a in actionList) {
                a.perform();
            }
            if (answering && answeringString != null) {
                try {
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    string answer = answeringString.Replace("%counter%", Command.counter.ToString());
                    if (synth != null) {
                        synth.SpeakAsync(answer);
                    }
                }
                catch(Exception e){
                    
                }
            }

            if (answeringSound && answeringSoundPath != null) {
                if (answeringSoundPath.IndexOf(".wav") == answeringSoundPath.Length-4) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = answeringSoundPath;
                    player.Play();
                }
                else if (answeringSoundPath.IndexOf(".mp3") == answeringSoundPath.Length - 4) {
                    //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    if (wplayer == null)
                    {
                        wplayer = new WMPLib.WindowsMediaPlayer();
                    }

                    wplayer.URL = answeringSoundPath;
                    wplayer.controls.play();
                }
            }
        }

        private bool hasRepeatAction()
        {
            foreach (Actions a in actionList)
            {
                if (a.type == "Misc" && a.miscOption == "Rep. last command")
                    return true;
            }
            return false;
        }
    }
}
