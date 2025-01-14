using Ryujinx.Ava.UI.ViewModels;
using System.IO;

namespace Ryujinx.Ava.UI.Models
{
    public class ModModel : BaseModel
    {
        private bool _enabled;

        public bool Enabled
        {
            get => _enabled;
            set
            {
                _enabled = value;
                OnPropertyChanged();
            }
        }

        public string Path { get; }
        public string Name { get; }

        public ModModel(string path, string name, bool enabled)
        {
            Path = path;
            Name = name;
            Enabled = enabled;
        }
    }
}
