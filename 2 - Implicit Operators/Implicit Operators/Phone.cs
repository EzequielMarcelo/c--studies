namespace Implicit_Operators
{
    public class Phone
    {
        public string CountryCode { get; set; }
        public string Area { get; set; }
        public string Number { get; set; }

        public static implicit operator string (Phone phone)
            => $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

        public static implicit operator Phone(string phoneNumber)
        {
            //The method is for example only and does not have error handling 
            var arrayPhone = phoneNumber.Split(" ");
            var phone = new Phone 
            {
                CountryCode = arrayPhone[0],
                Area = arrayPhone[1],
                Number = arrayPhone[2]
            };

            return phone;
        }
    }
}
