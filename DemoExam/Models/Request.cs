using System;
using System.Collections.Generic;

namespace DemoExam.Models;

public partial class Request
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public int Object { get; set; }

    public int? Master { get; set; }

    public int Client { get; set; }

    public int Status { get; set; }

    public int Problem { get; set; }

    public virtual Account ClientNavigation { get; set; } = null!;

    public virtual Account? MasterNavigation { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual HomeTech ObjectNavigation { get; set; } = null!;

    public virtual Problem ProblemNavigation { get; set; } = null!;

    public virtual RequestStatus StatusNavigation { get; set; } = null!;
}
