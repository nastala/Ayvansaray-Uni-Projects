using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TargetForm : Form
    {
        public TargetForm(PersonInfo personInfo, TextSettings textSettings)
        {
            InitializeComponent();
            lName.Text = personInfo.Name;
            lDescription.Text = personInfo.Description;
            lLastName.Text = personInfo.LastName;

            if (textSettings.Font != null) lName.Font = lDescription.Font = lLastName.Font = textSettings.Font;
            lName.ForeColor = lDescription.ForeColor = lLastName.ForeColor = textSettings.Color;
        }
    }
}
