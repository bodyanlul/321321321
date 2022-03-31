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
        bool isLetterOrNumber(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || c == '-' || (c >= '0' && c <= '9');
        }
        bool isNumber(char c)
        {
            return (c >= '0' && c <= '9');
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
            q3,
            q4,
            q5
        };
        public List<(bool, string)> checkEmail(string word)
        {
            List<(bool, string)> Total = new List<(bool, string)>();
            State state = State.q0;
            var c = word.ToArray();
            int end = c.Length;
            int i = 0;
            string log = "";
            while(true)
            {
                switch(state)
                {
                    case State.q0:
                        if (isLetterOrNumber(c[i]))
                        {
                            state = State.q1;
                            i++;
                            log += "q0 ";
                        }
                        else
                        {
                            log += "false";
                            (bool, string) value = (false, log);
                            Total.Add(value);
                            return Total;
                        }
                        break;
                    case State.q1:
                        if (isLetterOrNumber(c[i]))
                        {
                            state = State.q1;
                            i++;
                            log += "q1 ";
                        }
                        else if (isDot(c[i]))
                        {
                            state = State.q0;
                            i++;
                            log += "q1 ";
                        }
                        else if (isAt(c[i]))
                        {
                            state = State.q2;
                            i++;
                            log += "q1 ";
                        }
                        else
                        {
                            log += "false";
                            (bool, string) value = (false, log);
                            Total.Add(value);
                            return Total;
                        }
                        break;
                    case State.q2:
                        //if (isDot(c[i]))
                        //{
                        //    state = State.q3;
                        //    i++;
                        //}
                        /*else if*/ if (isLetterOrNumber(c[i]))
                        {
                            state = State.q3;
                            i++;
                            log += "q2 ";
                        }
                        else
                        {
                            log += "false";
                            (bool, string) value = (false, log);
                            Total.Add(value);
                            return Total;
                        }
                        break;
                    case State.q3:
                        if (isDot(c[i]))
                        {
                            state = State.q4;
                            i++;
                            log += "q3 ";
                        }
                        else if (isLetterOrNumber(c[i]))
                        {
                            state = State.q3;
                            i++;
                            log += "q3 ";
                        }
                        else
                        {
                            log += "false";
                            (bool, string) value = (false, log);
                            Total.Add(value);
                            return Total;
                        }
                        break;
                    case State.q4:
                        if (isEnd(end, i))
                        {
                            state = State.q5;
                            log += "q4 ";
                        }
                        else if (isLetter(c[i]))
                        {
                            state = State.q4;
                            i++;
                            log += "q4 ";
                        }
                        else if (isDot(c[i]))
                        {
                            state = State.q3;
                            i++;
                            log += "q4 ";
                        }
                        else if (isNumber(c[i]))// || isDot(c[i]))
                        {
                            state = State.q3;
                            i++;
                            log += "q4 ";
                        }
                        else
                        {
                            log += "false";
                            (bool, string) value = (false, log);
                            Total.Add(value);
                            return Total;
                        }
                        break;
                    case State.q5:
                        {
                            log += "true";
                            (bool, string) value = (true, log);
                            Total.Add(value);
                            return Total;
                        }
                }
            }
        }
    }
}
