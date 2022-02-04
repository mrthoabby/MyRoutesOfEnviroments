using MyRoutesOfEnviroments.Application.Interfaces;
using MyRoutesOfEnviromentes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRoutesOfEnviromentes.Domain.Class;
using MyRoutesOfEnviromentes.Domain.Interfaces;

namespace MyRoutesOfEnviroments.Application.Services
{
    public class ServiceRoute : IServices<Route, Guid>
    {
        private readonly IRepository<Route,Guid> _routeRepository;

        public ServiceRoute(IRepository<Route,Guid> repository) => _routeRepository = repository ?? throw new NullReferenceException("Don't exist this repository");

        public async Task<OperationResult> AddAsync(Route entity)
        {
            var result = await _routeRepository.AddAsync(entity);
            return result;
        }

        public async Task<OperationResult> DeleteAsync(Guid idEntity)
        {
            var result = await _routeRepository.DeleteAsync(idEntity);
            return result;
        }

        public async Task<OperationResult> EditAsync(Route entity)
        {
            var result = await _routeRepository.EditAsync(entity);
            return result;
        }

        public async Task<List<Route>> GetAllAsync()
        {
            var result = await _routeRepository.GetAllAsync();
            return result;
        }

        public async Task<Route> GetAsync(Guid idEntity)
        {
            var result = await _routeRepository.GetAsync(idEntity);
            return result;
        }
    }
}
