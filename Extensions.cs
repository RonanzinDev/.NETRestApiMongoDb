using CatalogApi.Dtos;
using CatalogApi.Entities;

namespace CatalogApi
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item) // o this aqui significa o item corrente que iremos passar na hora de chamar a função
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}