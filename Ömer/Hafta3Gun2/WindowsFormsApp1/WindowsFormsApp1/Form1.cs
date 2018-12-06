using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public struct PersonInfo
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
    }

    public struct TextSettings
    {
        public Color Color { get; set; }
        public Font Font { get; set; }
    }
    public partial class Form1 : Form
    {
        private TextSettings _textSettings;
        public Form1()
        {
            InitializeComponent();
             _textSettings = new TextSettings();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var personInfo = new PersonInfo
            {
                Description = tBDescription.Text,
                LastName = tBLastName.Text,
                Name = tBName.Text
            };
            using (var targetForm = new TargetForm(personInfo, _textSettings))
            {
                targetForm.ShowDialog();
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            tBDescription.Text = tBLastName.Text = tBName.Text = "";
        }

        private void FontSettings_Click(object sender, EventArgs e)
        {
            using (var fontWindow = new FontDialog())
            {
                if (fontWindow.ShowDialog() == DialogResult.OK)
                {
                    _textSettings.Font = tBName.Font = tBDescription.Font = tBLastName.Font = fontWindow.Font;
                }
            }
        }

        private void ColorSettings_Click(object sender, EventArgs e)
        {
            using (var colorWindow = new ColorDialog())
            {
                if (colorWindow.ShowDialog() == DialogResult.OK)
                {
                    _textSettings.Color= tBName.ForeColor = tBDescription.ForeColor = tBLastName.ForeColor = colorWindow.Color;
                }
            }
        }
    }
}
