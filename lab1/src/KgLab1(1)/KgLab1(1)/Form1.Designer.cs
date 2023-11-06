namespace KgLab1_1_
{
    partial class ColorSwaps
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.Pallet = new System.Windows.Forms.Button();
            this.KeyValueBox = new System.Windows.Forms.TextBox();
            this.YellowValueBox = new System.Windows.Forms.TextBox();
            this.MagentaValueBox = new System.Windows.Forms.TextBox();
            this.CyanValueBox = new System.Windows.Forms.TextBox();
            this.CyanLabel = new System.Windows.Forms.Label();
            this.KeyTrackBar = new System.Windows.Forms.TrackBar();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.YellowTrackBar = new System.Windows.Forms.TrackBar();
            this.CyanTrackBar = new System.Windows.Forms.TrackBar();
            this.MagentaTrackBar = new System.Windows.Forms.TrackBar();
            this.YellowLabel = new System.Windows.Forms.Label();
            this.MagentaLabel = new System.Windows.Forms.Label();
            this.RedValueBox = new System.Windows.Forms.TextBox();
            this.GreenValueBox = new System.Windows.Forms.TextBox();
            this.BlueValueBox = new System.Windows.Forms.TextBox();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.ValueValueBox = new System.Windows.Forms.TextBox();
            this.SaturationValueBox = new System.Windows.Forms.TextBox();
            this.HueValueBox = new System.Windows.Forms.TextBox();
            this.ValueTrackBar = new System.Windows.Forms.TrackBar();
            this.HueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SaturationTrackBar = new System.Windows.Forms.TrackBar();
            this.HueTrackBar = new System.Windows.Forms.TrackBar();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CyanTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagentaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.Pallet);
            this.ColorPanel.Location = new System.Drawing.Point(13, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(665, 576);
            this.ColorPanel.TabIndex = 1;
            // 
            // Pallet
            // 
            this.Pallet.Location = new System.Drawing.Point(17, 409);
            this.Pallet.Name = "Pallet";
            this.Pallet.Size = new System.Drawing.Size(216, 154);
            this.Pallet.TabIndex = 6;
            this.Pallet.UseVisualStyleBackColor = true;
            this.Pallet.Click += new System.EventHandler(this.Pallet_Click);
            // 
            // KeyValueBox
            // 
            this.KeyValueBox.Location = new System.Drawing.Point(65, 172);
            this.KeyValueBox.Name = "KeyValueBox";
            this.KeyValueBox.Size = new System.Drawing.Size(55, 23);
            this.KeyValueBox.TabIndex = 28;
            this.KeyValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.KeyValueBox_Validating);
            // 
            // YellowValueBox
            // 
            this.YellowValueBox.Location = new System.Drawing.Point(65, 122);
            this.YellowValueBox.Name = "YellowValueBox";
            this.YellowValueBox.Size = new System.Drawing.Size(55, 23);
            this.YellowValueBox.TabIndex = 27;
            this.YellowValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.YellowValueBox_Validating);
            // 
            // MagentaValueBox
            // 
            this.MagentaValueBox.Location = new System.Drawing.Point(65, 73);
            this.MagentaValueBox.Name = "MagentaValueBox";
            this.MagentaValueBox.Size = new System.Drawing.Size(55, 23);
            this.MagentaValueBox.TabIndex = 26;
            this.MagentaValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.MagentaValueBox_Validating);
            // 
            // CyanValueBox
            // 
            this.CyanValueBox.Location = new System.Drawing.Point(65, 16);
            this.CyanValueBox.Name = "CyanValueBox";
            this.CyanValueBox.Size = new System.Drawing.Size(55, 23);
            this.CyanValueBox.TabIndex = 25;
            this.CyanValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.CyanValueBox_Validating);
            // 
            // CyanLabel
            // 
            this.CyanLabel.AutoSize = true;
            this.CyanLabel.Location = new System.Drawing.Point(13, 19);
            this.CyanLabel.Name = "CyanLabel";
            this.CyanLabel.Size = new System.Drawing.Size(34, 15);
            this.CyanLabel.TabIndex = 17;
            this.CyanLabel.Text = "Cyan";
            // 
            // KeyTrackBar
            // 
            this.KeyTrackBar.Location = new System.Drawing.Point(126, 159);
            this.KeyTrackBar.Maximum = 100;
            this.KeyTrackBar.Name = "KeyTrackBar";
            this.KeyTrackBar.Size = new System.Drawing.Size(158, 45);
            this.KeyTrackBar.TabIndex = 24;
            this.KeyTrackBar.ValueChanged += new System.EventHandler(this.OnKeyTrackBarChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(13, 175);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(26, 15);
            this.KeyLabel.TabIndex = 20;
            this.KeyLabel.Text = "Key";
            // 
            // YellowTrackBar
            // 
            this.YellowTrackBar.Location = new System.Drawing.Point(126, 108);
            this.YellowTrackBar.Maximum = 100;
            this.YellowTrackBar.Name = "YellowTrackBar";
            this.YellowTrackBar.Size = new System.Drawing.Size(158, 45);
            this.YellowTrackBar.TabIndex = 23;
            this.YellowTrackBar.ValueChanged += new System.EventHandler(this.OnYellowTrackBarChanged);
            // 
            // CyanTrackBar
            // 
            this.CyanTrackBar.Location = new System.Drawing.Point(126, 6);
            this.CyanTrackBar.Maximum = 100;
            this.CyanTrackBar.Name = "CyanTrackBar";
            this.CyanTrackBar.Size = new System.Drawing.Size(158, 45);
            this.CyanTrackBar.TabIndex = 21;
            this.CyanTrackBar.ValueChanged += new System.EventHandler(this.OnCyanTrackBarChanged);
            // 
            // MagentaTrackBar
            // 
            this.MagentaTrackBar.Location = new System.Drawing.Point(126, 57);
            this.MagentaTrackBar.Maximum = 100;
            this.MagentaTrackBar.Name = "MagentaTrackBar";
            this.MagentaTrackBar.Size = new System.Drawing.Size(158, 45);
            this.MagentaTrackBar.TabIndex = 22;
            this.MagentaTrackBar.ValueChanged += new System.EventHandler(this.OnMagentaTrackBarChanged);
            // 
            // YellowLabel
            // 
            this.YellowLabel.AutoSize = true;
            this.YellowLabel.Location = new System.Drawing.Point(13, 130);
            this.YellowLabel.Name = "YellowLabel";
            this.YellowLabel.Size = new System.Drawing.Size(41, 15);
            this.YellowLabel.TabIndex = 19;
            this.YellowLabel.Text = "Yellow";
            // 
            // MagentaLabel
            // 
            this.MagentaLabel.AutoSize = true;
            this.MagentaLabel.Location = new System.Drawing.Point(5, 76);
            this.MagentaLabel.Name = "MagentaLabel";
            this.MagentaLabel.Size = new System.Drawing.Size(54, 15);
            this.MagentaLabel.TabIndex = 18;
            this.MagentaLabel.Text = "Magenta";
            // 
            // RedValueBox
            // 
            this.RedValueBox.Location = new System.Drawing.Point(66, 25);
            this.RedValueBox.Name = "RedValueBox";
            this.RedValueBox.Size = new System.Drawing.Size(55, 23);
            this.RedValueBox.TabIndex = 37;
            this.RedValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.RedValueBox_Validating);
            // 
            // GreenValueBox
            // 
            this.GreenValueBox.Location = new System.Drawing.Point(66, 95);
            this.GreenValueBox.Name = "GreenValueBox";
            this.GreenValueBox.Size = new System.Drawing.Size(55, 23);
            this.GreenValueBox.TabIndex = 36;
            this.GreenValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.GreenValueBox_Validating);
            // 
            // BlueValueBox
            // 
            this.BlueValueBox.Location = new System.Drawing.Point(66, 164);
            this.BlueValueBox.Name = "BlueValueBox";
            this.BlueValueBox.Size = new System.Drawing.Size(55, 23);
            this.BlueValueBox.TabIndex = 29;
            this.BlueValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.BlueValueBox_Validating);
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(123, 151);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(158, 45);
            this.BlueTrackBar.TabIndex = 35;
            this.BlueTrackBar.ValueChanged += new System.EventHandler(this.OnBlueTrackBarChanged);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Location = new System.Drawing.Point(123, 83);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(158, 45);
            this.GreenTrackBar.TabIndex = 34;
            this.GreenTrackBar.ValueChanged += new System.EventHandler(this.OnGreenTrackBarChanged);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(17, 172);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(30, 15);
            this.BlueLabel.TabIndex = 32;
            this.BlueLabel.Text = "Blue";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(17, 28);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(27, 15);
            this.RedLabel.TabIndex = 30;
            this.RedLabel.Text = "Red";
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Location = new System.Drawing.Point(123, 15);
            this.RedTrackBar.Maximum = 255;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(158, 45);
            this.RedTrackBar.TabIndex = 33;
            this.RedTrackBar.ValueChanged += new System.EventHandler(this.OnRedTrackBarChanged);
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(17, 98);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(38, 15);
            this.GreenLabel.TabIndex = 31;
            this.GreenLabel.Text = "Green";
            // 
            // ValueValueBox
            // 
            this.ValueValueBox.Location = new System.Drawing.Point(83, 153);
            this.ValueValueBox.Name = "ValueValueBox";
            this.ValueValueBox.Size = new System.Drawing.Size(55, 23);
            this.ValueValueBox.TabIndex = 37;
            this.ValueValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValueValueBox_Validating);
            // 
            // SaturationValueBox
            // 
            this.SaturationValueBox.Location = new System.Drawing.Point(83, 80);
            this.SaturationValueBox.Name = "SaturationValueBox";
            this.SaturationValueBox.Size = new System.Drawing.Size(55, 23);
            this.SaturationValueBox.TabIndex = 36;
            this.SaturationValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.SaturationValueBox_Validating);
            // 
            // HueValueBox
            // 
            this.HueValueBox.Location = new System.Drawing.Point(83, 18);
            this.HueValueBox.Name = "HueValueBox";
            this.HueValueBox.Size = new System.Drawing.Size(55, 23);
            this.HueValueBox.TabIndex = 35;
            this.HueValueBox.Validating += new System.ComponentModel.CancelEventHandler(this.HueValueBox_Validating);
            // 
            // ValueTrackBar
            // 
            this.ValueTrackBar.Location = new System.Drawing.Point(144, 138);
            this.ValueTrackBar.Maximum = 100;
            this.ValueTrackBar.Name = "ValueTrackBar";
            this.ValueTrackBar.Size = new System.Drawing.Size(158, 45);
            this.ValueTrackBar.TabIndex = 34;
            this.ValueTrackBar.ValueChanged += new System.EventHandler(this.OnValueTrackBarChanged);
            // 
            // HueLabel
            // 
            this.HueLabel.AutoSize = true;
            this.HueLabel.Location = new System.Drawing.Point(15, 21);
            this.HueLabel.Name = "HueLabel";
            this.HueLabel.Size = new System.Drawing.Size(29, 15);
            this.HueLabel.TabIndex = 29;
            this.HueLabel.Text = "Hue";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(15, 156);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(35, 15);
            this.ValueLabel.TabIndex = 31;
            this.ValueLabel.Text = "Value";
            // 
            // SaturationTrackBar
            // 
            this.SaturationTrackBar.Location = new System.Drawing.Point(144, 70);
            this.SaturationTrackBar.Maximum = 100;
            this.SaturationTrackBar.Name = "SaturationTrackBar";
            this.SaturationTrackBar.Size = new System.Drawing.Size(158, 45);
            this.SaturationTrackBar.TabIndex = 33;
            this.SaturationTrackBar.ValueChanged += new System.EventHandler(this.OnSaturationTrackBarChanged);
            // 
            // HueTrackBar
            // 
            this.HueTrackBar.Location = new System.Drawing.Point(144, 6);
            this.HueTrackBar.Maximum = 360;
            this.HueTrackBar.Name = "HueTrackBar";
            this.HueTrackBar.Size = new System.Drawing.Size(158, 45);
            this.HueTrackBar.TabIndex = 32;
            this.HueTrackBar.ValueChanged += new System.EventHandler(this.OnHueTrackBarChanged);
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(15, 83);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(61, 15);
            this.SaturationLabel.TabIndex = 30;
            this.SaturationLabel.Text = "Saturation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RedLabel);
            this.groupBox1.Controls.Add(this.RedValueBox);
            this.groupBox1.Controls.Add(this.GreenTrackBar);
            this.groupBox1.Controls.Add(this.BlueLabel);
            this.groupBox1.Controls.Add(this.BlueTrackBar);
            this.groupBox1.Controls.Add(this.RedTrackBar);
            this.groupBox1.Controls.Add(this.GreenValueBox);
            this.groupBox1.Controls.Add(this.BlueValueBox);
            this.groupBox1.Controls.Add(this.GreenLabel);
            this.groupBox1.Location = new System.Drawing.Point(682, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 192);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ValueValueBox);
            this.groupBox2.Controls.Add(this.HueLabel);
            this.groupBox2.Controls.Add(this.SaturationValueBox);
            this.groupBox2.Controls.Add(this.SaturationLabel);
            this.groupBox2.Controls.Add(this.HueValueBox);
            this.groupBox2.Controls.Add(this.HueTrackBar);
            this.groupBox2.Controls.Add(this.ValueTrackBar);
            this.groupBox2.Controls.Add(this.SaturationTrackBar);
            this.groupBox2.Controls.Add(this.ValueLabel);
            this.groupBox2.Location = new System.Drawing.Point(684, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 180);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HSV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CyanLabel);
            this.groupBox3.Controls.Add(this.MagentaLabel);
            this.groupBox3.Controls.Add(this.YellowLabel);
            this.groupBox3.Controls.Add(this.KeyValueBox);
            this.groupBox3.Controls.Add(this.MagentaTrackBar);
            this.groupBox3.Controls.Add(this.YellowValueBox);
            this.groupBox3.Controls.Add(this.CyanTrackBar);
            this.groupBox3.Controls.Add(this.MagentaValueBox);
            this.groupBox3.Controls.Add(this.YellowTrackBar);
            this.groupBox3.Controls.Add(this.CyanValueBox);
            this.groupBox3.Controls.Add(this.KeyLabel);
            this.groupBox3.Controls.Add(this.KeyTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(684, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 208);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CMYK";
            // 
            // ColorSwaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ColorPanel);
            this.Name = "ColorSwaps";
            this.Text = "ChangeColorForm";
            this.ColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CyanTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagentaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        public Panel ColorPanel;
        private Button Pallet;
        private TextBox KeyValueBox;
        private TextBox YellowValueBox;
        private TextBox MagentaValueBox;
        private TextBox CyanValueBox;
        private Label CyanLabel;
        public TrackBar KeyTrackBar;
        private Label KeyLabel;
        public TrackBar YellowTrackBar;
        public TrackBar CyanTrackBar;
        public TrackBar MagentaTrackBar;
        private Label YellowLabel;
        private Label MagentaLabel;
        private TextBox RedValueBox;
        private TextBox GreenValueBox;
        private TextBox BlueValueBox;
        public TrackBar BlueTrackBar;
        public TrackBar GreenTrackBar;
        private Label BlueLabel;
        private Label RedLabel;
        public TrackBar RedTrackBar;
        private Label GreenLabel;
        private TextBox ValueValueBox;
        private TextBox SaturationValueBox;
        private TextBox HueValueBox;
        public TrackBar ValueTrackBar;
        private Label HueLabel;
        private Label ValueLabel;
        public TrackBar SaturationTrackBar;
        public TrackBar HueTrackBar;
        private Label SaturationLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }

    #endregion
}