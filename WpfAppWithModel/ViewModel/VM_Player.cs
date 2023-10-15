using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppWithModel.Model;

namespace WpfAppWithModel.ViewModel
{
    internal class VM_Player
    {
        Player Player { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
