using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Services;

namespace TestApp.ViewModels
{
    internal partial class MainViewModel: ObservableObject
    {
        private readonly IDialogService _dialogService;

        internal MainViewModel(IDialogService ds)
        {
            _dialogService = ds;
        }

        [ObservableProperty]
        private bool isWindowAOpened = false;

        [ObservableProperty]
        private bool isWindowBOpened = false;

        [ObservableProperty]
        private bool isWindowCOpened = false;

        [RelayCommand]
        private void OpenWindowA()
        {
            if (IsWindowAOpened) return;

            IsWindowAOpened = true;
            Debug.WriteLine("open window A");
            _dialogService.ShowModelessDialog(FuncType.A);
        }

        [RelayCommand]
        private void OpenWindowB()
        {
            if (IsWindowBOpened) return;

            IsWindowBOpened = true;
            Debug.WriteLine("open window B");
            _dialogService.ShowModelessDialog(FuncType.B);
        }

        [RelayCommand]
        private void OpenWindowC()
        {
            if (IsWindowCOpened) return;

            IsWindowCOpened = true;
            Debug.WriteLine("open window C");
            _dialogService.ShowModelessDialog(FuncType.C);
        }
    }
}
