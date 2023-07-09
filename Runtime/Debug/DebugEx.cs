using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NCat
{
    public static class DebugEx
    {
        public const string Color_Red = "#ff0000FF";
        public const string Color_Green = "#00ff00ff";
        public const string Color_Blue = "#8888ffff";
        public const string Color_Yellow = "yellow";
        public const string Color_Cyan = "cyan";
        public const string Color_Puple = "#FF00FFff";



        private static readonly string FormatColorStr = "<color={0}>{1}</color>\n";
        public static void LogFormatColor(string color, string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, color, format), args);
        }

        public static void LogFormatColorRed(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Red, format), args);
        }

        public static void LogFormatColorGreen(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Green, format), args);
        }
        public static void LogFormatColorGreen(UnityEngine.Object contex, string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(contex, string.Format(FormatColorStr, Color_Green, format), args);
        }

        public static void LogFormatColorBlue(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Blue, format), args);
        }

        public static void LogFormatColorYellow(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Yellow, format), args);
        }

        public static void LogFormatColorCyan(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Cyan, format), args);
        }
        public static void LogFormatColorPuple(UnityEngine.Object contex, string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(contex, string.Format(FormatColorStr, Color_Puple, format), args);
        }

        public static void LogFormatColorPuple(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Puple, format), args);
        }

        public static void LogFormatEditor(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Blue, format), args);
        }

        public static void LogFormatEditor(string content, UnityEngine.Object contex)
        {
            UnityEngine.Debug.LogFormat(contex, string.Format(FormatColorStr, Color_Blue, content));
        }

        public static void LogFormatGame(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat(string.Format(FormatColorStr, Color_Blue, format), args);
        }

        public static void LogFormatInit(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat("[Init]" + string.Format(FormatColorStr, Color_Cyan, format), args);
        }

        public static void LogFormatFlow(string format, params object[] args)
        {
            UnityEngine.Debug.LogFormat("[Flow]" + string.Format(FormatColorStr, Color_Green, format), args);
        }
    }
} // namespace NCat