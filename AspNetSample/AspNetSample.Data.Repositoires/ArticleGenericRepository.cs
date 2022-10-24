﻿using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Data.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.Repositories;

public class ArticleGenericRepository : Repository<Article>, IAdditionalArticleRepository
{
    public ArticleGenericRepository(GoodNewsAggregatorContext database) 
        : base(database)
    {
    }

    public async Task UpdateArticleTextAsync(Guid id, string text)
    {
        var article = await DbSet.FirstOrDefaultAsync(a => a.Id.Equals(id));
        if (article!= null)
        {
            article.Text = text;
        }
    }
}