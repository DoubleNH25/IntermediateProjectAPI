using System.ComponentModel.DataAnnotations;

namespace IntermediateProject.Domain.Entities.Products.DTOs
{
	public abstract class BaseProductDto
	{
		[Required]
		[MaxLength(45)]
		public string Description { get; set; } = null!;

		[Required]
		public decimal UnitPrice { get; set; }
	}

	public class CreateProductDto : BaseProductDto;

	public class UpdateProductDto : BaseProductDto;



}
