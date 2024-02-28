using Core.Entities;

namespace REMCheck.Models.EvaluationModels
{
    public class EvaluationResponseModel
    {
        public EvaluationResponseModel(Evaluation evaluation)
        {
            Percent = evaluation.Percent;
            Description = evaluation.Description;
        }

        public decimal Percent { get; set; }

        public string Description { get; set; }

    }
}
