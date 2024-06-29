using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        void AddMember(MemberObject member);
        MemberObject GetMemberById(int id);
        Task<IEnumerable<MemberObject>> GetMembers();
        void UpdateMember(MemberObject member);
        void DeleteMember(int id);
        MemberObject GetMemberLogin(string email, string password);
    }
}