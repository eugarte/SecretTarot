﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.Core.Services;
using SecretTarot.Module.Orders.Models;
using SecretTarot.Module.Orders.ViewModels;

namespace SecretTarot.Module.Orders.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IMediaService _mediaService;
        private readonly IRepository<Order> _orderRepository;
        private readonly IWorkContext _workContext;

        public OrderController(IRepository<Order> orderRepository, IWorkContext workContext, IMediaService mediaService)
        {
            _orderRepository = orderRepository;
            _workContext = workContext;
            _mediaService = mediaService;
        }

        [HttpGet("user/order-history")]
        public async Task<IActionResult> OrderHistoryList()
        {
            var user = await _workContext.GetCurrentUser();
            var model = await _orderRepository
                .Query()
                .Where(x => x.CreatedById == user.Id && x.ParentId == null)
                .Select(x => new OrderHistoryListItem
                {
                    Id = x.Id,
                    CreatedOn = x.CreatedOn,
                    SubTotal = x.SubTotal,
                    OrderStatus = x.OrderStatus,
                    OrderItems = x.OrderItems.Select(i => new OrderHistoryProductVm
                    {
                        ProductId = i.ProductId,
                        ProductName = i.Product.Name,
                        Quantity = i.Quantity,
                        ThumbnailImage = i.Product.ThumbnailImage.FileName,
                        ProductOptions = i.Product.OptionCombinations.Select(o => o.Value)
                    }).ToList()
                })
                .OrderByDescending(x => x.CreatedOn).ToListAsync();

            foreach (var item in model)
            {
                foreach (var product in item.OrderItems)
                {
                    product.ThumbnailImage = _mediaService.GetMediaUrl(product.ThumbnailImage);
                }
            }

            return View(model);
        }
    }
}