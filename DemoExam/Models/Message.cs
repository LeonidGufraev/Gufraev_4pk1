using System;
using System.Collections.Generic;

namespace DemoExam.Models;

public partial class Message
{
    public int Id { get; set; }

    public string Message1 { get; set; } = null!;

    public int Master { get; set; }

    public int Request { get; set; }

    public virtual Account MasterNavigation { get; set; } = null!;

    public virtual Request RequestNavigation { get; set; } = null!;
}
