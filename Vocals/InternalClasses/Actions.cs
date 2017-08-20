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

        public Actions() {

        }
        public Actions(string type, System.Windows.Forms.Keys keys, System.Windows.Forms.Keys modifier, float timer, string mp3option, string miscOption) {
            // TODO: Complete member initialization
            this.type = type;
            this.keys = keys;
            this.timer = timer;
            this.keyModifier = modifier;
            this.mp3option = mp3option;
            this.miscOption = miscOption;
        }


        public override string ToString() {
            switch (type) {
                case "Key press":
                    return "Key press : " + keys.ToString();
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


        public void perform()
        {
            switch (type) {
                case "Key press":
                    VirtualKeyboard.PressKey(keys, keyModifier);
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
