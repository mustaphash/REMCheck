using Core.Entities;

namespace REMCheck.Models.ReportModels
{
    public class ReportResponseModel
    {
        public ReportResponseModel(Report report)
        {
            Name = report.Name;
            Description = report.Description;
        }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
