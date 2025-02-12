using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemberBenefitsDashboard
{
    public partial class MemberBenefitsForm : Form
    {
        private List<Benefit> benefits; // List to hold the benefits

        public MemberBenefitsForm()
        {
            InitializeComponent();
        }

        private void MemberBenefitsForm_Load(object sender, EventArgs e)
        {
            // Fetch benefits from the database
            benefits = DatabaseHelper.GetBenefits();

            // Display benefits in the DataGridView
            BindBenefitsToGrid();

            // Update the ProgressBar
            UpdateProgressBar();
        }

        private void BindBenefitsToGrid()
        {
            dataGridViewBenefits.DataSource = benefits.Select(b => new
            {
                b.Id,
                b.Name,
                Status = b.IsUsed ? "Used" : "Not Used"
            }).ToList();
        }

        private void UpdateProgressBar()
        {
            int usedCount = benefits.Count(b => b.IsUsed);
            int totalCount = benefits.Count;
            int progressPercentage = totalCount > 0 ? (int)((usedCount / (double)totalCount) * 100) : 0;

            progressBarUsage.Value = progressPercentage;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (benefits.Count > 0)
            {
                var firstBenefit = benefits[0];
                firstBenefit.IsUsed = !firstBenefit.IsUsed;

                DatabaseHelper.UpdateBenefit(firstBenefit);
                BindBenefitsToGrid();
                UpdateProgressBar();
            }
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            DatabaseHelper.SaveBenefits(benefits);
            MessageBox.Show("Benefits saved to database!");
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewBenefits.SelectedRows.Count > 0)
            {
                var selectedIndex = dataGridViewBenefits.SelectedRows[0].Index;
                var selectedBenefit = benefits[selectedIndex];

                MessageBox.Show($"Benefit: {selectedBenefit.Name}\nStatus: {(selectedBenefit.IsUsed ? "Used" : "Not Used")}");
            }
            else
            {
                MessageBox.Show("Please select a benefit.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

