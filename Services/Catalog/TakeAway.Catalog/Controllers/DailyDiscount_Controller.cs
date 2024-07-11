using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.Catalog.Dtos.DailyDiscountDtos;
using TakeAway.Catalog.Services.DailyDiscountServices;

namespace TakeAway.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyDiscount_Controller : ControllerBase
    {
        private readonly IDailyDiscountService _DailyDiscountService;
        public DailyDiscount_Controller(IDailyDiscountService DailyDiscountService)
        {
            _DailyDiscountService = DailyDiscountService;
        }
        [HttpGet]
        public async Task<IActionResult> DailyDiscountList()
        {
            var values = await _DailyDiscountService.GetAllDailyDiscountAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDailyDiscount(CreateDailyDiscountDto createDailyDiscountDto)
        {
            await _DailyDiscountService.CreateDailyDiscountAsync(createDailyDiscountDto);
            return Ok("Kategori Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDailyDiscount(string id)
        {
            await _DailyDiscountService.DeleteDailyDiscountAsync(id);
            return Ok("Kategori Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> UpdateDailyDiscount(string id)
        {
            var value = await _DailyDiscountService.GetByIdDailyDiscountAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDailyDiscount(UpdateDailyDiscountDto updateDailyDiscountDto)
        {
            await _DailyDiscountService.UpdateDailyDiscountAsync(updateDailyDiscountDto);
            return Ok("Kategori başarıyla güncellendi");
        }
    }
}
