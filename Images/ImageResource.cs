using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace LiveSplit.VampireSurvivors.Images {
    public class ImageResource : IDisposable {
        private string _resourceName;
        
        private Image _image;
        public Image Image => _image ?? (_image = Image.FromStream(GetImageResource(_resourceName)));

        public ImageResource(string resourceName) {
            _resourceName = resourceName;
        }
        
        private static Stream GetImageResource(string name) => Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream("LiveSplit.VampireSurvivors.Images." + name);

        public void Dispose() {
            _image?.Dispose();
        }
    }
}
