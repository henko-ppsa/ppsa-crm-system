namespace PPSA.CRM.Core.DTOs;

public class CustomerDto
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string? Industry { get; set; }
    public string? Website { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingCountry { get; set; }
    public string? Phone { get; set; }
    public string Status { get; set; } = string.Empty;
    public string? AssignedToName { get; set; }
    public int ContactCount { get; set; }
    public int ProjectCount { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class CreateCustomerRequest
{
    public string CompanyName { get; set; } = string.Empty;
    public string? Industry { get; set; }
    public string? Website { get; set; }
    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingCountry { get; set; }
    public string? Phone { get; set; }
    public string? TaxNumber { get; set; }
    public string Status { get; set; } = "Active";
    public int? AssignedToUserId { get; set; }
    public string? Notes { get; set; }
}

public class UpdateCustomerRequest : CreateCustomerRequest
{
}

public class CustomerFilterRequest
{
    public string? Search { get; set; }
    public string? Status { get; set; }
    public int? AssignedToUserId { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}

public class PagedResult<T>
{
    public List<T> Items { get; set; } = new();
    public int TotalCount { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}