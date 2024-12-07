using System;
using System.Collections.Generic;

namespace DemoExam.Models;

public partial class HomeTech
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string? RepairParts { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
