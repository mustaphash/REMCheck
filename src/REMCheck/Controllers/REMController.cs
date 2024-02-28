using Core.Entities;
using Core.Queries;
using DAL.Queries.GetAllEvaluations;
using DAL.Queries.GetAllMistakes;
using DAL.Queries.GetAllReports;
using Microsoft.AspNetCore.Mvc;
using REMCheck.Models.EvaluationModels;
using REMCheck.Models.MistakeModels;
using REMCheck.Models.ReportModels;

namespace REMCheck.Controllers
{
    [Route("rem")]
    [ApiController]
    public class REMController : ControllerBase
    {
        private readonly IQueryHandler<GetAllReportsQuery, IList<Report>> _getAllReportsQuery;
        private readonly IQueryHandler<GetAllEvaluationsQuery, IList<Evaluation>> _getAllEvaluationsQuery;
        private readonly IQueryHandler<GetAllMistakesQuery, IList<Mistake>> _getAllMistakesQuery;

        public REMController(
            IQueryHandler<GetAllReportsQuery, IList<Report>> getAllReportsQuery,
            IQueryHandler<GetAllEvaluationsQuery, IList<Evaluation>> getAllEvaluationsQuery,
            IQueryHandler<GetAllMistakesQuery, IList<Mistake>> getAllMistakesQuery)
        {
            _getAllReportsQuery = getAllReportsQuery;
            _getAllEvaluationsQuery = getAllEvaluationsQuery;
            _getAllMistakesQuery = getAllMistakesQuery;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReports()
        {
            IList<Report> reports = await _getAllReportsQuery.HandleAsync(new GetAllReportsQuery());
            var reportResponse = reports.Select(r => new ReportResponseModel(r));

            return Ok(reportResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvaluations()
        {
            IList<Evaluation> evaluations = await _getAllEvaluationsQuery.HandleAsync(new GetAllEvaluationsQuery());
            var evaluationResponse = evaluations.Select(e => new EvaluationResponseModel(e));

            return Ok(evaluationResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMistakes()
        {
            IList<Mistake> mistakes = await _getAllMistakesQuery.HandleAsync(new GetAllMistakesQuery());
            var mistakeResponse = mistakes.Select(m => new MistakeResponseModel(m));

            return Ok(mistakeResponse);
        }

    }
}
