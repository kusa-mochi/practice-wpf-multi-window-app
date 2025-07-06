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
        private async Task OpenWindowA()
        {
            if (IsWindowAOpened) return;

            IsWindowAOpened = true;
            Debug.WriteLine("open window A");

            // モードレスダイアログを表示し、閉じられるまで待機する。
            await _dialogService.ShowModelessDialog(FuncType.A);

            IsWindowAOpened = false;
        }

        [RelayCommand]
        private async Task OpenWindowB()
        {
            if (IsWindowBOpened) return;

            IsWindowBOpened = true;
            Debug.WriteLine("open window B");

            // モードレスダイアログを表示し、閉じられるまで待機する。
            await _dialogService.ShowModelessDialog(FuncType.B);

            IsWindowBOpened = false;
        }

        [RelayCommand]
        private async Task OpenWindowC()
        {
            if (IsWindowCOpened) return;

            IsWindowCOpened = true;
            Debug.WriteLine("open window C");

            // モードレスダイアログを表示し、閉じられるまで待機する。
            await _dialogService.ShowModelessDialog(FuncType.C);

            IsWindowCOpened = false;
        }
    }
}
