using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.TestiMonials.CreateTestiMonials
{
    public class CreateTestiMonialsCommandHandler : IRequestHandler<CreateTestiMonialsCommandRequest, CreateTestiMonialsCommandResponse>
    {
        private readonly ITestiMonialsWriteRepository _testiMonialsWriteRepository;
        public CreateTestiMonialsCommandHandler(ITestiMonialsWriteRepository testiMonialsWriteRepository)
        {
            _testiMonialsWriteRepository = testiMonialsWriteRepository;
        }

        public async Task<CreateTestiMonialsCommandResponse> Handle(CreateTestiMonialsCommandRequest request, CancellationToken cancellationToken)
        {
            await _testiMonialsWriteRepository.AddAsync(new()
            {
                ClientImage = request.ClientImage,
                ClientName = request.ClientName,
                Comment = request.Comment,
            });
            await _testiMonialsWriteRepository.SaveAsync();
            return new();
        }
    }
}
