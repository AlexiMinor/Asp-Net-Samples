using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Data.CQS.Commands;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.CQS.Handlers.CommandHandlers;

public class UpdateArticleTextCommandHandler
    : IRequestHandler<UpdateArticleTextCommand, Unit>
{
    private readonly GoodNewsAggregatorContext _context;

    public UpdateArticleTextCommandHandler(GoodNewsAggregatorContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateArticleTextCommand byIdCommand, CancellationToken token)
    {
        var x = byIdCommand.Text;
        var article = await _context.Articles
            .FirstOrDefaultAsync(a => a.Id.Equals(byIdCommand.Id), token);
        if (article!=null)
        {
            article.Text = byIdCommand.Text;
            await _context.SaveChangesAsync(token);
            return Unit.Value;
        }
        else
        {
            throw new ArgumentException("blalblablab");
        }
       
    }
}