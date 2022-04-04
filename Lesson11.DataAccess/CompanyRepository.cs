using Lesson11.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.DataAccess
{
    internal class CompanyRepository
    {
        private List<Company> companies { get; }

        public CompanyRepository()
        {
            companies = new List<Company>();

            CountryRepository countryRepository = new CountryRepository(); 
            List<Country> country = countryRepository.Retrieve();

            companies.Add(new Company("AAA", country[0]));
            companies.Add(new Company("ZZZ", country[1]);
        }

        public List<Company>Retrieve()
        {
            return companies;
        }
    }
}
