using CQRS.Demo.Api.Services.Dtos;

namespace CQRS.Demo.Api.CQRS.ResponseModels;

public class CustomerResponseModel : CustomerDto
{
}

public class AddCustomerResponseModel 
{
    public bool IsSuccess { get; set; }
    public int Id { get; set; }
}