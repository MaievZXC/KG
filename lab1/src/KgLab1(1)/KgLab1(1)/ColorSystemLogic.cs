
using System;

namespace KgLab1_1_
{
    public class ColorSystemLogic
    {
        private static ColorSwaps colorForm;

        public ColorSystemLogic(ColorSwaps form)
        {
            colorForm = form;
        }

        public static void GetRGBShadesForCMYK(out int redShade, out int greenShade, out int blueShade)
        {
            redShade = (int)Math.Round((255 * (1 - (float)colorForm.CyanTrackBar.Value / 100) * (1 - (float)colorForm.KeyTrackBar.Value / 100)), MidpointRounding.AwayFromZero);
            greenShade = (int)Math.Round((255 * (1 - (float)colorForm.MagentaTrackBar.Value / 100) * (1 - (float)colorForm.KeyTrackBar.Value / 100)), MidpointRounding.AwayFromZero);
            blueShade = (int)Math.Round((255 * (1 - (float)colorForm.YellowTrackBar.Value / 100) * (1 - (float)colorForm.KeyTrackBar.Value / 100)), MidpointRounding.AwayFromZero);
        }

        public static void GetRGBShadesForHSV(out int redShade, out int greenShade, out int blueShade)
        {
            int HueRange = (colorForm.HueTrackBar.Value / 60) % 6;
            float ValueMin = (float)((100 - colorForm.SaturationTrackBar.Value) * colorForm.ValueTrackBar.Value) / 100;
            float a = (float)(colorForm.ValueTrackBar.Value - ValueMin) * (colorForm.HueTrackBar.Value % 60) / 60;
            float ValueInc = ValueMin + a;
            float ValueDec = colorForm.ValueTrackBar.Value - a;

            float redShade1 = 0;
            float greenShade1 = 0;
            float blueShade1 = 0;

            if (HueRange == 0)
            {
                redShade1 = colorForm.ValueTrackBar.Value;
                greenShade1 = (ValueInc);
                blueShade1 = (ValueMin);
            }
            else if (HueRange == 1)
            {
                redShade1 = (ValueDec);
                greenShade1 = colorForm.ValueTrackBar.Value;
                blueShade1 = (ValueMin);
            }
            else if (HueRange == 2)
            {
                redShade1 = (ValueMin);
                greenShade1 = colorForm.ValueTrackBar.Value;
                blueShade1 = (ValueInc);
            }
            else if (HueRange == 3)
            {
                redShade1 = (ValueMin);
                greenShade1 = (ValueDec);
                blueShade1 = colorForm.ValueTrackBar.Value;
            }
            else if (HueRange == 4)
            {
                redShade1 = (ValueInc);
                greenShade1 = (ValueMin);
                blueShade1 = colorForm.ValueTrackBar.Value;
            }
            else if (HueRange == 5)
            {
                redShade1 = colorForm.ValueTrackBar.Value;
                greenShade1 = (ValueMin);
                blueShade1 = (ValueDec);
            }

            redShade = (int)Math.Round((float)redShade1 * 255 / 100, MidpointRounding.AwayFromZero);
            greenShade = (int)Math.Round((float)greenShade1 * 255 / 100, MidpointRounding.AwayFromZero);
            blueShade = (int)Math.Round((float)blueShade1 * 255 / 100, MidpointRounding.AwayFromZero);
        }

        public static void GetCMYKShades(out float cyanShade, out float magentaShade, out float yellowShade, out float key)
        {
            float redShade = (float)colorForm.RedTrackBar.Value / 255;
            float greenShade = (float)colorForm.GreenTrackBar.Value / 255;
            float blueShade = (float)colorForm.BlueTrackBar.Value / 255;
            float max = MathF.Max(MathF.Max(redShade, greenShade), blueShade);

            key = 1 - max;
            cyanShade = 0;
            magentaShade = 0;
            yellowShade = 0;

            if (key != 1)
            {
                cyanShade = (1 - redShade - key) / (1 - key);
                magentaShade = (1 - greenShade - key) / (1 - key);
                yellowShade = (1 - blueShade - key) / (1 - key);
            }
        }

        public static void GetHSVShades(out int hue, out float saturation, out float value)
        {
            float redShade = (float)colorForm.RedTrackBar.Value / 255;
            float greenShade = (float)colorForm.GreenTrackBar.Value / 255;
            float blueShade = (float)colorForm.BlueTrackBar.Value / 255;
            float max = MathF.Max(MathF.Max(redShade, greenShade), blueShade);
            float min = MathF.Min(MathF.Min(redShade, greenShade), blueShade);
            float delta = max - min;

            hue = 0;
            if (delta == 0)
            {
                hue = 0;
            }
            else if (max == redShade)
            {
                hue = (int)Math.Round((60 * ((greenShade - blueShade) / delta)), MidpointRounding.AwayFromZero);
                hue += (greenShade < blueShade) ? 360 : 0;
            }
            else if (max == greenShade)
            {
                hue = (int)Math.Round((60 * ((blueShade - redShade) / delta)) + 120, MidpointRounding.AwayFromZero);
            }
            else if (max == blueShade)
            {   
                hue = (int)Math.Round((60 * ((redShade - greenShade) / delta)) + 240, MidpointRounding.AwayFromZero);
            }

            saturation = (max == 0) ? 0 : delta / max;
            value = max;
        }
    }
}
