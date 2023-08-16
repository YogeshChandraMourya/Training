using System;
using System.Collections.Generic;

namespace DoctorAppointmentPortal2.Models;

public partial class Disease
{
    public int DiseaseId { get; set; }

    public string DiseaseName { get; set; } = null!;

    public int? SuitableDoctor { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Doctor? SuitableDoctorNavigation { get; set; }
}
