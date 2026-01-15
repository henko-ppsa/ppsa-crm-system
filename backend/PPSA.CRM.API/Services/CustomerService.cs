using Microsoft.EntityFrameworkCore;
using PPSA.CRM.API.DTOs;
using PPSA.CRM.Core.Entities;
using PPSA.CRM.Infrastructure.Data;

namespace PPSA.CRM.API.Services;

public interface ICustomerService
{
    Task<List<CustomerDto>> GetAllCustomersAsync();
    Task<CustomerDto?> GetCustomerByIdAsync(Guid id);
    Task<CustomerDto> CreateCustomerAsync(CreateCustomerRequest request, Guid userId);
    Task<CustomerDto?> UpdateCustomerAsync(Guid id, UpdateCustomerRequest request);
    Task<bool> DeleteCustomerAsync(Guid id);
}

public class CustomerService : ICustomerService
{
    private readonly CrmDbContext _context;

    public CustomerService(CrmDbContext context)
    {
        _context = context;
    }

    public async Task<List<CustomerDto>> GetAllCustomersAsync()
    {
        return await _context.Customers
            .OrderByDescending(c => c.CreatedAt)
            .Select(c => new CustomerDto
            {
                Id = c.Id,
                CompanyName = c.CompanyName,
                ContactFirstName = c.ContactFirstName,
                ContactLastName = c.ContactLastName,
                Email = c.Email,
                Phone = c.Phone,
                Industry = c.Industry,
                Status = c.Status,
                City = c.City,
                Country = c.Country,
                CreatedAt = c.CreatedAt
            })
            .ToListAsync();
    }

    public async Task<CustomerDto?> GetCustomerByIdAsync(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null) return null;

        return new CustomerDto
        {
            Id = customer.Id,
            CompanyName = customer.CompanyName,
            ContactFirstName = customer.ContactFirstName,
            ContactLastName = customer.ContactLastName,
            Email = customer.Email,
            Phone = customer.Phone,
            Industry = customer.Industry,
            Status = customer.Status,
            City = customer.City,
            Country = customer.Country,
            CreatedAt = customer.CreatedAt
        };
    }

    public async Task<CustomerDto> CreateCustomerAsync(CreateCustomerRequest request, Guid userId)
    {
        var customer = new Customer
        {
            CompanyName = request.CompanyName,
            ContactFirstName = request.ContactFirstName,
            ContactLastName = request.ContactLastName,
            Email = request.Email,
            Phone = request.Phone,
            Website = request.Website,
            Industry = request.Industry,
            AddressLine1 = request.AddressLine1,
            City = request.City,
            StateProvince = request.StateProvince,
            PostalCode = request.PostalCode,
            Country = request.Country,
            Notes = request.Notes,
            CreatedBy = userId,
            Status = "Active"
        };

        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        return new CustomerDto
        {
            Id = customer.Id,
            CompanyName = customer.CompanyName,
            ContactFirstName = customer.ContactFirstName,
            ContactLastName = customer.ContactLastName,
            Email = customer.Email,
            Phone = customer.Phone,
            Industry = customer.Industry,
            Status = customer.Status,
            City = customer.City,
            Country = customer.Country,
            CreatedAt = customer.CreatedAt
        };
    }

    public async Task<CustomerDto?> UpdateCustomerAsync(Guid id, UpdateCustomerRequest request)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null) return null;

        customer.CompanyName = request.CompanyName;
        customer.ContactFirstName = request.ContactFirstName;
        customer.ContactLastName = request.ContactLastName;
        customer.Email = request.Email;
        customer.Phone = request.Phone;
        customer.Website = request.Website;
        customer.Industry = request.Industry;
        customer.Status = request.Status;
        customer.AddressLine1 = request.AddressLine1;
        customer.City = request.City;
        customer.StateProvince = request.StateProvince;
        customer.PostalCode = request.PostalCode;
        customer.Country = request.Country;
        customer.Notes = request.Notes;
        customer.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new CustomerDto
        {
            Id = customer.Id,
            CompanyName = customer.CompanyName,
            ContactFirstName = customer.ContactFirstName,
            ContactLastName = customer.ContactLastName,
            Email = customer.Email,
            Phone = customer.Phone,
            Industry = customer.Industry,
            Status = customer.Status,
            City = customer.City,
            Country = customer.Country,
            CreatedAt = customer.CreatedAt
        };
    }

    public async Task<bool> DeleteCustomerAsync(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null) return false;

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return true;
    }
}