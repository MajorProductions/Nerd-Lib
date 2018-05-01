﻿using System;

namespace NerdLib.Console
{
    /// <summary>
    /// Controls for the console itself.
    /// </summary>
    public static class Console
    {

        /// <summary>
        /// Change both the width and the height of the console application.
        /// </summary>
        /// <param name="columnCount">The new column count.</param>
        /// <param name="rowCount">The new row count.</param>
        public static void Size(int columnCount, int rowCount)
        {
            System.Console.SetWindowSize(columnCount, rowCount);
        }

        /// <summary>
        /// Change only the width of the console application.
        /// </summary>
        /// <param name="columnCount">The new column count.</param>
        private static void SizeWidth(int columnCount)
        {
            System.Console.SetWindowSize(columnCount, System.Console.WindowHeight);
        }

        /// <summary>
        /// Change only the height of the console application.
        /// </summary>
        /// <param name="rowCount">The new row count.</param>
        private static void SizeHeight(int rowCount)
        {
            System.Console.SetWindowSize(System.Console.WindowWidth, rowCount);
        }

        /// <summary>
        /// Change the title of the console application.
        /// </summary>
        /// <param name="newTitle">The new title.</param>
        public static void Title(string newTitle)
        {
            System.Console.Title = newTitle;
        }

        /// <summary>
        /// Play a loud beep sound.
        /// </summary>
        public static void Beep()
        {
            System.Console.Beep();
        }

        /// <summary>
        /// Hides the cursor from the user.
        /// </summary>
        public static void CursorHide()
        {
            System.Console.CursorVisible = false;
        }

        /// <summary>
        /// Unhides the cursor from the user.
        /// </summary>
        public static void CursorShow()
        {
            System.Console.CursorVisible = true;
        }

        /// <summary>
        /// Clear the console applications display.
        /// </summary>
        public static void Clear()
        {
            System.Console.Clear();
        }
    }

    /// <summary>
    /// Controls for the console's colors.
    /// </summary>
    public static class Color
    {
        public static Colors CurrentForeground { get; private set; } = Colors.White;
        public static Colors CurrentBackground { get; private set; } = Colors.Black;

        /// <summary>
        /// Set of colors supported by the console application.
        /// </summary>
        public enum Colors
        {
            Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White
        }

        /// <summary>
        /// Change the foreground color of the console application.
        /// </summary>
        /// <param name="color">Colors.Color you are changing it to.</param>
        public static void Foreground(Colors color)
        {
            CurrentForeground = color;
            switch (color)
            {
                case Colors.Black:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                case Colors.DarkBlue:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case Colors.DarkGreen:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case Colors.DarkCyan:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    }
                case Colors.DarkRed:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case Colors.DarkMagenta:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    }
                case Colors.DarkYellow:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    }
                case Colors.Gray:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                case Colors.DarkGray:
                    {
                        System.Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                case Colors.Blue:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case Colors.Green:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case Colors.Cyan:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case Colors.Red:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case Colors.Magenta:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case Colors.Yellow:
                    {
                        System.Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }
                case Colors.White:
                    {
                        System.Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                default:
                    goto case Colors.White;
            }
        }

        /// <summary>
        /// Change the background color of the console application.
        /// </summary>
        /// <param name="color">Colors.Color you are changing it to.</param>
        public static void Background(Colors color)
        {
            CurrentBackground = color;
            switch (color)
            {
                case Colors.Black:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    }
                case Colors.DarkBlue:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case Colors.DarkGreen:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case Colors.DarkCyan:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkCyan;
                        break;
                    }
                case Colors.DarkRed:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case Colors.DarkMagenta:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        break;
                    }
                case Colors.DarkYellow:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkYellow;
                        break;
                    }
                case Colors.Gray:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Gray;
                        break;
                    }
                case Colors.DarkGray:
                    {
                        System.Console.BackgroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                case Colors.Blue:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    }
                case Colors.Green:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    }
                case Colors.Cyan:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case Colors.Red:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    }
                case Colors.Magenta:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case Colors.Yellow:
                    {
                        System.Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    }
                case Colors.White:
                    {
                        System.Console.BackgroundColor = ConsoleColor.White;
                        break;
                    }
                default:
                    goto case Colors.Black;
            }
        }
    }

    /// <summary>
    /// Controls for displaying Error, Warning, and Debug logs.
    /// </summary>
    public static class Log
    {
        public static Color.Colors oldCol = new Color.Colors();

        // NOTE: Currently these use the console to display their output, but I am looking to to other display methods.

        /// <summary>
        /// Sends a Debug message to the console application.
        /// </summary>
        /// <param name="message">The message you want to appear.</param>
        /// <param name="Code">The code you want to appear. (Used to track down in code)</param>
        public static void LogDebug(string message, string Code)
        {
            oldCol = Color.CurrentForeground;
            Color.Foreground(Color.Colors.Cyan);
            System.Console.WriteLine(" DebugCode:" + Code + " -  " + message);
            System.Console.ReadLine();
            Color.Foreground(oldCol);
        }

        /// <summary>
        /// Sends a Debug message to the console application.
        /// </summary>
        /// <param name="message">The message you want to appear.</param>
        public static void LogDebug(string message)
        {
            oldCol = Color.CurrentForeground;
            Color.Foreground(Color.Colors.Cyan);
            System.Console.WriteLine(" Debug" + " -  " + message);
            System.Console.ReadLine();
            Color.Foreground(oldCol);
        }

        /// <summary>
        /// Sends a Warning message to the console application.
        /// </summary>
        /// <param name="message">The message you want to appear.</param>
        /// <param name="Code">The code you want to appear. (Used to track down in code)</param>
        public static void LogWarning(string message, string Code)
        {
            oldCol = Color.CurrentForeground;
            Color.Foreground(Color.Colors.Yellow);
            System.Console.WriteLine(" WarningCode:" + Code + " -  " + message);
            System.Console.ReadLine();
            Color.Foreground(oldCol);
        }

        /// <summary>
        /// Sends a Warning message to the console application.
        /// </summary>
        /// <param name="message">The message you want to appear.</param>
        public static void LogWarning(string message)
        {
            oldCol = Color.CurrentForeground;
            Color.Foreground(Color.Colors.Yellow);
            System.Console.WriteLine(" Warning" + " -  " + message);
            System.Console.ReadLine();
            Color.Foreground(oldCol);
        }

        /// <summary>
        /// Sends a Error message to the console application.
        /// </summary>
        /// <param name="message">The message you want to appear.</param>
        /// <param name="Code">The code you want to appear. (Used to track down in code)</param>
        public static void LogError(string message, string Code)
        {
            oldCol = Color.CurrentForeground;
            Color.Foreground(Color.Colors.Red);
            System.Console.WriteLine(" ErrorCode:" + Code + " -  " + message);
            System.Console.ReadLine();
            Color.Foreground(oldCol);
        }

        /// <summary>
        /// Sends a Error message to the console application.
        /// </summary>
        /// <param name="message">The message you want to appear.</param>
        public static void LogError(string message)
        {
            oldCol = Color.CurrentForeground;
            Color.Foreground(Color.Colors.Red);
            System.Console.WriteLine(" Error" + " -  " + message);
            System.Console.ReadLine();
            Color.Foreground(oldCol);
        }

    }
}
