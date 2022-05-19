using WebApplication1.Models;

public static class MemberDB
{
    public static List<Member> Members { get; set; } = new List<Member>()
    {
    };
    private static UInt16 idCount = 3;

    public static List<Member> GetAll()
    {
        return Members;
    }

    public static Member? GetById(int id)
    {

        var result = Members.SingleOrDefault(x => x.ID == id);
        return result;
    }

    public static bool DeleteById(int id)
    {
        var mem = Members.SingleOrDefault(x => x.ID == id);
        return Members.Remove(mem);
    }

    public static int Add(MemberDTO memberDto)
    {
        var member = new Member();
        //int tempId = 1;
        //if (Members.Count >= 1)
        //{
        //    tempId = Members.OrderBy(x => x.ID).ToList().Last().ID + 1;
        //}
        idCount++;
        member.ID = idCount;
        member.FirstName = memberDto.FirstName;
        member.LastName = memberDto.LastName;
        member.Sex = memberDto.Sex;
        member.Mobile = memberDto.Mobile;
        member.SSID = memberDto.SSID;
        member.BirthDate = memberDto.BirthDate;
        member.SubscriptionType = memberDto.SubscriptionType;
        Members.Add(member);
        return idCount;
    }

    public static bool UpdateById(int id, MemberDTO memberDto)
    {
        var member = Members.SingleOrDefault(x => x.ID == id);
        if (member is null)
        {
            return false;
        }
        else
        {
            member.FirstName = memberDto.FirstName;
            member.LastName = memberDto.LastName;
            member.Sex = memberDto.Sex;
            member.Mobile = memberDto.Mobile;
            member.SSID = memberDto.SSID;
            member.BirthDate = memberDto.BirthDate;
            member.SubscriptionType = memberDto.SubscriptionType;
            return true;
        }
    }
}