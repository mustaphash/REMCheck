using Core.Commands;

namespace DAL.Commands.ReportCommands.CreateCommands
{
    public class CreateReportCommandHandler : ICommandHandler<CreateReportCommand>
    {
        private readonly REMContext _rEMContext;

        public CreateReportCommandHandler(REMContext rEMContext)
        {
            _rEMContext = rEMContext;
        }

        public async Task HandleAsync(CreateReportCommand command, CancellationToken cancellationToken = default)
        {
            await _rEMContext.AddAsync(command.Report);
            await _rEMContext.SaveChangesAsync();
        }
    }
}
