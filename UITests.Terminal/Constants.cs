namespace UITests.Terminal
{
    public class Constants
    {
        public class Account
        {
            public class Production
            {
                public const string AccountName = "testdbsyristeautoterminal";
                public const string Email = "michal.syriste@vykazprace.cz";
                public const string Password = "123456";
            }

            public class Staging
            {
                public const string AccountName = "stagedbsyristeautoterminal";
                public const string Email = "michal.syriste@vykazprace.cz";
                public const string Password = "123456";
            }

            public class Development
            {
                public const string AccountName = "devdbsyristeautoterminal";
                public const string Email = "michal.syriste@vykazprace.cz";
                public const string Password = "123456";
            }
        }

        public class Enviroment
        {
            public const string Staging = "staging";
            public const string Development = "development";
            public const string Production = "production";
        }

        public class Directory
        {
            public const string Default = @"C:\UITests\UITests.Terminal";
            public const string Screenshots = "Screenshots";
            public const string Errors = "Errors";
        }
    }
}
