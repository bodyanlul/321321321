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
            return (c >= 'a' && c <= 'z');
        }
        bool isLetterOrNumber(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
        }
        bool isSeporator(char c)
        {
            return (c == '-' || c == '_' || c == '.');
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
        public string checkEmail(string word)
        {
            string log = "";
            State state = State.q0;
            var c = word.ToArray();
            int end = c.Length;
            int i = 0;
            while(true)
            {
                switch(state)
                {
                    case State.q0:
                        if (isLetterOrNumber(c[i]))
                        {
                            state = State.q1;
                            log += " q1";
                            i++;
                        }
                        else
                        {
                            log += "false";
                            return log;
                        }
                        break;
                    case State.q1:
                        if (isLetterOrNumber(c[i]))
                        {
                            state = State.q1;
                            log += " q1";
                            i++;
                        }
                        else if (isSeporator(c[i]))
                        {
                            state = State.q0;
                            log += " q0";
                            i++;
                        }
                        else if (isAt(c[i]))
                        {
                            state = State.q2;
                            log += " q2";
                            i++;
                        }
                        else
                        {
                            log += "false";
                            return log;
                        }
                        break;
                    case State.q2:
                        if (isLetterOrNumber(c[i])) 
                        { 
                            state = State.q3;
                            log += " q3";
                            i++; 
                        }
                        else
                        {
                            log += "false";
                            return log;
                        }
                        break;
                    case State.q3:
                        if (isLetterOrNumber(c[i]))
                        {
                            state = State.q3;
                            log += " q3";
                            i++;
                        }
                        else if(isDot(c[i]))
                        {
                            state = State.q4;
                            log += " q4";
                            i++;
                        }
                        else
                        {
                            log += "false";
                            return log;
                        }
                        break;
                    case State.q4:
                        if (isLetter(c[i]) && isEnd(end, i))
                        {
                            state = State.q5;
                            log += " q5";
                            i++;
                        }
                        else if (isLetter(c[i]) || isDot(c[i])) 
                        {
                            state = State.q4;
                            log += " q4";
                            i++;
                        }
                        else if (isNumber(c[i]) || isDot(c[i]))
                        {
                            state = State.q3;
                            log += " q3";
                            i++;
                        }
                        else
                        {
                            log += "false";
                            return log;
                        }
                        break;
                    case State.q5:
                        {
                            log += " true";
                            Console.WriteLine(log);
                            return log;
                        }
                        break;
                }
            }
        }
    }
}
