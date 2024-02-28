using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllMistakes
{
    public class GetAllMistakesQueryHandler : IQueryHandler<GetAllMistakesQuery, IList<Mistake>>
    {
        private readonly REMContext _rEMContext;

        public GetAllMistakesQueryHandler(REMContext rEMContext)
        {
            _rEMContext = rEMContext;
        }

        public async Task<IList<Mistake>> HandleAsync(GetAllMistakesQuery query, CancellationToken cancellationToken = default)
        {
            List<Mistake> mistakes = await _rEMContext.Mistakes.ToListAsync(cancellationToken);

            return mistakes;
        }
    }
}
