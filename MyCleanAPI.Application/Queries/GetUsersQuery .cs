using MediatR;
using MyCleanAPI.Application.DTOs;
using System.Collections.Generic;

namespace MyCleanAPI.Application.Queries
{
    public class GetUsersQuery : IRequest<IEnumerable<UserDto>> { }
}
