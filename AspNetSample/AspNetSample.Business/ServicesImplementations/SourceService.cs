using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.Abstractions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AspNetSample.Business.ServicesImplementations;

public class SourceService : ISourceService
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    private readonly IUnitOfWork _unitOfWork;

    public SourceService(GoodNewsAggregatorContext databaseContext,
        IMapper mapper, 
        IConfiguration configuration, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _configuration = configuration;
        _unitOfWork = unitOfWork;
    }

    public async Task<List<SourceDto>> GetSourcesAsync()
    {
        return await _unitOfWork.Sources.Get()
            .Select(source => _mapper.Map<SourceDto>(source))
            .ToListAsync();
    }

    public async Task<SourceDto> GetSourcesByIdAsync(Guid id)
    {
        return _mapper.Map<SourceDto>(await _unitOfWork.Sources.GetByIdAsync(id));
    }

    public async Task<int> CreateSourcesAsync(SourceDto dto)
    {
        var entity = _mapper.Map<Source>(dto);
        await _unitOfWork.Sources.AddAsync(entity);
        return await _unitOfWork.Commit();
    }
}