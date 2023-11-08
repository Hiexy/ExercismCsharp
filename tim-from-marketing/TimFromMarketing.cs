using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string employeeID = id?.ToString($"[{id}] - ") ?? "";
        string employeeDepartment = department?.ToUpper() ?? "OWNER";

        return $"{employeeID}{name} - {employeeDepartment}";
    }
}
