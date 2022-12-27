using Microsoft.Extensions.DependencyInjection;
using OSICI.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSICI.Product;

public static class Extension
{
    public static void AddPI(this IServiceCollection Services, Name Name, Type Type) => Services.AddSingleton(x => new Infomation(Name, Type));
    public static string GetMainDomain(this Name Name) => Name switch { 
        Name.InterConnectingInfo=> "interconnecting.info",
        _ => throw typeof(Extension).Exception("GetMainDomain", (404, "Contact pirasath Luxchumykanthan")),
    };
}
