using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.TestiMonials.UpdateTestiMonials
{
    public class UpdateTestiMonialsCommandHandler : IRequestHandler<UpdateTestiMonialsCommandRequest, UpdateTestiMonialsCommandResponse>
    {
        private readonly ITestiMonialsReadRepository _testiMonialsReadRepository;
        private readonly ITestiMonialsWriteRepository _testiMonialsWriteRepository;
        public UpdateTestiMonialsCommandHandler(ITestiMonialsReadRepository testiMonialsReadRepository, ITestiMonialsWriteRepository testiMonialsWriteRepository)
        {
            _testiMonialsReadRepository = testiMonialsReadRepository;
            _testiMonialsWriteRepository = testiMonialsWriteRepository;
        }

        public async Task<UpdateTestiMonialsCommandResponse> Handle(UpdateTestiMonialsCommandRequest request, CancellationToken cancellationToken)
        {
            var testiMonials = await _testiMonialsReadRepository.GetByIdAsync(request.Id);
            testiMonials.ClientName = request.ClientName;
            testiMonials.Comment = request.Comment;
            testiMonials.ClientImage = request.ClientImage;
            await _testiMonialsWriteRepository.SaveAsync();
            return new();
        }
    }
}
