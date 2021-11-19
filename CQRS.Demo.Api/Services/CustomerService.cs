using CQRS.Demo.Api.Services.Dtos;

namespace CQRS.Demo.Api.Services;

public interface ICustomerService
{
    List<CustomerDto> Customers();
}

public class CustomerService : ICustomerService
{
    public List<CustomerDto> Customers()
    {
        return new List<CustomerDto>
        {
            new CustomerDto
            {
                Id = 1,
                FullName = "Faruk Aydemir"
            },
            new CustomerDto
            {
                Id = 2,
                FullName = "Enes Çevik"
            },
            new CustomerDto
            {
                Id = 3,
                FullName = "Özkan Koç"
            }
        };
    }
}