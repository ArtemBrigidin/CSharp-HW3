using MusicTool;

namespace Violin 
{
    public class Viiolin : MTool
    {
        public Viiolin(string name, string description) : base(name, description)
        {
            sound = "скрипит";
            history = "появилась в начале XVI века";
            this.name = name;
            this.description = description;
        }


    }
}