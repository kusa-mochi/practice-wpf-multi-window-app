using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestApp.Views;

namespace TestApp.Services
{
    /// <summary>
    /// IDialogServiceインターフェイスの実装例。
    /// ViewModelで指定した機能（FuncType）に応じたウィンドウを表示する処理を定義している。
    /// ウィンドウが閉じられたことをMainViewModelで検知するため、Taskを返す設計としている。
    /// </summary>
    internal class DialogService : IDialogService
    {
        public Task ShowModelessDialog(FuncType funcType)
        {
            var tcs = new TaskCompletionSource<bool>(); // ダイアログが閉じられたら完了するTask

            Window dialog = funcType switch
            {
                FuncType.A => new WindowA(),
                FuncType.B => new WindowB(),
                FuncType.C => new WindowC(),
                _ => throw new Exception("invalid func type")
            };

            dialog.Closed += (sender, e) =>
            {
                tcs.SetResult(true);
            };

            dialog.Show();

            return tcs.Task;
        }
    }
}
