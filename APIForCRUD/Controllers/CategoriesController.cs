using APIForCRUD.Data;
using APIForCRUD.Models.Domain;
using APIForCRUD.Models.DTO;
using APIForCRUD.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIForCRUD.Controllers
{
    //https://localhost:xxxx/api/Categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        //
        [HttpPost]
        public async Task<ActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            //Map DTO to Domain model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await categoryRepository.CreateAsync(category);

            var responce = new CategoryDto
            {
                Id = category.Id,
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            return Ok(responce);

        }
    }
}
