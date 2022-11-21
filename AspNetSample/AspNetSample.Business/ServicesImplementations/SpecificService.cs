using AspBetSample.DataBase.Entities;
using AspNetSample.Core.Abstractions;
using AspNetSample.Core.DataTransferObjects;
using AutoMapper;

namespace AspNetSample.Business.ServicesImplementations;

public class SpecificService : ISpecificService
{
    private readonly IMapper _mapper;
    
    public SpecificService(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public Article UpdateArticle(ArticleDto dto, string newText, int rate)
    {
        var ent = _mapper.Map<Article>(dto);

        ent.Text = newText;
        ent.Rate = rate;
       
        return ent;
    }
}