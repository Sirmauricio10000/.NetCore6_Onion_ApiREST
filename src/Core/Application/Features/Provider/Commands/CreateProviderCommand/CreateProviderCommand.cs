using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Wrappers;
using MediatR;

namespace Application.Features.Provider.Commands.CreateProviderCommand
{
    public class CreateProviderCommand : IRequest<Response<int>>
    {
        public string NIT { get; set; }
        public string BusinessName { get; set; }
        public string Address  { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
    }
    public class CreateProviderCommandHandler : IRequestHandler<CreateProviderCommand, Response<int>>
    {
        public async Task<Response<int>> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}