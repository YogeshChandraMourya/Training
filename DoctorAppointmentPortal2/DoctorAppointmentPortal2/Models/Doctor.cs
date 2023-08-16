using System;
using System.Collections.Generic;

namespace DoctorAppointmentPortal2.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string Name { get; set; } = null!;

    public string? Specialised { get; set; }

    public string? Qualification { get; set; }

    public TimeSpan? AvailableFrom { get; set; }

    public TimeSpan? AvailableTo { get; set; }

    public string? AvailableDays { get; set; }

    public string? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? ClinicAddress { get; set; }

    public virtual ICollection<Disease> Diseases { get; set; } = new List<Disease>();
}
