using Practica.Models;
using Practica.Repositories.Dapper.Credit;
using System;
using System.Linq;
using Xunit;

namespace Practica.Repositories.DapperTests
{
    public class CorporationRepositoryTest
    {



        private readonly CreditUnitOfWork unit;


        public CorporationRepositoryTest()
        {

            unit = new CreditUnitOfWork("Server=.;Database=Credit; Trusted_Connection=True;MultipleActiveResultSets=True");

        }

        [Fact(DisplayName = "[CorporationRepository]Get All")]
        public void Corporation_Repository_GetAll()
        {

            
            var result = unit.Corporations.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[CorporationRepository]Insert")]
        public void Member_Repository_Insert()
        {
            Corporation corporation = GetNewCorporation();
            
            var result = unit.Corporations.Insert(corporation);
            Assert.True(result > 0);
        }


        [Fact(DisplayName = "[CorporationRepository]Delete")]
        public void Member_Repository_Delete()
        {
            var member = GetNewCorporation();
            
            var result = unit.Corporations.Insert(member);
            Assert.True(unit.Corporations.Delete(member));
        }



        private Corporation GetNewCorporation()
        {
            return new Corporation
            {
                corp_name = "corp_name",
                street = "street",
                city = "city",
                state_prov = "SP",
                country = "CT",
                mail_code = "mailcode",
                phone_no = "phone_no",
                expr_dt = DateTime.Now,
                corp_code = "CC"


            };
        }


        [Fact(DisplayName = "[CorporationRepository]Update")]
        public void Corporation_Repository_Update()
        {
            
            var corporation = unit.Corporations.GetById(10);
            Assert.True(corporation != null);
            corporation.corp_name = "New_corp_name";
            Assert.True(unit.Corporations.Update(corporation));
        }


        [Fact(DisplayName = "[CorporationRepository]Get By Id")]
        public void Corporation_Repository_Get_By_Id()
        {
            //var repo = new RepositoryEF<Customer>(_context);
            var customer = unit.Corporations.GetById(10);
            Assert.True(customer != null);
        }




    }
}
