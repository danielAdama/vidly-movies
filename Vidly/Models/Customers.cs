namespace Vidly.Models
{
    public class Customers : BaseEntity
    {
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

    }
}
