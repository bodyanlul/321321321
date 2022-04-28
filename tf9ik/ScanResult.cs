using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tf9ik
{
    public class ScanResult
    {
        private int position;//позиция символа во всей входной последовательности символов
        private int elementToken;//токен элемента
        private string value;//значение (набор символов) элемента
        private int numberString;//номер строки
        private int positionString;//позиция начала строки

        public ScanResult() { }

        public ScanResult(int position, int elementCode, string value, int numberString, int positionInString)
        {
            Position = position;
            NumberString = numberString;
            ElementCode = elementCode;
            Value = value;
            PositionString = positionInString;
        }

        public int Position { get => position; set => position = value; }
        public int ElementCode { get => elementToken; set => elementToken = value; }
        public string Value { get => value; set => this.value = value; }
        public int NumberString { get => numberString; set => numberString = value; }
        public int PositionString { get => positionString; set => positionString = value; }
    }
}

