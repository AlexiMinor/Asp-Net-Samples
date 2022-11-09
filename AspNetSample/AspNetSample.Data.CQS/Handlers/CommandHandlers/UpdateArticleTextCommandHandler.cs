﻿using AspBetSample.DataBase;
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
    private readonly IMapper _mapper;

    public UpdateArticleTextCommandHandler(GoodNewsAggregatorContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateArticleTextCommand command, CancellationToken token)
    {
        var article = await _context.Articles
            .FirstOrDefaultAsync(a => a.Id.Equals(command.Id), token);
        if (article!=null)
        {
            article.Text = command.Text;
            await _context.SaveChangesAsync(token);
            return Unit.Value;
        }
        else
        {
            throw new ArgumentException("blalblablab");
        }
       
    }
}