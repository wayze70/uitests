namespace UITests.Terminal
{
    public class Constants
    {
        public class Account
        {
            public const string AccountName = "dbsyristedemoautoterminal";
            public const string Email = "syriste@tempuri.org";
            public const string Password = "123456";
        }

        public class Terminal
        {
            public const string Name = "HW-Terminal";
            public const string Password = "123456";
            public const string Pin = "1234";
        }

        public class Environment
        {
            public const string Staging = "staging";
            public const string Development = "development";
            public const string Production = "production";
        }

        public class Directory
        {
            public const string WindowsDefault = @"C:\UITests\UITests.Terminal";
            public const string LinuxDefault = "/UITests";
            public const string Screenshots = "Screenshots";
            public const string Errors = "Errors";
        }
    }
}
