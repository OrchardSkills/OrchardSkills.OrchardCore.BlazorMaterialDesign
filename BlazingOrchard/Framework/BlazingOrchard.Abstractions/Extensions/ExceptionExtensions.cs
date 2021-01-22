using System;
using System.Runtime.InteropServices;
using System.Security;

namespace BlazingOrchard.Extensions
{
    public static class ExceptionExtensions
    {
        public static bool IsFatal(this Exception ex)
        {
            return
                ex is OutOfMemoryException ||
                ex is SecurityException ||
                ex is SEHException;
        }
    }
}
