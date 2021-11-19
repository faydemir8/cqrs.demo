using CQRS.Demo.Api.CQRS.ResponseModels;
using MediatR;

namespace CQRS.Demo.Api.CQRS.Commands;

public class AddCustomerCommand: IRequest<AddCustomerResponseModel>
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public AddCustomerCommand(int id, string fullName)
    {
        Id = id;
        FullName = fullName;
    }
}