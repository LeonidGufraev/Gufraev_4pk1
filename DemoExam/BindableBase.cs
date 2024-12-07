using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoExam
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void SetProperty<T>(ref T member, T value,
            [CallerMemberName]string property="")
        {
            if (object.Equals(member,value)) return;
            member = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        protected virtual void OnPropertyChanged(string property) =>
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
    }
}
