using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tf9ik
{
    internal class Automat
    {
        bool isLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || c == '-';
        }
        bool isAt(char c)
        {
            return c == '@';
        }
        bool isDot(char c)
        {
            return c == '.';
        }
        bool isEnd(int end, int i)
        {
            return end - 1  == i;
        }
        enum State
        {
            q0,
            q1,
            q2,
            q3
        };
        public bool checkEmail(string word)
        {
            State state = State.q0;
            var c = word.ToArray();
            int end = c.Length;
            int i = 0;
            while(true)
            {
                switch(state)
                {
                    case State.q0:
                        if (isLetter(c[i]))
                        {
                            state = State.q1;
                            i++;
                        }
                        else return false;
                        break;
                    case State.q1:
                        if (isLetter(c[i]))
                        {
                            state = State.q1;
                            i++;
                        }
                        else if (isDot(c[i]))
                        {
                            state = State.q0;
                            i++;
                        }
                        else if (isAt(c[i]))
                        {
                            state = State.q2;
                            i++;
                        }
                        else return false;
                        break;
                    case State.q2:
                        if (isLetter(c[i])) 
                        { 
                            state = State.q3;
                            i++; 
                        }
                        else return false;
                        break;
                    case State.q3:
                        if (isEnd(end, i)) return true;
                        else if (isDot(c[i])) /*&& (!isEnd(end, i)))*/
                        {
                            state = State.q2;
                            i++;
                        }
                        else if (isLetter(c[i]))// && (!isEnd(end, i)))
                        {
                            state = State.q3;
                            i++;
                        }
                        else return false;
                        break;
                }
            }
        }
    }
}
