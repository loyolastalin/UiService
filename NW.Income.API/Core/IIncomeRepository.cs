using NW.Income.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Income.API.Core
{
    /// <summary>
    /// Interface for income repository, this decouple the persitance storage from the upstream system
    /// </summary>
    internal interface IIncomeRepository
    {
        void Add(IncomeQuestionnaire employee);
        void Remove(int id);
        IEnumerable<IncomeQuestionnaire> GetAll();
        IncomeQuestionnaire Get(int id);
    }
}
