using NW.Income.API.Core;
using System;
using System.Collections.Generic;
using NW.Income.API.Model;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace NW.Income.API.DAL
{
    /// <summary>
    /// Responsible for storing all the income objects and ensure emplooyee Id is unique
    /// Implemented with the Unitofwork Pattern
    /// Inherited from <see cref="IIncomeContext"/>
    /// </summary>
    internal class IncomeContext : IIncomeContext
    {
        private List<IncomeQuestionnaire> IncomeList;

        public IncomeContext()
        {
            //IncomeList = new List<IncomeQuestionnaire>()
            //{
            //    new IncomeQuestionnaire() { Id=1, Question = "First Q1", Answer = "First Answer"},
            //    new IncomeQuestionnaire() { Id=1, Question = "First Q2", Answer = "Second Answer"},
            //    new IncomeQuestionnaire() { Id=1, Question = "First Q3", Answer = "Third Answer"}
            //};
        }
        public void Add(IncomeQuestionnaire income)
        {
            var alredyExits = IncomeList.FirstOrDefault(emp => emp.Id == income.Id);
            if (alredyExits != null)
            {
                throw new ArgumentException(string.Format("Income already exists {0}, please add another income.", income.Id));
            }
            IncomeList.Add(income);
        }

        public IncomeQuestionnaire Get(int id)
        {
            return IncomeList.FirstOrDefault(emp => emp.Id == id);
        }

        public IEnumerable<IncomeQuestionnaire> GetAll()
        {
            if (IncomeList == null)
            {
                using (StreamReader r = new StreamReader(@"C:\Users\loyola_soosai\Desktop\Commerz Bank\NW.Income\NW.Income.UIServices\Models\data.json"))
                {
                    string json = r.ReadToEnd();
                    IncomeList = JsonConvert.DeserializeObject<List<IncomeQuestionnaire>>(json);
                }
            }
            return IncomeList;
        }

        public void Remove(int id)
        {
            var alredyExitsIncome = IncomeList.FirstOrDefault(emp => emp.Id == id);
            if (alredyExitsIncome == null)
            {
                throw new ArgumentException(string.Format("Income already exists {0}, please add another income.", alredyExitsIncome.Id));
            }
            IncomeList.Remove(alredyExitsIncome);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
