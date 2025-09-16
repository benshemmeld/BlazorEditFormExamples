namespace BlazorEditFormExamples.Model
{
    public class ContactOrganisation : ContactBase
    {
        public string KeyContact { get; set; } = string.Empty;
        public override ContactType ContactType => ContactType.Organisation;
    }
}
