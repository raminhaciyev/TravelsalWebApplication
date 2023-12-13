using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelsalWebApplication.CQRS.Resuls.GuideResults;

namespace TravelsalWebApplication.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery: IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
