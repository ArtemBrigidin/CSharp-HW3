namespace Device
{

    public class Devices
    {
        public string name;
        public string description;
        public string sound;
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
        public Devices(string _name, string _description, string _sound)
        {
            this.name = _name;
            this.description = _description;
            this.sound = _sound;
        }
    }
}