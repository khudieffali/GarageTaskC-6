using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage_TaskC_6
{
    internal class Garage_Task_11
    {
        //static void Main(string[] args)
        //{
            #region Task 1
            //string word = "Salam";
            //Console.WriteLine(Reverse(word));
            #endregion
            #region Task 2
            //string lt = "a::b::c::d::e";
            //Console.WriteLine(GetLetter(lt));
            #endregion
            #region Task 3
            //string lt2 = "a b,c.d/e";
            //Console.WriteLine(GetLetter2(lt2));
            #endregion
            #region Task 4
            //string rm = "banana";
            //Console.WriteLine(RemoveLetter(rm));
            #endregion
            #region Task 5
            //string txt = "zaz";
            //Console.WriteLine(GetPolindrom(txt));
            #endregion
        //}
        #region Task 1      
        //static string Reverse(string word)
        //{
        //    string rev = "";
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        rev += word[i];
        //    }
        //    rev = rev[0].ToString().ToUpper() + rev.Substring(1).ToLower();
            
        //    return rev;

        //}
        #endregion
        #region Task 2
        //static string GetLetter(string lt)
        //{
        //    string[] endLt=lt.Split(":");
        //    lt = "";
        //    foreach (var item in endLt)
        //    {
        //        lt += item;
        //    }
        //    return lt;
        //}

        #endregion
        #region Task 3
        //static string GetLetter2(string lt2)
        //{
        //    string[] endLt2 = lt2.Split(' ',',','.','/');
        //    lt2 = "";
        //    foreach (var item in endLt2)
        //    {
        //        lt2 += item;
        //    }
        //    return lt2;
        //}
        #endregion
        #region Task 4
        //static string RemoveLetter(string rm)
        //{
        //    string[] endRm = rm.Split('a');
        //    rm = "";
        //    foreach (var item in endRm)
        //    {
        //        rm += item;
        //    }
        //    return rm;
        //}
        #endregion
        #region Task 5
        //static bool GetPolindrom(string text)
        //{
        //    string firstText="";
        //    for (int i = text.Length-1; i >=0; i--)
        //    {
        //        firstText += text[i];
        //    }
        //    if (text == firstText)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        #endregion
    }
}
