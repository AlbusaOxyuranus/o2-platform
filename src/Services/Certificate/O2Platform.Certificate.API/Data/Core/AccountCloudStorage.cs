namespace O2Platform.Certificate.API.Data.Core
{
    public class AccountCloudStorage
    {
        public string AccountName { get; set; } 
        public  string Container { get; set; }
        public  string AccountKey { get; set; }
        public TypeTable TypeTable { get; set; }
    }
}