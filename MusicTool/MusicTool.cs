namespace MusicTool
{
    public class MTool
    {
        public string name;
        public string description;
        public string sound = " ";
        public string history = " ";

        public MTool(string _name, string _description)
        {
            this.name = _name;
            this.description = _description;
        }

        public string Sound()
        {
            return sound;
        }
        public string Show()
        {
            return name;

        }
        public string Desk()
        {
            return description;

        }
        public string History()
        {
            return history;

        }
    }
}