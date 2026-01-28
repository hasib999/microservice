using MediatR;

namespace Ordering.Application.Features.Orders.Quries.GetOrdersByUserName
{
    public class GetOrdersByUserQuery : IRequest<List<OrderVm>>
    {
        public string UserName { get; set; }

        public GetOrdersByUserQuery(string userName)
        {
            UserName = userName;
        }
    }
}
