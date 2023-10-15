using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModel.Model;

namespace WpfAppWithModel.ViewModel
{
    internal class VM_Crop : INotifyPropertyChanged
    {
        public Crop Crop;

        public string Name
        {
            get 
            { 
                return Crop.Name;
            }
            set 
            { 
                Crop.Name = value;
                RaisePropertyChangedEvent();
            }
        }

        public int Height
        {
            get
            {
                return Crop.Height;
            }
            set
            {
                Crop.Height = value;
                RaisePropertyChangedEvent();
            }
        }

        public VM_Crop(Crop crop)
        {
            Crop = crop;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void RaisePropertyChangedEvent([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
