using NW.Income.API.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NW.Income.API.Model;

namespace NW.Income.API.DAL
{
    /// <summary>
    /// Decouple the Persistence storage from the BL, interacts with the IncomeQuestionnaireContext persitence storage<see cref="IncomeContext"/>
    /// </summary>
    internal class IncomeRepository : IIncomeRepository
    {
        private readonly IIncomeContext _context;
        
        public IncomeRepository() : this(new IncomeContext()) 
        {

        }

        /// <summary>
        /// this is for testing purpose, we can remove this when we implement IOC framework like Unit framework
        /// </summary>
        internal IncomeRepository(IIncomeContext context)
        {
            _context = context;
        }
        public void Add(IncomeQuestionnaire employee)
        {
            _context.Add(employee);
        }

        public IncomeQuestionnaire Get(int id)
        {
            return _context.Get(id);
        }

        public IEnumerable<IncomeQuestionnaire> GetAll()
        {
            return _context.GetAll();
        }

        public void Remove(int id)
        {
            _context.Remove(id);
        }
    }
}
