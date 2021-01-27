using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuLib
{
    public abstract class ConsoleMenuOperation
    {

        private string _menuOperationName;
        private string _associatedKeysLabel;

        protected string _title;
        protected ConsoleKey[] _associatedKeys;

        public string Title { get { return _title; } }

        public string Name { get { return _menuOperationName; } }
        public ConsoleMenuOperation()
        {

            _menuOperationName = GetMenuOperationName();
            _associatedKeys = GetAssociatedKeys();
            _associatedKeysLabel = GetAssociatedKeyLabel();

            _title = _associatedKeysLabel + " - " + _menuOperationName;
        }

        protected abstract string GetMenuOperationName();

        protected abstract ConsoleKey[] GetAssociatedKeys();
        public abstract ConsoleMenuReport Execute();

        public virtual bool HasAssociatedKey(ConsoleKey readKey)
        {
            if (_associatedKeys.Contains(readKey)) return true;
            else return false;
        }

        protected virtual string GetAssociatedKeyLabel()
        {
            string associatedKeysLabel = "";
            List<string> bufferKeyNames = new List<string>();
            IEnumerable<string> distinctedKeyNames;
            foreach (ConsoleKey key in _associatedKeys)
            {
                bufferKeyNames.Add("[" + GetKeyChar(key) + "] ");
            }
            distinctedKeyNames = bufferKeyNames.Distinct();
            foreach (string keyName in distinctedKeyNames)
            {
                associatedKeysLabel += keyName + " ";
            }
            while (associatedKeysLabel.Length < 11)
            {
                associatedKeysLabel += " ";
            }
            return associatedKeysLabel;
        }

        protected virtual string GetKeyChar(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    return "A";
                case ConsoleKey.B:
                    return "B";
                case ConsoleKey.C:
                    return "C";
                case ConsoleKey.D:
                    return "D";
                case ConsoleKey.E:
                    return "E";
                case ConsoleKey.F:
                    return "F";
                case ConsoleKey.G:
                    return "G";
                case ConsoleKey.H:
                    return "H";
                case ConsoleKey.I:
                    return "I";
                case ConsoleKey.J:
                    return "J";
                case ConsoleKey.K:
                    return "K";
                case ConsoleKey.L:
                    return "L";
                case ConsoleKey.M:
                    return "M";
                case ConsoleKey.N:
                    return "N";
                case ConsoleKey.O:
                    return "O";
                case ConsoleKey.P:
                    return "P";
                case ConsoleKey.Q:
                    return "Q";
                case ConsoleKey.R:
                    return "R";
                case ConsoleKey.S:
                    return "S";
                case ConsoleKey.T:
                    return "T";
                case ConsoleKey.U:
                    return "U";
                case ConsoleKey.V:
                    return "V";
                case ConsoleKey.W:
                    return "W";
                case ConsoleKey.X:
                    return "X";
                case ConsoleKey.Y:
                    return "Y";
                case ConsoleKey.Z:
                    return "Z";

                // Numpad keys
                case ConsoleKey.NumPad0:
                    return "0";
                case ConsoleKey.NumPad1:
                    return "1";
                case ConsoleKey.NumPad2:
                    return "2";
                case ConsoleKey.NumPad3:
                    return "3";
                case ConsoleKey.NumPad4:
                    return "4";
                case ConsoleKey.NumPad5:
                    return "5";
                case ConsoleKey.NumPad6:
                    return "6";
                case ConsoleKey.NumPad7:
                    return "7";
                case ConsoleKey.NumPad8:
                    return "8";
                case ConsoleKey.NumPad9:
                    return "9";

                // Keys below F1-F8.
                case ConsoleKey.D0:
                    return "0";
                case ConsoleKey.D1:
                    return "1";
                case ConsoleKey.D2:
                    return "2";
                case ConsoleKey.D3:
                    return "3";
                case ConsoleKey.D4:
                    return "4";
                case ConsoleKey.D5:
                    return "5";
                case ConsoleKey.D6:
                    return "6";
                case ConsoleKey.D7:
                    return "7";
                case ConsoleKey.D8:
                    return "8";
                case ConsoleKey.D9:
                    return "9";

                // Special characters.
                case ConsoleKey.Spacebar:
                    return "SPACE";
                case ConsoleKey.Tab:
                    return "TAB";
                case ConsoleKey.Backspace:
                    return "BACKSPACE";
                case ConsoleKey.Enter:
                    return "ENTER";
                case ConsoleKey.Escape:
                    return "ESCAPE";
                case ConsoleKey.Multiply:
                    return " * ";
                case ConsoleKey.Add:
                    return " + ";
                case ConsoleKey.Subtract:
                    return " - ";

                default:
                    return key.ToString();
            }
        }
    }
}
