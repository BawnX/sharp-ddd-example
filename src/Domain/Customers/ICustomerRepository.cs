namespace Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer?> GetByIDAsync(CustomerId id);
    Task Add(Customer customer);
}