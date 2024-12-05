using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.TestiMonials.RemoveTestiMonials
{
    public class RemoveTestiMonialsCommandHandler : IRequestHandler<RemoveTestiMonialsCommandRequest, RemoveTestiMonialsCommandResponse>
    {
        private readonly ITestiMonialsWriteRepository _testiMonialsWriteRepository;

        public RemoveTestiMonialsCommandHandler(ITestiMonialsWriteRepository testiMonialsWriteRepository)
        {
            _testiMonialsWriteRepository = testiMonialsWriteRepository;
        }

        public async Task<RemoveTestiMonialsCommandResponse> Handle(RemoveTestiMonialsCommandRequest request, CancellationToken cancellationToken)
        {
            await _testiMonialsWriteRepository.RemoveAsync(request.Id);
            await _testiMonialsWriteRepository.SaveAsync();
            return new();
        }
    }
}
