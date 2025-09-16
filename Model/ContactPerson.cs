namespace BlazorEditFormExamples.Model
{
    public class ContactPerson : ContactBase
    {
        public string Pronoun { get; set; } = string.Empty;
        public override ContactType ContactType => ContactType.Person;
    }
}
