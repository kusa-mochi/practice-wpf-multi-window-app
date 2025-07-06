using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.ViewModels
{
    internal partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        private bool isButtonAEnabled = true;

        [ObservableProperty]
        private bool isButtonBEnabled = true;

        [ObservableProperty]
        private bool isButtonCEnabled = true;

        [RelayCommand]
        private void OpenWindowA()
        {
            IsButtonAEnabled = false;
            Debug.WriteLine("open window A");
        }

        [RelayCommand]
        private void OpenWindowB()
        {
            IsButtonBEnabled = false;
            Debug.WriteLine("open window B");
        }

        [RelayCommand]
        private void OpenWindowC()
        {
            IsButtonCEnabled = false;
            Debug.WriteLine("open window C");
        }
    }
}
