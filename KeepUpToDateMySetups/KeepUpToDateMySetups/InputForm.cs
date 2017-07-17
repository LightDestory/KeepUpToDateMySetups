using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeepUpToDateMySetups
{
    public partial class InputForm : Form
    {
        public String Choose;

        public InputForm()
        {
            InitializeComponent();
        }

        public new void ShowDialog(List<string> A, List<string> B)
        {
            Choose = "";
            AddSelection.Items.Clear();
            AddSelection.Items.AddRange(GetFilteredList(A, B));
            if (AddSelection.Items.Count != 0)
            {
                AddSelection.SelectedIndex = 0;
                base.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are using already all available presets!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                base.Hide();
            }

        }

        private string[] GetFilteredList(List<string> A, List<string> B)
        {
            List<string> temp = new List<string>();
            foreach (string s in A)
            {
                if (!B.Contains(s))
                {
                    temp.Add(s);
                }
            }

            return temp.ToArray();
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Choose = AddSelection.SelectedItem.ToString();
            base.Hide();
        }
    }
}
