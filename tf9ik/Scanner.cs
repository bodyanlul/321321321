using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tf9ik
{
    public class Scanner
    {
        enum Lexemes
        {
            access = 0,
            name = 1,
            strAs = 2,
            type = 3,
            equal = 4,
            const_value = 5,
            comma = 6,
            enter = 7,
            error = -1
        }

        public List<ScanResult> Scan(string line)
        {
            int numberString = 0, stringPosition = 0;
            List<ScanResult> scanResults = new List<ScanResult>();
            if (line.Length == 0)
            {
                return scanResults;
            }

            string currentValue = string.Empty;
            char currentLetter = line[0];

            for (int i = 0; i < line.Length; i++)
            {
                ScanResult result = new ScanResult();
                currentValue = string.Empty;
                currentLetter = line[i];

                if (line[i].Equals(' ') || line[i] == '\n')
                {
                    if (line[i] == '\n')
                    {
                        result.ElementCode = Convert.ToInt32(Lexemes.enter);
                        result.Value = "переход строки";
                        result.Position = i;
                        result.NumberString = numberString;
                        result.PositionString = stringPosition;
                        scanResults.Add(result);
                        stringPosition = i;
                        numberString++;
                    }
                    continue;
                }

                if (char.IsLetter(line[i]))
                {
                    currentValue += line[i];
                    result.Position = i++;
                    result.NumberString = numberString;
                    result.PositionString = stringPosition;

                    while (i < line.Length)
                    {
                        if (char.IsDigit(line[i]) || char.IsLetter(line[i]))
                        {
                            currentValue += line[i];
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    switch (currentValue)
                    {
                        case "Dim":
                        case "Static":
                        case "Public":
                        case "Private":
                            result.ElementCode = Convert.ToInt32(Lexemes.access);
                            break;
                        case "Double":
                        case "Integer":
                            result.ElementCode = Convert.ToInt32(Lexemes.type);
                            break;
                        case "As":
                            result.ElementCode = Convert.ToInt32(Lexemes.strAs);
                            break;
                        default:
                            result.ElementCode = Convert.ToInt32(Lexemes.name);
                            break;
                    }
                    result.Value = currentValue;
                    scanResults.Add(result);
                    i--;
                    continue;
                }

                if (char.IsDigit(line[i]))
                {
                    result.Position = i;
                    result.NumberString = numberString;
                    result.PositionString = stringPosition;
                    result.ElementCode = Convert.ToInt32(Lexemes.const_value);

                    currentValue += line[i++];
                    bool onePoint = false;

                    while (i < line.Length)
                    {
                        if (line[i].Equals('.'))
                        {
                            if (!onePoint)
                            {
                                onePoint = true;
                                currentValue += ".";
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (char.IsDigit(line[i]))
                        {
                            currentValue += line[i];
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    result.Value = currentValue;
                    scanResults.Add(result);
                    i--;
                    continue;
                }

                if (line[i] == '=')
                {
                    result.Position = i;
                    result.NumberString = numberString;
                    result.PositionString = stringPosition;
                    result.ElementCode = Convert.ToInt32(Lexemes.equal);
                    result.Value = "=";
                    scanResults.Add(result);
                    continue;
                }

                if (line[i] == ',')
                {
                    result.Position = i;
                    result.NumberString = numberString;
                    result.PositionString = stringPosition;
                    result.ElementCode = Convert.ToInt32(Lexemes.comma);
                    result.Value = ",";
                    scanResults.Add(result);
                    continue;
                }

                result.Position = i;
                result.NumberString = numberString;
                result.PositionString = stringPosition;
                result.ElementCode = Convert.ToInt32(Lexemes.error);
                result.Value = "error";
                scanResults.Add(result);
            }
            return scanResults;
        }
    }
}
