namespace TerraLink.Api.DTOs;

public record CreateUserDto(
    string? EmployeeId,
    string FullName,
    string? Email,
    string Phone,
    string Password,
    string Role,
    string Status
);