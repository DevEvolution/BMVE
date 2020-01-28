using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class StringProxy
    {
        internal static int String_GetCharCode(string str)
        {
            if (str.Length == 0) throw new Exception("Команде необходима строка str, содержащая один символ");
            return (int)str[0];
        }
        internal static int String_Length(string str) => str.Length;
        internal static string String_CharAt(string str, int index)
        {
            if (index >= str.Length) throw new Exception("Параметр index не должен быть больше длины строки str");
            else if (index < 0) throw new Exception("Параметр index не должен быть отрицательным значением");
            return str[index].ToString();
        }
        internal static int String_IndexOf(string fullString, string findString) => fullString.IndexOf(findString);
        internal static int String_LastIndexOf(string fullString, string findString) => fullString.LastIndexOf(findString);
        internal static string String_LeftSubstring(string str, int length)
        {
            if (length >= str.Length) throw new Exception("Параметр length не должен быть больше длины строки str");
            else if (length < 0) throw new Exception("Параметр length не должен быть отрицательным значением");
            return str.Substring(0, length);
        }
        internal static string String_RightSubstring(string str, int length)
        {
            if (length >= str.Length) throw new Exception("Параметр length не должен быть больше длины строки str");
            else if (length < 0) throw new Exception("Параметр length не должен быть отрицательным значением");
            return str.Substring(str.Length - length, length);
        }
        internal static string String_Substring(string str, int start, int length)
        {
            if (length >= str.Length) throw new Exception("Параметр length не должен быть больше длины строки str");
            else if (length < 0) throw new Exception("Параметр length не должен быть отрицательным значением");
            else if (start >= str.Length) throw new Exception("Параметр start не должен быть больше длины строки str");
            else if (start < 0) throw new Exception("Параметр start не должен быть отрицательным значением");
            else if (start + length > str.Length) throw new Exception("Сумма параметров start+length не должна быть больше длины строки str");
            return str.Substring(start, length);
        }
        internal static string String_ToLower(string str) => str.ToLower();
        internal static string String_ToUpper(string str) => str.ToUpper();
        internal static string String_TrimLeft(string str) => str.TrimStart();
        internal static string String_TrimRight(string str) => str.TrimEnd();
        internal static string String_Trim(string str) => str.Trim();
        internal static string String_Replace(string fullString, string oldValue, string newValue) => fullString.Replace(oldValue, newValue);
        internal static string String_Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        internal static string String_CreateEmpty() => string.Empty;
        internal static string String_CreateSpaces(int length)
        {
            if (length < 0) throw new Exception("Параметр length не должен быть отрицательным значением");
            char[] spaces = new char[length];
            for (int i = 0; i < length; i++)
            {
                spaces[i] = ' ';
            }
            return new string(spaces);
        }
        internal static bool String_IsOnlyDigits(string str) => !str.ToCharArray().Any(x => !char.IsDigit(x));
        internal static bool String_IsOnlyLetters(string str) => !str.ToCharArray().Any(x => !char.IsLetter(x));
        internal static bool String_IsNumber(string str)
        {
            bool hasComma = false;
            foreach (char c in str)
            {
                if (char.IsDigit(c)) continue;
                else if ((c == ',' || c == '.') && !hasComma) hasComma = true;
                else return false;
            }
            return true;
        }
        internal static bool String_IsLowerCase(string str) => !str.AsEnumerable().Any(x => char.IsLetter(x) ? !char.IsLower(x) : true);
        internal static bool String_IsUpperCase(string str) => !str.AsEnumerable().Any(x => char.IsLetter(x) ? !char.IsUpper(x) : true);
        internal static bool String_IsEmpty(string str) => str.Length == 0;
        internal static string String_Copy(string str) => new string(str.ToCharArray());
        internal static string String_Format(string str, params object[] values) => string.Format(str, values);
    }
}
