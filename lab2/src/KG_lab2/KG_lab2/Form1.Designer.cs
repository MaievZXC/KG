using Emgu.CV.UI;

namespace Lab2
{
    partial class Lab2Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {






            this.components = new System.ComponentModel.Container();
            this.Original = new System.Windows.Forms.PictureBox();
            this.Processed = new System.Windows.Forms.PictureBox();
            this.openPicture = new System.Windows.Forms.OpenFileDialog();
            this.FilterType = new System.Windows.Forms.ComboBox();
            this.savePicture = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.histo1 = new Emgu.CV.UI.HistogramBox();
            this.Histogram1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Processed)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram1)).BeginInit();
            this.SuspendLayout();
            // 
            // Original
            // 
            this.Original.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Original.Location = new System.Drawing.Point(0, 0);
            this.Original.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(500, 520);
            this.Original.TabIndex = 0;
            this.Original.TabStop = false;
            // 
            // Processed
            // 
            this.Processed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Processed.Location = new System.Drawing.Point(785, 0);
            this.Processed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Processed.Name = "Processed";
            this.Processed.Size = new System.Drawing.Size(500, 520);
            this.Processed.TabIndex = 1;
            this.Processed.TabStop = false;
            // 
            // openPicture
            // 
            this.openPicture.FileName = "openFileDialog1";
            this.openPicture.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";
            this.openPicture.InitialDirectory = "C:\\";
            this.openPicture.Title = "Please select image file to filter";
            // 
            // FilterType
            // 
            this.FilterType.FormattingEnabled = true;
            this.FilterType.Items.AddRange(new object[] {
            "Equalize",
            "High-pass filter",
            "Linear"});
            this.FilterType.Location = new System.Drawing.Point(43, 45);
            this.FilterType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FilterType.Name = "FilterType";
            this.FilterType.Size = new System.Drawing.Size(180, 23);
            this.FilterType.TabIndex = 3;
            this.FilterType.Text = "Equalize";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 550);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(100, 40);
            this.OpenFileButton.TabIndex = 11;
            this.OpenFileButton.Text = "Open picture";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.FilterType);
            this.GroupBox.Location = new System.Drawing.Point(505, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(275, 116);
            this.GroupBox.TabIndex = 12;
            this.GroupBox.TabStop = false;
            // 
            // histo1
            // 
            this.histo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.histo1.Location = new System.Drawing.Point(200, 100);
            this.histo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.histo1.Name = "histo1";
            this.histo1.Size = new System.Drawing.Size(100, 100);
            this.histo1.TabIndex = 0;
            this.histo1.TabStop = false;
            // 
            // Histogram1
            // 
            this.Histogram1.Location = new System.Drawing.Point(505, 159);
            this.Histogram1.Name = "Histogram1";
            this.Histogram1.Size = new System.Drawing.Size(275, 225);
            this.Histogram1.TabIndex = 13;
            this.Histogram1.TabStop = false;
            // 
            // Lab2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.Histogram1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.Processed);
            this.Controls.Add(this.Original);
            this.Controls.Add(this.histo1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Lab2Form";
            this.Text = "Lab2Form";
            ((System.ComponentModel.ISupportInitialize)(this.Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Processed)).EndInit();
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram1)).EndInit();
            this.ResumeLayout(false);





            this.OpenFileButton.Click += OnOpenButtonClicked;
            this.FilterType.SelectedIndexChanged += OnFilterTypeSelectedIndexChanged;

        }

        #endregion

        private PictureBox Original;
        private PictureBox Processed;
        private OpenFileDialog openPicture;
        private ComboBox FilterType;
        private SaveFileDialog savePicture;
        private Button OpenFileButton;
        private GroupBox GroupBox;
        private HistogramBox histo1;
        private PictureBox Histogram1;
    }
}