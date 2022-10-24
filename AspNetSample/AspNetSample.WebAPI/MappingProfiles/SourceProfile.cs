using AspBetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;

namespace AspNetSample.Mappers.MappingProfiles;

public class SourceProfile : Profile
{
    public SourceProfile()
    {
        CreateMap<Source, SourceDto>();
        CreateMap<SourceDto, Source>();


    }
}