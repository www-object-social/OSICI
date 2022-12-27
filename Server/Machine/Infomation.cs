using Microsoft.EntityFrameworkCore;
using OSICI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSICI.Server.Machine;

public class Infomation
{
    public string Name => System.Environment.MachineName;
    public Infomation(IDbContextFactory<OSICI_Context> DBContextFactory) {
        using var DB = DBContextFactory.CreateDbContext();
        if (DB.ServerMachineDatas.Any(x => x.Name == this.Name)) return;
        DB.ServerMachineDatas.Add(new ServerMachineData { IsActive=false, Id=Guid.NewGuid(), Name=this.Name });
        DB.SaveChanges(); 
    }
}
