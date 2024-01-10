namespace Implicit_Operators
{
    public class Phone
    {
        public string CountryCode { get; set; }
        public string Area { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"+{CountryCode} ({Area}) {Number}";
        }
    }
}
