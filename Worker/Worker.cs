using System.Xml.Linq;

namespace Worker
{
    public abstract class Workerr
    {
        public string Name { get; set; }
        public abstract void Print();
    }
}