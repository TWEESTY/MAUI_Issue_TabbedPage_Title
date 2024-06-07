using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public interface IMainViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        string Title { get; set; }
    }
}
