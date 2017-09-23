using Practica.Models;
using Practica.Repositories.Dapper.Credit;
using System;
using System.Linq;
using Xunit;

namespace Practica.Repositories.DapperTests
{
    public class MemberRepositoryTest
    {



        private readonly CreditUnitOfWork unit;


        public MemberRepositoryTest()
        {

            unit = new CreditUnitOfWork("Server=.;Database=Credit; Trusted_Connection=True;MultipleActiveResultSets=True");

        }

        [Fact(DisplayName = "[MemberRepository]Get All")]
        public void Member_Repository_GetAll()
        {
            
            var result = unit.Members.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[MemberRepository]Insert")]
        public void Member_Repository_Insert()
        {
            Member member = GetNewMember();
            
            var result = unit.Members.Insert(member);
            Assert.True(result > 0);
        }


        [Fact(DisplayName = "[MemberRepository]Delete")]
        public void Member_Repository_Delete()
        {
            var member = GetNewMember();
            
            var result = unit.Members.Insert(member);
            Assert.True(unit.Members.Delete(member));
        }



        private Member GetNewMember()
        {
            return new Member
            {
                
                lastname = "lastname",
                firstname = "firstname",
                middleinitial = "M",
                street = "street",
                city = "city",
                state_prov = "SP",
                country = "CT",
                mail_code = "mail",
                phone_no = "phone_no",
                issue_dt = DateTime.Now,
                expr_dt = DateTime.Now,
                        corp_no = 1,
                prev_balance = 1,
                curr_balance  = 1,
                member_code = "MC"

    };
        }


        [Fact(DisplayName = "[MemberRepository]Update")]
        public void Member_Repository_Update()
        {
            
            var member = unit.Members.GetById(10);
            Assert.True(member != null);
            member.lastname = "New_lastname";
            Assert.True(unit.Members.Update(member));
        }


        [Fact(DisplayName = "[MemberRepository]Get By Id")]
        public void Corporation_Repository_Get_By_Id()
        {
            
            var member = unit.Members.GetById(10);
            Assert.True(member != null);
        }




    }
}
