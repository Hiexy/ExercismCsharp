using System;

/// <summary>
/// Static class for managing appointments.
/// </summary>
static class Appointment
{
    /// <summary>
    /// Schedules an appointment based on a string description.
    /// </summary>
    /// <param name="appointmentDateDescription">The string description of the appointment date.</param>
    /// <returns>The DateTime of the appointment.</returns>
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    /// <summary>
    /// Checks if an appointment has passed.
    /// </summary>
    /// <param name="appointmentDate">The DateTime of the appointment.</param>
    /// <returns>True if the appointment has passed, false otherwise.</returns>
    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    /// <summary>
    /// Checks if an appointment is in the afternoon.
    /// </summary>
    /// <param name="appointmentDate">The DateTime of the appointment.</param>
    /// <returns>True if the appointment is in the afternoon, false otherwise.</returns>
    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    /// <summary>
    /// Provides a description of the appointment.
    /// </summary>
    /// <param name="appointmentDate">The DateTime of the appointment.</param>
    /// <returns>A string description of the appointment.</returns>
    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

    /// <summary>
    /// Gets the anniversary date of the current year,
    /// which happens every September 15th.
    /// /// </summary>
    /// <returns>The DateTime of the anniversary.</returns>
    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
