using System.Windows.Forms;

namespace WindowsFormsApp1
{
    sealed class TabWithRTB : TabPage
    {
        public string SaveLocation { get; set; }
        private readonly RichTextBox _richTextBox;
        public int TabOrder { get;}

        public string WrittenText
        {
            get => _richTextBox.Text;
            set => _richTextBox.Text = value;
        }

        public string TabTitle
        {
            set => Text = value + "    ";
            get => Text.Substring(0, Text.Length - 4);
        }

        public TabWithRTB(int tabOrder = -1, string name = "")
        {
            TabOrder = tabOrder;
            _richTextBox = new RichTextBox { Dock = DockStyle.Fill };
            Text = name == "" ? $"New Tab {tabOrder}    " : name + "    ";
            Controls.Add(_richTextBox);
        }
    }
}
