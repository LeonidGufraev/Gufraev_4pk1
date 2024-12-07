using System;
using System.Collections.Generic;

namespace DemoExam.Models;

public partial class Problem
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
