﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dashboard.Core
{
    class ObservableObject : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
