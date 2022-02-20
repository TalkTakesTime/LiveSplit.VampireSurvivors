using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

// ReSharper disable LocalizableElement

namespace LiveSplit.UI.Components {
    public partial class VampireSurvivorsSettings : UserControl {
        private const string InstallDirSetting = "VsInstallDir";

        private const string VampireSurvivorsBinary = "VampireSurvivors.exe";
        private static bool ContainsBinary(string dir) =>
            dir != null && File.Exists(Path.Combine(dir, VampireSurvivorsBinary));

        public string VsInstallDir { get; set; }

        public VampireSurvivorsSettings() {
            InitializeComponent();
        }

        private void VampireSurvivorsSettings_Load(object sender, EventArgs e) {
            if (ContainsBinary(VsInstallDir) || TrySetInstallDir()) {
                txtVsDir.Text = VsInstallDir;
                fbrowsVsDir.SelectedPath = VsInstallDir;
            } else {
                txtVsDir.Text = string.Empty;
                fbrowsVsDir.SelectedPath = string.Empty;
            }
        }

        private void txtVsDir_TextChanged(object sender, EventArgs e) {
            VsInstallDir = txtVsDir.Text;
        }

        private void btnSelectVsDir_Click(object sender, EventArgs e) {
            DialogResult res = fbrowsVsDir.ShowDialog();
            if (res != DialogResult.OK) {
                return;
            }

            string vsDir = fbrowsVsDir.SelectedPath;

            // test if we're in a valid install dir
            if (!ContainsBinary(vsDir)) {
                MessageBox.Show(
                    $"Could not find {VampireSurvivorsBinary} in the selected directory.",
                    "Invalid Vampire Survivors directory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtVsDir.Text = "";
                VsInstallDir = null;
                return;
            }

            txtVsDir.Text = vsDir;
            VsInstallDir = vsDir;
        }

        private bool TrySetInstallDir() {
            var cands = new string[] {
                Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles),
            };

            foreach (string cand in cands) {
                string maybeDir = Path.Combine(cand, "Steam", "steamapps", "common", "Vampire Survivors");
                if (ContainsBinary(maybeDir)) {
                    VsInstallDir = maybeDir;
                    return true;
                }
            }

            return false;
        }

        private int CreateSettingsNode(XmlDocument doc, XmlElement parent) {
            return SettingsHelper.CreateSetting(doc, parent, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString()) ^
                   SettingsHelper.CreateSetting(doc, parent, InstallDirSetting, VsInstallDir);
        }

        public XmlNode GetSettings(XmlDocument doc) {
            XmlElement parent = doc.CreateElement("Settings");
            CreateSettingsNode(doc, parent);
            return parent;
        }

        public void SetSettings(XmlNode node) {
            if (!(node is XmlElement elem)) {
                return;
            }

            VsInstallDir = SettingsHelper.ParseString(elem[InstallDirSetting]);
        }

        public int GetSettingsHashCode() => CreateSettingsNode(null, null);
    }
}
