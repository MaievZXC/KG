using System.ComponentModel;

namespace KgLab1_1_
{
    public partial class ColorSwaps : Form
    {

        int status = 0;
        public ColorSwaps()
        {
            InitializeComponent();
            SetRGBColor();
        }


        private void SetRGBColor()
        {
            Color currentColor = Color.FromArgb(255, this.RedTrackBar.Value, this.GreenTrackBar.Value, this.BlueTrackBar.Value);
            this.ColorPanel.BackColor = currentColor;
            this.Pallet.BackColor = currentColor;
        }

        private void SetCMYKColor()
        {
            ColorSystemLogic.GetRGBShadesForCMYK(out int redShade, out int greenShade, out int blueShade);
            Color currentColor = Color.FromArgb(255, redShade, greenShade, blueShade);
            this.ColorPanel.BackColor = currentColor;
            this.Pallet.BackColor = currentColor;
        }

        private void SetHSVColor()
        {
            ColorSystemLogic.GetRGBShadesForHSV(out int redShade, out int greenShade, out int blueShade);
            Color currentColor = Color.FromArgb(255, redShade, greenShade, blueShade);
            this.ColorPanel.BackColor = currentColor;
            this.Pallet.BackColor = currentColor;
        }

        private void SetCMYKbyRGB()
        {
            ColorSystemLogic.GetCMYKShades(out float cyanShade, out float magentaShade, out float yellowShade, out float key);
            this.CyanTrackBar.Value = (int)Math.Round((cyanShade * 100), MidpointRounding.AwayFromZero);
            this.MagentaTrackBar.Value = (int)Math.Round((magentaShade * 100), MidpointRounding.AwayFromZero);
            this.YellowTrackBar.Value = (int)Math.Round((yellowShade * 100), MidpointRounding.AwayFromZero);
            this.KeyTrackBar.Value = (int)(int)Math.Round((key * 100), MidpointRounding.AwayFromZero);
        }

        private void SetHSVbyRGB()
        {
            ColorSystemLogic.GetHSVShades(out int hue, out float saturation, out float value);
            this.HueTrackBar.Value = hue;
            this.SaturationTrackBar.Value = (int)Math.Round((100 * saturation), MidpointRounding.AwayFromZero);
            this.ValueTrackBar.Value = (int)Math.Round((100 * value), MidpointRounding.AwayFromZero);
        }

        private void SetRGBbyCMYK()
        {
            ColorSystemLogic.GetRGBShadesForCMYK(out int redShade, out int greenShade, out int blueShade);
            this.RedTrackBar.Value = redShade;
            this.GreenTrackBar.Value = greenShade;
            this.BlueTrackBar.Value = blueShade;
        }

        private void SetHSVbyCMYK()
        {
            SetRGBbyCMYK();
            SetHSVbyRGB();
        }

        private void SetRGBbyHSV()
        {
            ColorSystemLogic.GetRGBShadesForHSV(out int redShade, out int greenShade, out int blueShade);
            this.RedTrackBar.Value = redShade;
            this.GreenTrackBar.Value = greenShade;
            this.BlueTrackBar.Value = blueShade;
        }

        private void SetCMYKbyHSV()
        {
            SetRGBbyHSV();
            SetCMYKbyRGB();
        }




        // RGB
        private void OnRedTrackBarChanged(object sender, EventArgs e)
        {
            this.RedValueBox.Text = this.RedTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
                SetRGBColor();
                SetCMYKbyRGB();
                SetHSVbyRGB();
                status = 0;
            }


        }

        private void OnGreenTrackBarChanged(object sender, EventArgs e)
        {
            this.GreenValueBox.Text = this.GreenTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
               
                SetRGBColor();
                SetCMYKbyRGB();
                SetHSVbyRGB();
                status = 0;
            }

        }

        private void OnBlueTrackBarChanged(object sender, EventArgs e)
        {
            this.BlueValueBox.Text = this.BlueTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
                SetRGBColor();
                SetCMYKbyRGB();
                SetHSVbyRGB();
                status = 0;
            }

        }

        // CMYK
        private void OnCyanTrackBarChanged(object sender, EventArgs e)
        {
            this.CyanValueBox.Text = this.CyanTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
                status = 0;
            }

        }

        private void OnMagentaTrackBarChanged(object sender, EventArgs e)
        {
            this.MagentaValueBox.Text = this.MagentaTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;

            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
                status = 0;
            }
        }

        private void OnYellowTrackBarChanged(object sender, EventArgs e)
        {
            this.YellowValueBox.Text = this.YellowTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
               
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
                status = 0;
            }
        }

        private void OnKeyTrackBarChanged(object sender, EventArgs e)
        {
            this.KeyValueBox.Text = this.KeyTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
            SetCMYKColor();
            SetRGBbyCMYK();
            SetHSVbyCMYK();
                status = 0;
            }
        }

        // HSV
        private void OnHueTrackBarChanged(object sender, EventArgs e)
        {
            this.HueValueBox.Text = this.HueTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
                SetHSVColor();
                SetRGBbyHSV();
                SetCMYKbyHSV();
                status = 0;
            }
        }
    

        private void OnSaturationTrackBarChanged(object sender, EventArgs e)
        {
            this.SaturationValueBox.Text = this.SaturationTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV();
                status = 0;
            }
        }

        private void OnValueTrackBarChanged(object sender, EventArgs e)
        {
            this.ValueValueBox.Text = this.ValueTrackBar.Value.ToString();
            if (status == 0)
            {
                status = 1;
                
            SetHSVColor();
            SetRGBbyHSV();
            SetCMYKbyHSV();
                status = 0;
            }
        }

        private void RedValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.RedValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length- 1 - i);
            }
            if (sum < 256 && sum > 0)
            {
                this.RedTrackBar.Value = sum;
            }
            else
            {
                this.RedTrackBar.Value = 0;
            }
        }

        private void GreenValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.GreenValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 256 && sum > 0)
            {
                this.GreenTrackBar.Value = sum;
            }
            else
            {
                this.GreenTrackBar.Value = 0;
            }
        }

        private void BlueValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.BlueValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 256 && sum > 0)
            {
                this.BlueTrackBar.Value = sum;
            }
            else
            {
                this.BlueTrackBar.Value = 0;
            }
        }

        private void HueValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.HueValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 361 && sum > 0)
            {
                this.HueTrackBar.Value = sum;
            }
            else
            {
                this.HueTrackBar.Value = 0;
            }
        }

        private void SaturationValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.SaturationValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 101 && sum > 0)
            {
                this.SaturationTrackBar.Value = sum;
            }
            else
            {
                this.SaturationTrackBar.Value = 0;
            }
        }

        private void ValueValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.ValueValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 101 && sum > 0)
            {
                this.ValueTrackBar.Value = sum;
            }
            else
            {
                this.ValueTrackBar.Value = 0;
            }
        }

        private void CyanValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.CyanValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 101 && sum > 0)
            {
                this.CyanTrackBar.Value = sum;
            }
            else
            {
                this.CyanTrackBar.Value = 0;
            }
        }

        private void MagentaValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.MagentaValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 101 && sum > 0)
            {
                this.MagentaTrackBar.Value = sum;
            }
            else
            {
                this.MagentaTrackBar.Value = 0;
            }
        }

        private void YellowValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.YellowValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 101 && sum > 0)
            {
                this.YellowTrackBar.Value = sum;
            }
            else
            {
                this.YellowTrackBar.Value = 0;
            }
        }

        private void KeyValueBox_Validating(object sender, CancelEventArgs e)
        {
            int sum = 0;
            String str = this.KeyValueBox.Text;
            for (int i = str.Length - 1; i > -1; i--)
            {
                sum += (str[i] - '0') * (int)MathF.Pow(10, str.Length - 1 - i);
            }
            if (sum < 101 && sum > 0)
            {
                this.KeyTrackBar.Value = sum;
            }
            else
            {
                this.KeyTrackBar.Value = 0;
            }
        }

        private void Pallet_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = this.ColorPanel.BackColor;
            cd.AnyColor = true;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                this.RedTrackBar.Value = cd.Color.R;
                this.GreenTrackBar.Value = cd.Color.G;
                this.BlueTrackBar.Value = cd.Color.B;
            }
        }


    }
}