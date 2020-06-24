using NW.Income.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Income.API.Core
{
    /// <summary>
    /// Interface for defining Income context to store employee object and it's behavior
    /// </summary>
    internal interface IIncomeContext
    {
        void Add(IncomeQuestionnaire employee);
        void Remove(int id);
        IEnumerable<IncomeQuestionnaire> GetAll();
        IncomeQuestionnaire Get(int id);
        void SaveChanges();

    }
}
