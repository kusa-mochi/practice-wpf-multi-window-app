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

    internal interface IDialogService
    {
        Task ShowModelessDialog(FuncType funcType);
    }
}
