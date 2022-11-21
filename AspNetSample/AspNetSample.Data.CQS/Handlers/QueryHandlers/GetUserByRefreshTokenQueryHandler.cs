using AspBetSample.DataBase;
using AspNetSample.Core.DataTransferObjects;
using AspNetSample.Data.CQS.Queries;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AspNetSample.Data.CQS.Handlers.QueryHandlers;

public class GetUserByRefreshTokenQueryHandler : IRequestHandler<GetUserByRefreshTokenQuery, UserDto?>
{
    private readonly GoodNewsAggregatorContext _context;
    private readonly IMapper _mapper;

    public GetUserByRefreshTokenQueryHandler(GoodNewsAggregatorContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserDto?> Handle(GetUserByRefreshTokenQuery request,
        CancellationToken cancellationToken)
    {
        var user = (await _context.RefreshTokens
            .Include(token => token.User)
            .ThenInclude(user => user.Role)
            .AsNoTracking()
            .FirstOrDefaultAsync(token => token.Token.Equals(request.RefreshToken),
                cancellationToken))?.User;

        return _mapper.Map<UserDto>(user);
    }
}