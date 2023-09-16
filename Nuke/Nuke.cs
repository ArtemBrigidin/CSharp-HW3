using Device;

namespace Nukes
{
    public class Nuke : Devices
    {
        public Nuke(string name, string description, string sound) : base(name, description, sound)
        {
            this.name = name;
            this.description = description;
            this.sound = sound;
        }
    }
}