using System.Collections.Generic;

namespace NW.Income.API.Model
{
    /// <summary>
    /// Responsible for holding for IncomeQuestionnaire properties and attributes
    /// </summary>
    public class IncomeQuestionnaire
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public List<string> Answer { get; set; }
    }

}
