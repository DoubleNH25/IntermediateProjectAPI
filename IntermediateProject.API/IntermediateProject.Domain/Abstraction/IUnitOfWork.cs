using IntermediateProject.Domain.Abstraction.Entity;
namespace IntermediateProject.Domain.Abstraction
{
	public interface IUnitOfWork
	{
		Task CommitAsync(
		 CancellationToken cancellationToken = default,
		 bool checkForConcurrency = false);

		IGenericRepository<TEntity> Repository<TEntity>()
			where TEntity : BaseEntity;
	}
}
