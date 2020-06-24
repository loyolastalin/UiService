using NW.Income.API.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NW.Income.API.Model;
using NW.Income.API.DAL;

namespace NW.Income.API.BL
{
    /// <summary>
    /// Repobonsible  for add the IncomeQuestionnaire object business object, inherited from <see cref="IIncomeBL"/>
    /// </summary>
    internal class IncomeBL : IIncomeBL
    {
        private IIncomeRepository _repository;

        
        public IncomeBL(): this(new IncomeRepository())
        {

        }

        /// <summary>
        /// For testing purpose, replace later with IOC container instance management
        /// </summary>
        internal IncomeBL(IIncomeRepository repository)
        {
            _repository = repository;
        }
        public void Add(IncomeQuestionnaire employee)
        {
            if(employee ==null)
            {
                throw new ArgumentNullException("Please provovide the valid employee object");
            }

            _repository.Add(employee);
        }

        public IncomeQuestionnaire Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<IncomeQuestionnaire> GetAll()
        {
            return _repository.GetAll();
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }
    }
}
