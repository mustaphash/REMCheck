using Core.Entities;

namespace REMCheck.Models.MistakeModels
{
    public class MistakeResponseModel
    {
        public MistakeResponseModel(Mistake mistake)
        {
            Name = mistake.Name;
            Description = mistake.Description;
        }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
