using System;
using System.Collections.Generic;

namespace DoctorAppointmentPortal2.Models;

public partial class Appointment
{
    public long AppointmentId { get; set; }

    public string PatientName { get; set; } = null!;

    public string? MedicalIssue { get; set; }

    public string? DoctorToVisit { get; set; }

    public string? DoctorAvailableTime { get; set; }

    public DateTime? AppointmentTime { get; set; }

    public string? AppointmentStatus { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Notes { get; set; }

    public virtual Disease? MedicalIssueNavigation { get; set; }
}
