using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;
using System.Threading;

namespace KeepUpToDateMySetups
{
    class Worker
    {
        public static string WorkingFolder = Application.StartupPath + "\\MyPrograms\\";
        private NetHandler Internet;
        private List<string> UsedPresets, AvailablePresets;
        private InputForm RequestInput;
        private ListBox Log;
        private bool Aborted;

        public Worker(ListBox Log, Label Status)
        {
            this.Log = Log;
            Internet = new NetHandler(Status);
            UsedPresets = new List<string>();
            AvailablePresets = new List<string>();
            RequestInput = new InputForm();
            Init();
        }

        private void Init()
        {
            CheckWorkingFolder();
            Logger("Loading available Presets...");
            foreach(Software s in SetupsContainer.GetCollection())
            {
                AvailablePresets.Add(s.Name);
            }
            Logger("Done");
        }

        public void RemoveSoftware(string Name)
        {
            Logger("Removing " + Name + "...");
            UsedPresets.Remove(Name);
            foreach (String s in Directory.GetFiles(WorkingFolder + Name))
            {
                File.Delete(s);
            }
            Directory.Delete(WorkingFolder + Name);
            Logger("Done, " + Name + " successful removed!");
        }

        public void AddSoftware()
        {
            RequestInput.ShowDialog(AvailablePresets, UsedPresets);
            if (!RequestInput.Choose.Equals(""))
            {
                Logger("Adding " + RequestInput.Choose + "...");
                UsedPresets.Add(RequestInput.Choose);
                Directory.CreateDirectory(WorkingFolder + RequestInput.Choose);
                Internet.DownloadNew(SetupsContainer.GetSoftwareByName(RequestInput.Choose));
                Logger("Done");
            }
        }

        public void UpdateSelectedSoftware(string Name)
        {
            Logger("Checking Update for " + Name + "...");
            Internet.Update(SetupsContainer.GetSoftwareByName(Name));
            Logger("Done");
        }

        public void UpdateAll()
        {
            Aborted = false;
            foreach(string s in UsedPresets)
            {
                if (Aborted)
                {
                    break;
                }
                while (!Internet.completed)
                {

                }
                UpdateSelectedSoftware(s);
            }
        }

        public string[] GetAvaiblePResetsArray()
        {
            return AvailablePresets.ToArray();
        }

        public string[] GetUsedPresets()
        {
            UsedPresets.Clear();
            foreach (string s in Directory.GetDirectories(WorkingFolder))
            {
                if (AvailablePresets.Contains(s.Replace(WorkingFolder, "")))
                {
                    UsedPresets.Add(s.Replace(WorkingFolder, ""));
                }
            }
            return UsedPresets.ToArray();
        }

        private void CheckWorkingFolder()
        {
            if (!Directory.Exists(WorkingFolder))
            {
                try
                {
                    Logger("Working Folder 'MyPrograms' not found. Creating...");
                    Directory.CreateDirectory(WorkingFolder);
                    Logger("Done");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unable to create Working Folder, error: \n" + ex.ToString(),  "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Logger(string action)
        {
            Log.Items.Add(System.DateTime.Now.ToString("h:mm:ss") + "\t" + action);
        }
    }
}
