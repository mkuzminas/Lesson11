using Lesson11.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.DataAccess
{
    public class AircraftRepository
    {
        private List<Aircraft> aircrafts;

        public AircraftRepository()
        {
            aircrafts = new List<Aircraft>();
            ModelRepository modelrepository = new ModelRepository();
            List<Model>model = modelrepository.Retrieve();
            CompanyRepository companyrepository = new CompanyRepository();
            List<Company> company = companyrepository.Retrieve();
            
            aircrafts.Add(new Aircraft(1, model[0], company[0]));
            aircrafts.Add(new Aircraft(2, model[1], company[1]));
        }

        public List<Aircraft>Retrieve()
        {
            return aircrafts;
        }
    }
}
