namespace PPSA.CRM.API.DTOs;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string? ContactFirstName { get; set; }
    public string? ContactLastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Industry { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? City { get; set; }
    public string Country { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}

public class CreateCustomerRequest
{
    public string CompanyName { get; set; } = string.Empty;
    public string? ContactFirstName { get; set; }
    public string? ContactLastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Website { get; set; }
    public string? Industry { get; set; }
    public string? AddressLine1 { get; set; }
    public string? City { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }
    public string Country { get; set; } = "South Africa";
    public string? Notes { get; set; }
}

public class UpdateCustomerRequest : CreateCustomerRequest
{
    public string Status { get; set; } = "Active";
}