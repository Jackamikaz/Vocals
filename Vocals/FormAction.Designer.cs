namespace Vocals {
    partial class FormAction {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label_mp3opt = new System.Windows.Forms.Label();
            this.comboBox_mp3opt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_misc = new System.Windows.Forms.ComboBox();
            this.mouselbl = new System.Windows.Forms.Label();
            this.comboBox_mouse = new System.Windows.Forms.ComboBox();
            this.xpos = new System.Windows.Forms.NumericUpDown();
            this.xposlbl = new System.Windows.Forms.Label();
            this.ypos = new System.Windows.Forms.NumericUpDown();
            this.yposlbl = new System.Windows.Forms.Label();
            this.label_setposinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ypos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.CausesValidation = false;
            this.numericUpDown1.Location = new System.Drawing.Point(126, 238);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Timer (Secs)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(132, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ctrl";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(132, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Shift";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(132, 113);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(38, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Alt";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label_mp3opt
            // 
            this.label_mp3opt.AutoSize = true;
            this.label_mp3opt.Location = new System.Drawing.Point(38, 267);
            this.label_mp3opt.Name = "label_mp3opt";
            this.label_mp3opt.Size = new System.Drawing.Size(69, 13);
            this.label_mp3opt.TabIndex = 10;
            this.label_mp3opt.Text = "MP3 controls";
            this.label_mp3opt.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox_mp3opt
            // 
            this.comboBox_mp3opt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mp3opt.FormattingEnabled = true;
            this.comboBox_mp3opt.Location = new System.Drawing.Point(126, 264);
            this.comboBox_mp3opt.Name = "comboBox_mp3opt";
            this.comboBox_mp3opt.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mp3opt.TabIndex = 11;
            this.comboBox_mp3opt.SelectedIndexChanged += new System.EventHandler(this.comboBox_mp3opt_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Misc.";
            // 
            // comboBox_misc
            // 
            this.comboBox_misc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_misc.FormattingEnabled = true;
            this.comboBox_misc.Location = new System.Drawing.Point(126, 291);
            this.comboBox_misc.Name = "comboBox_misc";
            this.comboBox_misc.Size = new System.Drawing.Size(121, 21);
            this.comboBox_misc.TabIndex = 13;
            // 
            // mouselbl
            // 
            this.mouselbl.AutoSize = true;
            this.mouselbl.Location = new System.Drawing.Point(68, 139);
            this.mouselbl.Name = "mouselbl";
            this.mouselbl.Size = new System.Drawing.Size(39, 13);
            this.mouselbl.TabIndex = 14;
            this.mouselbl.Text = "Mouse";
            this.mouselbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox_mouse
            // 
            this.comboBox_mouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mouse.FormattingEnabled = true;
            this.comboBox_mouse.Location = new System.Drawing.Point(126, 136);
            this.comboBox_mouse.Name = "comboBox_mouse";
            this.comboBox_mouse.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mouse.TabIndex = 15;
            // 
            // xpos
            // 
            this.xpos.CausesValidation = false;
            this.xpos.Location = new System.Drawing.Point(169, 163);
            this.xpos.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(53, 20);
            this.xpos.TabIndex = 16;
            // 
            // xposlbl
            // 
            this.xposlbl.AutoSize = true;
            this.xposlbl.Location = new System.Drawing.Point(129, 165);
            this.xposlbl.Name = "xposlbl";
            this.xposlbl.Size = new System.Drawing.Size(34, 13);
            this.xposlbl.TabIndex = 17;
            this.xposlbl.Text = "X pos";
            // 
            // ypos
            // 
            this.ypos.CausesValidation = false;
            this.ypos.Location = new System.Drawing.Point(169, 190);
            this.ypos.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(53, 20);
            this.ypos.TabIndex = 18;
            // 
            // yposlbl
            // 
            this.yposlbl.AutoSize = true;
            this.yposlbl.Location = new System.Drawing.Point(129, 192);
            this.yposlbl.Name = "yposlbl";
            this.yposlbl.Size = new System.Drawing.Size(34, 13);
            this.yposlbl.TabIndex = 19;
            this.yposlbl.Text = "Y pos";
            // 
            // label_setposinfo
            // 
            this.label_setposinfo.AutoSize = true;
            this.label_setposinfo.Location = new System.Drawing.Point(129, 213);
            this.label_setposinfo.Name = "label_setposinfo";
            this.label_setposinfo.Size = new System.Drawing.Size(94, 13);
            this.label_setposinfo.TabIndex = 20;
            this.label_setposinfo.Text = "Press space to set";
            // 
            // FormAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 375);
            this.Controls.Add(this.label_setposinfo);
            this.Controls.Add(this.yposlbl);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.xposlbl);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.comboBox_mouse);
            this.Controls.Add(this.mouselbl);
            this.Controls.Add(this.comboBox_misc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_mp3opt);
            this.Controls.Add(this.label_mp3opt);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.KeyPreview = true;
            this.Name = "FormAction";
            this.Text = "New action";
            this.Load += new System.EventHandler(this.FormAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ypos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label_mp3opt;
        private System.Windows.Forms.ComboBox comboBox_mp3opt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_misc;
        private System.Windows.Forms.Label mouselbl;
        private System.Windows.Forms.ComboBox comboBox_mouse;
        private System.Windows.Forms.NumericUpDown xpos;
        private System.Windows.Forms.Label xposlbl;
        private System.Windows.Forms.NumericUpDown ypos;
        private System.Windows.Forms.Label yposlbl;
        private System.Windows.Forms.Label label_setposinfo;
    }
}