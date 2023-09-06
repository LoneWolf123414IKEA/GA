namespace V1
{
    public class Config
    {
        private string? token;
        private string? identity;
        private string? bot_ip;
        private int? bot_port;
        private int? owner;
        private string? owner_name;
        private int? cooldown_period;
        private Member defaul;
        private List<Member> members = new List<Member>();
        private List<Member> additional_profiles = new List<Member>();

        public Config()
        {
            token = "Testvalue";
            identity = "Testvalue";
            bot_ip = "000.00.000.000";
            bot_port = 0;
            owner = 1;
            owner_name = "Namegoes here";
            cooldown_period = 60;
            defaul = new Member();
            members.Add(new Member());
            additional_profiles.Add(new Member());

        }

        private class Member
        {
            private string name;
            private string? set_name;
            private string? set_avatar;
            private Role? set_role;
            private string? set_banner;
            private string? set_bio;
            private string? set_pronouns;


            public Member()
            {
                name = "Nam";
                set_name = "nameee";
                set_avatar = "yep";
                set_role = new Role();
                set_banner = "ffffff";
                set_bio = "filler";
                set_pronouns = "something/something";
            }


            private class Role 
            {
                private int? guild;
                private int? role;
                private string? name;
                private string? colour;

                public Role()
                {
                    guild = 1234145;
                    role = 143;
                    name = "yea yea";
                    colour = "000000";
                }
            }
        }
    }
}