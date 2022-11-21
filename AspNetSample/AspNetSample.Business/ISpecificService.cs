using AspBetSample.DataBase.Entities;
using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Business;

public interface ISpecificService
{
    Article UpdateArticle(ArticleDto dto, string newText, int rate);
}