namespace Moneys
{
    public class Money
    {
        public int _rubles; 
        public int _kopecks;

        public Money()
        {
            this._rubles = 0;
            this._kopecks = 0;
        }

        public void SetRubles()
        {
            Console.Write("Введите сумму рублей >>");
            _rubles = Int32.Parse(Console.ReadLine());
        }

        public void SetKopecks()
        {
            Console.Write("Введите сумму копеек >>");
            _kopecks = Int32.Parse(Console.ReadLine());
            if (_kopecks > 100)
            {
                _rubles += _kopecks / 100;
                _kopecks %= 100;
            }
        }

        public override string ToString()
        {
            string res = $"{_rubles} рублей {_kopecks} копеек"; ;
            return res;
        }

    }
}