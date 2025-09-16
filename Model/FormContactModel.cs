namespace BlazorEditFormExamples.Model
{
    public class FormContactModel
    {
        public ContactBase? Contact { get; set; }
        public bool ConsentToShare { get; set; } = false;
    }
}
