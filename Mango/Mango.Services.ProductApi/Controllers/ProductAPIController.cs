using AutoMapper;
using Mango.Services.ProductApi.Models;
using Mango.Services.ProductAPI.Data;
using Mango.Services.ProductAPI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    [Authorize]
    public class ProductAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IMapper mapper;
        private ResponseDTO _response;

        public ProductAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            this.mapper = mapper;
            _response = new ResponseDTO();
        }

        [HttpGet]
        public ResponseDTO Get()
        {
            try
            {
                IEnumerable<Product> objList = _db.Products.ToList();
                _response.Result = mapper.Map<IEnumerable<ProductDto>>(objList);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }


        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO Get(int id)
        {
            try
            {
                Product obj = _db.Products.First(x => x.ProductId == id);
                _response.Result = mapper.Map<ProductDto>(obj);

            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }



        [HttpPost]
   //     [Authorize(Roles = "Admin")]
        public ResponseDTO Post([FromBody] ProductDto ProductDto)
        {
            try
            {
                Product obj = mapper.Map<Product>(ProductDto);
                _db.Products.Add(obj);
                _db.SaveChanges();
                _response.Result = mapper.Map<ProductDto>(obj);

            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }


        [HttpPut]
    //    [Authorize(Roles = "Admin")]
        public ResponseDTO Put([FromBody] ProductDto ProductDto)
        {
            try
            {
                Product obj = mapper.Map<Product>(ProductDto);
                _db.Products.Update(obj);
                _db.SaveChanges();
                _response.Result = mapper.Map<ProductDto>(obj);

            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }


        [HttpDelete]
        [Route("{id:int}")]
    //    [Authorize(Roles = "Admin")]
        public ResponseDTO Delete(int id)
        {

            try
            {
                Product obj = _db.Products.First(x => x.ProductId == id);
                _db.Products.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }
    }
}
