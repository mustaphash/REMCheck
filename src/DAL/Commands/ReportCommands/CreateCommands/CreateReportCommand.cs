using Core.Commands;
using Core.Entities;

namespace DAL.Commands.ReportCommands.CreateCommands
{
    public class CreateReportCommand : ICommand
    {
        public CreateReportCommand(Report report)
        {
            Report = report;
        }
        public Report Report { get; }
    }
}
