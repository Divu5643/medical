using System;
using System.Collections.Generic;

namespace medicalApp.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int? UserId { get; set; }

    public string? PatientName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public long? Phone { get; set; }

    public string? MedicalHistory { get; set; }

    public int? DoctorId { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Doctor? Doctor { get; set; }

    public virtual User? User { get; set; }
}
