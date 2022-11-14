using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Data.CQS.Commands;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.CQS.Handlers.CommandHandlers;

public class RemoveRefreshTokenCommandHandler
    : IRequestHandler<RemoveRefreshTokenCommand, Unit>
{
    private readonly GoodNewsAggregatorContext _context;
    private readonly IMapper _mapper;

    public RemoveRefreshTokenCommandHandler(GoodNewsAggregatorContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(RemoveRefreshTokenCommand command, CancellationToken token)
    {
        var refreshToken = await _context.RefreshTokens
            .FirstOrDefaultAsync(rt => command.TokenValue.Equals(rt.Token),
                token);
        _context.RefreshTokens.Remove(refreshToken);
        await _context.SaveChangesAsync(token);
        return Unit.Value;
    }
}