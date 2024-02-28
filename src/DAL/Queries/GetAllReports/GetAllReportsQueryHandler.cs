using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllReports
{
    public class GetAllReportsQueryHandler : IQueryHandler<GetAllReportsQuery, IList<Report>>
    {
        private readonly REMContext _rEMContext;

        public GetAllReportsQueryHandler(REMContext rEMContext)
        {
            _rEMContext = rEMContext;
        }

        async Task<IList<Report>> IQueryHandler<GetAllReportsQuery, IList<Report>>.HandleAsync(GetAllReportsQuery query, CancellationToken cancellationToken)
        {
            List<Report> reports = await _rEMContext.Reports.ToListAsync(cancellationToken);

            return reports;
        }
    }
}
