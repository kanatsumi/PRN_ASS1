using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly SaleDbContext _context;
        private readonly MemberDAO memberDAO;

        public MemberRepository()
        {
            _context = new SaleDbContext();
            memberDAO = new MemberDAO(_context);
        }

        public void AddMember(MemberObject member)
        {
            memberDAO.Add(member);
        }

        public MemberObject GetMemberById(int id)
        {
            return memberDAO.GetQueryAble().FirstOrDefault(p => p.MemberId == id);
        }

        public async Task<IEnumerable<MemberObject>> GetMembers()
        {
            return memberDAO.GetAll();
        }

        public void UpdateMember(MemberObject member)
        {
            memberDAO.Update(member);
        }

        public void DeleteMember(int id)
        {
            memberDAO.Delete(GetMemberById(id));
        }

        public MemberObject GetMemberLogin(string email, string password)
        {
            return memberDAO.GetQueryAble().FirstOrDefault(p => p.Email == email && p.Password == password);
        }

    }
}
