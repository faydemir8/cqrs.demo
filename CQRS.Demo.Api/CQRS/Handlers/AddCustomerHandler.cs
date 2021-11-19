using CQRS.Demo.Api.CQRS.Commands;
using CQRS.Demo.Api.CQRS.ResponseModels;
using CQRS.Demo.Api.Services;
using CQRS.Demo.Api.Services.Dtos;
using MediatR;

namespace CQRS.Demo.Api.CQRS.Handlers;

public class AddCustomerHandler: IRequestHandler<AddCustomerCommand, AddCustomerResponseModel>
{
    private readonly ICustomerService _customerService;

    public AddCustomerHandler(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    public async Task<AddCustomerResponseModel> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
    {
        _customerService.Customers().Add(new CustomerDto
        {
            FullName = request.FullName,
            Id = request.Id
        });
        return new AddCustomerResponseModel
        {
            Id = request.Id,
            IsSuccess = true
        };
    }
}