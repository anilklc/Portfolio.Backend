using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.Contact.RemoveContact
{
    public class RemoveContactCommandHandler : IRequestHandler<RemoveContactCommandRequest, RemoveContactCommandRespnose>
    {
        private readonly IContactWriteRepository _contactWriteRepository;

        public RemoveContactCommandHandler(IContactWriteRepository contactWriteRepository)
        {
            _contactWriteRepository = contactWriteRepository;
        }

        public async Task<RemoveContactCommandRespnose> Handle(RemoveContactCommandRequest request, CancellationToken cancellationToken)
        {
            await _contactWriteRepository.RemoveAsync(request.Id);
            await _contactWriteRepository.SaveAsync();
            return new();
        }
    }
}
