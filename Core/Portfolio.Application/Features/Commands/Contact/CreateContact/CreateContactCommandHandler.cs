using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.Contact.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest, CreateContactCommandResponse>
    {
        private readonly IContactWriteRepository _contactWriteRepository;

        public CreateContactCommandHandler(IContactWriteRepository contactWriteRepository)
        {
            _contactWriteRepository = contactWriteRepository;
        }

        public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
        {
            await _contactWriteRepository.AddAsync(new()
            {
                Email = request.Email,
                Mobile = request.Mobile,
                Message = request.Message,
            });
            await _contactWriteRepository.SaveAsync();
            return new();
        }
    }
}
