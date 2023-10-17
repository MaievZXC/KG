﻿
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
            redShade = (int)(255 * (1 - (float)colorForm.CyanTrackBar.Value / 100) * (1 - (float)colorForm.KeyTrackBar.Value / 100));
            greenShade = (int)(255 * (1 - (float)colorForm.MagentaTrackBar.Value / 100) * (1 - (float)colorForm.KeyTrackBar.Value / 100));
            blueShade = (int)(255 * (1 - (float)colorForm.YellowTrackBar.Value / 100) * (1 - (float)colorForm.KeyTrackBar.Value / 100));
        }

        public static void GetRGBShadesForHSV(out int redShade, out int greenShade, out int blueShade)
        {
            int HueRange = (colorForm.HueTrackBar.Value / 60) % 6;
            int ValueMin = ((100 - colorForm.SaturationTrackBar.Value) * colorForm.ValueTrackBar.Value) / 100;
            int a = (colorForm.ValueTrackBar.Value - ValueMin) * (colorForm.HueTrackBar.Value % 60) / 60;
            int ValueInc = ValueMin + a;
            int ValueDec = colorForm.ValueTrackBar.Value - a;

            redShade = 0;
            greenShade = 0;
            blueShade = 0;

            if (HueRange == 0)
            {
                redShade = colorForm.ValueTrackBar.Value;
                greenShade = ValueInc;
                blueShade = ValueMin;
            }
            else if (HueRange == 1)
            {
                redShade = ValueDec;
                greenShade = colorForm.ValueTrackBar.Value;
                blueShade = ValueMin;
            }
            else if (HueRange == 2)
            {
                redShade = ValueMin;
                greenShade = colorForm.ValueTrackBar.Value;
                blueShade = ValueInc;
            }
            else if (HueRange == 3)
            {
                redShade = ValueMin;
                greenShade = ValueDec;
                blueShade = colorForm.ValueTrackBar.Value;
            }
            else if (HueRange == 4)
            {
                redShade = ValueInc;
                greenShade = ValueMin;
                blueShade = colorForm.ValueTrackBar.Value;
            }
            else if (HueRange == 5)
            {
                redShade = colorForm.ValueTrackBar.Value;
                greenShade = ValueMin;
                blueShade = ValueDec;
            }

            redShade = redShade * 255 / 100;
            greenShade = greenShade * 255 / 100;
            blueShade = blueShade * 255 / 100;
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
                hue = (int)(60 * ((greenShade - blueShade) / delta));
                hue += (greenShade < blueShade) ? 360 : 0;
            }
            else if (max == greenShade)
            {
                hue = (int)(60 * ((blueShade - redShade) / delta)) + 120;
            }
            else if (max == blueShade)
            {
                hue = (int)(60 * ((redShade - greenShade) / delta)) + 240;
            }

            saturation = (max == 0) ? 0 : delta / max;
            value = max;
        }
    }
}
