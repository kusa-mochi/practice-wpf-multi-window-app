using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Services
{
    internal enum FuncType
    {
        A,
        B,
        C
    }

    /// <summary>
    /// モードレスダイアログの表示処理実装に用いるインターフェイス。
    /// ViewからViewModelへのダイアログ表示処理のDIに用いる。
    /// </summary>
    internal interface IDialogService
    {
        Task ShowModelessDialog(FuncType funcType);
    }
}
