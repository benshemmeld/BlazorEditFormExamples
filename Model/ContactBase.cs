namespace BlazorEditFormExamples.Model
{
    public abstract class ContactBase
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address Address { get; set; } = new();
        public virtual ContactType ContactType { get; set; }
        public bool AreAddressDetailsRequired { get; set; } = false;
    }
}
