using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ABCRestaurantDataLayer.Repository;
using ABCRestaurantDataLayer.Entitys;

namespace ABCResturantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(OrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        [HttpGet]
        public List<Order> GetAllOrders()
        {
            List<Order> _List = this._orderRepository.GetAllOrders().ToList();
            return _List;
        }

        
        [HttpPost]
        public void InsertOrder(Order order)
        {
            this._orderRepository.AddOrder(order);
        }

        [HttpDelete]
        public bool DeleteOrder(int Id)
        {
            bool _result = this._orderRepository.DeleteOrder(Id);
            return _result;
        }
        [HttpGet]
          public Order GetOrder(int Id)
        {
            Order _order = this._orderRepository.GetOrderDetails(Id);
            return _order;
        }

    }
}