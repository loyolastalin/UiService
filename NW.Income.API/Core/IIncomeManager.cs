using NW.Income.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Income.API.Core
{
    /// <summary>
    /// Interface for the income manager
    /// </summary>
    public interface IIncomeManager
    {
        void Add(IncomeQuestionnaire employee);
        void Remove(int id);
        IEnumerable<IncomeQuestionnaire> GetAll();
        IncomeQuestionnaire Get(int id);

        void WriteToXml();
    }
}
