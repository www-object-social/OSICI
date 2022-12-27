using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSICI.Exception;
public class Handler:System.Exception
{
    private List<int> _StatusCodes = new List<int>();
    public readonly Type Type;
    public readonly string Method;
    public int[] StatusCodes => _StatusCodes.ToArray();
    private static IEnumerable<string> Init(Type Type,string Method, params (int StatusCode, string Message)[] Datas) {
        if (Type.FullName is not null)
            yield return $"{Type.FullName} <=> {Method};{System.Environment.NewLine}";
        foreach (var Data in Datas)
            yield return $"{Data.StatusCode}:{System.Environment.NewLine}{Data.Message}";
    }
    internal Handler(Type Type, string Method, params (int StatusCodes,string Message)[] Values):base(string.Join(System.Environment.NewLine, Init(Type, Method, Values).ToArray())){
        this.Type = Type;
        this.Method = Method;
        foreach (var Data in Values)
            _StatusCodes.Add(Data.StatusCodes);
    }
}
