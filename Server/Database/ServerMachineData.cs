using System;
using System.Collections.Generic;

namespace OSICI.Database;

public partial class ServerMachineData
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }
}
