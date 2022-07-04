using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashboardClient.Models.Dto;
using DashboardClient.Models.Entities;
using Domain.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DashboardClient.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpRequest _httpRequest;

        public DashboardController(IConfiguration configuration, IHttpRequest httpRequest)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _httpRequest = httpRequest ?? throw new ArgumentNullException(nameof(httpRequest));
        }

        [HttpGet(nameof(GetAllProducts))]
        [ProducesResponseType(typeof(ProductsDto), StatusCodes.Status200OK)]
        public async Task<ProductsDto> GetAllProducts() => await _httpRequest.Get<ProductsDto>(path: _configuration.GetValue<string>("BestBuyPath"));
    }
}
