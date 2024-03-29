﻿using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllEvaluations
{
    public class GetAllEvaluationsQueryHandler : IQueryHandler<GetAllEvaluationsQuery, IList<Evaluation>>
    {
        private readonly REMContext _rEMContext;

        public GetAllEvaluationsQueryHandler(REMContext rEMContext)
        {
            _rEMContext = rEMContext;
        }

        public async Task<IList<Evaluation>> HandleAsync(GetAllEvaluationsQuery query, CancellationToken cancellationToken = default)
        {
            List<Evaluation> evaluations = await _rEMContext.Evaluations.ToListAsync(cancellationToken);

            return evaluations;
        }
    }
}
