using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyCleanAPI.Application.DTOs;
using MyCleanAPI.Application.Queries;
using MyCleanAPI.Application.Interfaces;
using MyCleanAPI.Domain.Entities;
using System.Threading.Tasks;

namespace MyCleanAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IMediator mediator, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetUsersQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CompleteAsync();
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }
    }
}
