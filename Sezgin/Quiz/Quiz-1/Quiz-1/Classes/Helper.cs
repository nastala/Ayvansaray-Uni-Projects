using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Quiz_1.Classes
{
    public static class Helper
    {
        public enum Gender
        {
            Male,
            Female
        }

        public static void ClearInputs(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                    control.Text = "";
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                else if (control is PictureBox)
                    ((PictureBox)control).Image = null;
            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
