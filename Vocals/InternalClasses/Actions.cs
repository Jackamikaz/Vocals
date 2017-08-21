using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Vocals
{
    [Serializable]
    public class Actions
    {
        public string type;
        public  System.Windows.Forms.Keys keys;
        public float timer;
        public System.Windows.Forms.Keys keyModifier;
        public string mp3option;
        public string miscOption;
        public string mouseOption;
        public int mouseposx;
        public int mouseposy;

        public Actions() {

        }
        public Actions(string type, System.Windows.Forms.Keys keys, System.Windows.Forms.Keys modifier, float timer, string mp3option, string miscOption, string mouseOption, int mouseposx, int mouseposy) {
            // TODO: Complete member initialization
            this.type = type;
            this.keys = keys;
            this.timer = timer;
            this.keyModifier = modifier;
            this.mp3option = mp3option;
            this.miscOption = miscOption;
            this.mouseOption = mouseOption;
            this.mouseposx = mouseposx;
            this.mouseposy = mouseposy;
        }


        public override string ToString() {
            switch (type) {
                case "Key press":
                    return "Key press : " + keys.ToString();
                case "Mouse click":
                    return "Mouse click : " + mouseOption + " at [" + mouseposx + ';' + mouseposy + ']';
                case "Timer":
                    return "Timer : " + timer.ToString() + " secs";
                case "MP3 controls":
                    return "MP3 control : " + mp3option;
                case "Misc":
                    return "Misc : " + miscOption;
                default:
                    return "Error : Unknown event";
            }
        }

        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void perform()
        {
            switch (type) {
                case "Key press":
                    VirtualKeyboard.PressKey(keys, keyModifier);
                    break;
                case "Mouse click":
                    SetCursorPos(mouseposx, mouseposy);
                    switch (mouseOption)
                    {
                        case "Left":
                            mouse_event(MOUSEEVENTF_LEFTDOWN, mouseposx, mouseposy, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, mouseposx, mouseposy, 0, 0);
                            break;
                        case "Right":
                            mouse_event(MOUSEEVENTF_RIGHTDOWN, mouseposx, mouseposy, 0, 0);
                            mouse_event(MOUSEEVENTF_RIGHTUP, mouseposx, mouseposy, 0, 0);
                            break;
                        case "Middle":
                            mouse_event(MOUSEEVENTF_MIDDLEDOWN, mouseposx, mouseposy, 0, 0);
                            mouse_event(MOUSEEVENTF_MIDDLEUP, mouseposx, mouseposy, 0, 0);
                            break;
                    }
                    break;
                case "Timer":
                    System.Threading.Thread.Sleep((int)(timer*1000));
                    break;
                case "MP3 controls":
                    switch (mp3option)
                    {
                        case "Pause":
                            Command.wplayer.controls.pause();
                            break;
                        case "Resume":
                            Command.wplayer.controls.play();
                            break;
                        case "Stop":
                            Command.wplayer.controls.stop();
                            break;
                    }
                    break;
                case "Misc":
                    switch (miscOption)
                    {
                        case "Rep. last command":
                            Command.nextCommand = Command.lastCommand;
                            break;
                        case "Reset counter":
                            Command.counter = 0;
                            break;
                        case "Increase counter":
                            ++Command.counter;
                            break;
                    }
                    break;
            }
        }
    }
}
