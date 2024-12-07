using System;
using System.Collections.Generic;

namespace DemoExam.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
