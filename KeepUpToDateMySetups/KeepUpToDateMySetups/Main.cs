using System;
using System.Windows.Forms;

namespace KeepUpToDateMySetups
{
    public partial class Main : Form
    {
        private Worker Worker;
        public Main()
        {
            InitializeComponent();
            Worker = new Worker(Log, CurrStatus);
            LoadUI();
        }

        private void LoadUI()
        {
            AvailableList.Items.AddRange(Worker.GetAvaiblePResetsArray());
            RefreshUsedPresets();
            Count.Text = SetupsContainer.GetCollection().Length.ToString();
        }

        private void RefreshUsedPresets()
        {
            UsedPresets.Items.Clear();
            UsedPresets.Items.AddRange(Worker.GetUsedPresets());
            try
            {
                UsedPresets.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                //NOTHING
            }
            if (UsedPresets.Items.Count == 0)
            {
                DeleteSoftware.Enabled = false;
                UpdateSoftware.Enabled = false;
                UpdateAll.Enabled = false;
            }
            else
            {
                DeleteSoftware.Enabled = true;
                UpdateSoftware.Enabled = true;
                UpdateAll.Enabled = true;
            }
        }

        private void DeleteSoftware_Click(object sender, EventArgs e)
        {
            Worker.RemoveSoftware(UsedPresets.SelectedItem.ToString());
            RefreshUsedPresets();
        }

        private void AddSoftware_Click(object sender, EventArgs e)
        {
            Worker.AddSoftware();
            RefreshUsedPresets();
        }

        private void UpdateSoftware_Click(object sender, EventArgs e)
        {
            Worker.UpdateSelectedSoftware(UsedPresets.SelectedItem.ToString());
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            Worker.UpdateAll();
        }
    }
}
