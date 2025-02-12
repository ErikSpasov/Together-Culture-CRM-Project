using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberInformation
{
    public partial class MemberInfoForm : Form
    {
        private MemberInfo currentMember;

        public MemberInfoForm()
        {
            InitializeComponent();
        }

        private void MemberInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes
            string interests = txtInterests.Text;
            string intentions = txtIntentions.Text;

            // Create a new MemberInfo object with the input data
            currentMember = new MemberInfo(interests, intentions);

            // Clear the textboxes after saving
            txtInterests.Clear();
            txtIntentions.Clear();

            MessageBox.Show("Member information saved successfully!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Check if a member's information is saved
            if (currentMember != null)
            {
                MessageBox.Show($"Interests: {currentMember.Interests}\nIntentions: {currentMember.Intentions}");
            }
            else
            {
                MessageBox.Show("No information saved yet.");
            }
        }

    }
}
