using AutoMapper;
using ECommerce.Api.Orders.Db;
using ECommerce.Api.Orders.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Api.Orders.Providers
{
    public class OrdersProvider : IOrdersProvider
    {
        private readonly OrdersDbContext dbContext;
        private readonly ILogger<OrdersProvider> logger;
        private readonly IMapper mapper;
        public OrdersProvider(OrdersDbContext dbContext, ILogger<OrdersProvider> logger, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.logger = logger;
            this.mapper = mapper;
        }
        public async Task<(bool IsSuccess, IEnumerable<Models.Order> Orders, string ErrorMessage)> GetOrdersAsync(int customerId)
        {
            Models.OrderItem oi = new Models.OrderItem();
            oi.UnitPrice = 11.2m;
            oi.Quantity = 1;
            oi.ProductId = 1;
            oi.Id = 1;

            List<Models.OrderItem> orderitems = new List<Models.OrderItem>();
            orderitems.Add(oi);
            List<Models.Order> orderss = new List<Models.Order>();
            orderss.Add(new Models.Order() { Id = 1, CustomerId = 1, Items = (orderitems), OrderDate = new DateTime(2021, 12, 01), Total = 25.19m });

            return (true, orderss, null);
        }
    }
}
