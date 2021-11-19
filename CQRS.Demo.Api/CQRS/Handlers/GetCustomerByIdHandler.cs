using CQRS.Demo.Api.CQRS.Queries;
using CQRS.Demo.Api.CQRS.ResponseModels;
using CQRS.Demo.Api.Services;
using MediatR;

namespace CQRS.Demo.Api.CQRS.Handlers;

public class GetCustomerByIdHandler: IRequestHandler<GetCustomerByIdQuery, CustomerResponseModel>
{
    private readonly ICustomerService _customerService;

    public GetCustomerByIdHandler(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    public async Task<CustomerResponseModel> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var customer = _customerService.Customers().FirstOrDefault(x => x.Id == request.Id);
        return customer !=null ? new CustomerResponseModel
        {
            Id = customer.Id,
            FullName = customer.FullName
        }: null;
    }
}