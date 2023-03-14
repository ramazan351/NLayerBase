using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Sevices
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> genericRepository;
        private readonly IUnitOfWork unitOfWork;

        public Service(IGenericRepository<T> genericRepository, IUnitOfWork unitOfWork)
        {
            this.genericRepository = genericRepository;
            this.unitOfWork = unitOfWork;
        }




        public async Task<T> AddAsync(T entity)
        {
            await this.genericRepository.AddAsync(entity);
            await this.unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await this.genericRepository.AddRangeAsync(entities);
            await this.unitOfWork.CommitAsync();

            return entities;
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await this.genericRepository.AnyAsync(expression);

        }



        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.genericRepository.GetAll().ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.genericRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            genericRepository.Remove(entity);
            await this.unitOfWork.CommitAsync();
        }

        public async Task RemoveRange(IEnumerable<T> entities)
        {
            genericRepository.RemoveRange(entities);
            await this.unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
           
             genericRepository.Update(entity);
            await this.unitOfWork.CommitAsync();

        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return genericRepository.Where(expression);
        }
    }


}
