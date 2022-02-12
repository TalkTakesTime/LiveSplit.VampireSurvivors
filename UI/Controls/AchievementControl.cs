using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using LiveSplit.VampireSurvivors.Attributes;
using LiveSplit.VampireSurvivors.Images;
using LiveSplit.VampireSurvivors.Model.SaveData;
using DescriptionAttribute = LiveSplit.VampireSurvivors.Attributes.DescriptionAttribute;

namespace LiveSplit.VampireSurvivors.UI.Controls {
    public partial class AchievementControl : UserControl, INotifyPropertyChanged {
        private static readonly ImageResource CheckedResource = new ImageResource("checkbox_checked.png");
        private static readonly ImageResource UncheckedResource = new ImageResource("checkbox.png");

        private readonly ImageResource _resource;

        private bool _isAchieved;

        public bool IsAchieved {
            get => _isAchieved;
            set {
                _isAchieved = value;
                // indicate that the image has changed
                OnPropertyChanged(nameof(CheckedImage));
            }
        }

        public Image CheckedImage => IsAchieved ? CheckedResource.Image : UncheckedResource.Image;

        public AchievementControl() {
            InitializeComponent();
        }

        public AchievementControl(Achievement ach) : this() {
            _resource = ach.GetResource();

            if (ach.GetAttribute<DescriptionAttribute>() is DescriptionAttribute attr) {
                var tt = new ToolTip();
                tt.SetToolTip(imgAchievement, attr.Description);
            }
        }

        private void AchievementControl_Load(object sender, EventArgs e) {
            imgCheckbox.DataBindings.Add("Image", this, nameof(CheckedImage));
            imgAchievement.Image = _resource.Image;
            Disposed += OnDisposed;
        }

        private void OnDisposed(object sender, EventArgs e) {
            _resource.Dispose();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
