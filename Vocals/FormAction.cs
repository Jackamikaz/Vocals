using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Vocals {
    public partial class FormAction : Form {
        Keys[] keyDataSource;

        public float selectedTimer { get; set; }

        public Keys selectedKey { get; set; }

        public string selectedType { get; set; }

        public string selectedMP3control { get; set; }

        public string selectedMisc
        {
            get
            {
                return (string)comboBox_misc.SelectedItem;
            }
        }

        public string selectedMouse
        {
            get
            {
                return (string)comboBox_mouse.SelectedItem;
            }
        }

        public int mouseposx { get { return (int)xpos.Value; } }

        public int mouseposy { get { return (int)ypos.Value; } }

        public Keys modifier { get; set; }
        
        private void Init()
        {
            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAction_KeyDown);

            keyDataSource = (Keys[])Enum.GetValues(typeof(Keys)).Cast<Keys>();

            comboBox2.DataSource = keyDataSource;

            comboBox1.DataSource = new string[] { "Key press", "Mouse click", "Timer", "MP3 controls", "Misc" };
            comboBox_mp3opt.DataSource = new string[] { "Pause", "Resume", "Stop" };
            comboBox_misc.DataSource = new string[] { "None", "Rep. last command", "Reset counter", "Increase counter" };
            comboBox_mouse.DataSource = new string[] { "Left", "Right", "Middle" };

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 0.1M;
        }

        public FormAction() {
            Init();            
        }

        public FormAction(Actions a) {
            Init();

            comboBox2.SelectedItem = a.keys;
            numericUpDown1.Value = Convert.ToDecimal(a.timer);
            comboBox1.SelectedItem = a.type;
            comboBox_mp3opt.SelectedItem = a.mp3option;
            comboBox_misc.SelectedItem = a.miscOption;
            comboBox_mouse.SelectedItem = a.mouseOption;
            xpos.Value = a.mouseposx;
            ypos.Value = a.mouseposy;

            switch (a.keyModifier) {
                case Keys.ControlKey:
                    checkBox1.Checked = true;
                    break;
                case Keys.ShiftKey:
                    checkBox2.Checked = true;
                    break;
                case Keys.Alt:
                    checkBox3.Checked = true;
                    break;
                default :
                    break;
            }
        }

        private void FormAction_Load(object sender, System.EventArgs e) {
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            selectedType = (string)comboBox1.SelectedItem;
            switch (selectedType) {
                case "Key press" :
                    numericUpDown1.Enabled = false;
                    comboBox2.Enabled = true;
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    comboBox_mp3opt.Enabled = false;
                    comboBox_misc.Enabled = false;
                    comboBox_mouse.Enabled = false;
                    xpos.Enabled = false;
                    ypos.Enabled = false;
                    break;
                case "Mouse click":
                    numericUpDown1.Enabled = false;
                    comboBox2.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    comboBox_mp3opt.Enabled = false;
                    comboBox_misc.Enabled = false;
                    comboBox_mouse.Enabled = true;
                    xpos.Enabled = true;
                    ypos.Enabled = true;
                    break;
                case "Timer":
                    numericUpDown1.Enabled = true;
                    comboBox2.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    comboBox_mp3opt.Enabled = false;
                    comboBox_misc.Enabled = false;
                    comboBox_mouse.Enabled = false;
                    xpos.Enabled = false;
                    ypos.Enabled = false;
                    break;
                case "MP3 controls":
                    numericUpDown1.Enabled = false;
                    comboBox2.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    comboBox_mp3opt.Enabled = true;
                    comboBox_misc.Enabled = false;
                    comboBox_mouse.Enabled = false;
                    xpos.Enabled = false;
                    ypos.Enabled = false;
                    break;
                case "Misc":
                    numericUpDown1.Enabled = false;
                    comboBox2.Enabled = false;
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    comboBox_mp3opt.Enabled = false;
                    comboBox_misc.Enabled = true;
                    comboBox_mouse.Enabled = false;
                    xpos.Enabled = false;
                    ypos.Enabled = false;
                    break;
                default :
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            selectedTimer = (float)numericUpDown1.Value;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            selectedKey = (Keys)comboBox2.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            selectedType = "";
            selectedTimer = 0;
            selectedKey = Keys.None;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked) {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                modifier = Keys.ControlKey;
            }
            else {
                modifier = Keys.None;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2.Checked) {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                modifier = Keys.ShiftKey;
            }
            else {
                modifier = Keys.None;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            if (checkBox3.Checked) {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                modifier = Keys.Alt;
            }
            else {
                modifier = Keys.None;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_mp3opt_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMP3control = (string)comboBox_mp3opt.SelectedItem;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Struct representing a point.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);


        private void FormAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                POINT lpPoint;
                GetCursorPos(out lpPoint);
                
                xpos.Value = lpPoint.X;
                ypos.Value = lpPoint.Y;
            }
        }
    }
}
