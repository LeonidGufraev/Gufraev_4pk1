using System;
using System.Collections.Generic;

namespace DemoExam.Models;

public partial class Account
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public string FullName { get; set; } = null!;

    public long? Phone { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Request> RequestClientNavigations { get; set; } = new List<Request>();

    public virtual ICollection<Request> RequestMasterNavigations { get; set; } = new List<Request>();

    public virtual Role? TypeNavigation { get; set; }
}
