using AspBetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;
using AspNetSampleMvcApp.Models;
using AutoMapper;

namespace AspNetSampleMvcApp.MappingProfiles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, ArticleDto>();
        CreateMap<ArticleDto, Article>();

            

        CreateMap<ArticleDto, ArticleModel>().ReverseMap();

    }
}