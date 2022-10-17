using AspNetSample.Core.DataTransferObjects;

namespace AspNetSampleMvcApp.Models;

public class ArticlesListWithUserRoleModel
{
    public List<ArticleDto> Articles { get; set; }

    public bool IsAdmin { get; set; }
}