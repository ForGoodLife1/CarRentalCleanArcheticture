﻿using CarRental.Core.Features.ApplicationUser.Queries.Results;
using CarRental.Core.Wrappers;
using MediatR;

namespace CarRental.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
