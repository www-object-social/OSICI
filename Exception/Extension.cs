using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSICI.Exception;

public static class Extension
{
    public static Handler Exception(this Type Type,string Method, params (int StatusCode, string Message)[] Datas) => new Handler(Type, Method, Datas);
}
