using CQRS.Demo.Api.CQRS.ResponseModels;
using MediatR;

namespace CQRS.Demo.Api.CQRS.Queries;

public class GetCustomerByIdQuery : IRequest<CustomerResponseModel>
{
    public int Id { get; set; }

    public GetCustomerByIdQuery(int id)
    {
        Id = id;
    }
}