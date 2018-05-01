using System;

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
        /// <summary>
        /// The Color.Colors the foreground is currently set to.
        /// </summary>
        public static Colors CurrentForeground { get; private set; } = Colors.White;

        /// <summary>
        /// The Color.Colors the background is currently set to.
        /// </summary>
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
        private static Color.Colors oldCol = new Color.Colors();

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

    /// <summary>
    /// Controls all output to the console application.
    /// </summary>
    public static class Send
    {

        /// <summary>
        /// Displays all queued messages.
        /// </summary>
        public static void Display()
        {
            System.Console.ReadKey();
        }

        /// <summary>
        /// Send a message.
        /// </summary>
        /// <param name="message">The message you are sending.</param>
        public static void Message(string message)
        {
            System.Console.WriteLine(message);
        }

        /// <summary>
        /// Send a message and optionally display as soon as it's sent.
        /// </summary>
        /// <param name="message">The message you are sending.</param>
        /// <param name="displayNow">True: Calls Display();  -  False: Does not call function.</param>
        public static void Message(string message, bool displayNow)
        {
            System.Console.WriteLine(message);
            if (displayNow) { Display(); }
        }

        /// <summary>
        /// Send a message using a specified color.
        /// </summary>
        /// <param name="message">The message you are sending.</param>
        /// <param name="messageColor">Color.Colors the message will be in.</param>
        public static void Message(string message, Color.Colors messageColor)
        {
            Color.Colors oldFore = Color.CurrentForeground;
            Color.Foreground(messageColor);
            System.Console.WriteLine(message);
            Color.Foreground(oldFore);
        }

        /// <summary>
        /// Send a message using a specified color and optionally displaying as soon as it's sent.
        /// </summary>
        /// <param name="message">The message you are sending.</param>
        /// <param name="messageColor">Color.Colors the message will be in.</param>
        /// <param name="displayNow">True: Calls Display();  -  False: Does not call function.</param>
        public static void Message(string message, Color.Colors messageColor, bool displayNow)
        {
            Color.Colors oldFore = Color.CurrentForeground;
            Color.Foreground(messageColor);
            System.Console.WriteLine(message);
            Color.Foreground(oldFore);
            if (displayNow) { Display(); }
        }

        /// <summary>
        /// Send multiple messages at once.
        /// </summary>
        /// <param name="message">The messages you are sending.</param>
        public static void MultiMessage(string[] message)
        {
            foreach (string input in message)
            {
                Message(input);
            }
        }

        /// <summary>
        /// Send multiple messages and optionally display them as soon as they are sent.
        /// </summary>
        /// <param name="message">The messages you are sending.</param>
        /// <param name="displayNow">True: Calls Display();  -  False: Does not call function.</param>
        public static void MultiMessage(string[] message, bool displayNow)
        {
            foreach (string input in message)
            {
                Message(input);
            }
            if (displayNow) { Display(); }
        }

        /// <summary>
        /// Sends multiple messages all using a specified color.
        /// </summary>
        /// <param name="message">The messages you are sending.</param>
        /// <param name="messageColor">Color.Colors the messages will be in.</param>
        public static void MultiMessage(string[] message, Color.Colors messageColor)
        {
            foreach (string input in message)
            {
                Message(input, messageColor);
            }
        }

        /// <summary>
        /// Sends multiple messages using a specified color and optionally display them as soon as they are sent.
        /// </summary>
        /// <param name="message">The messages you are sending.</param>
        /// <param name="messageColor">Color.Colors the messages will be in.</param>
        /// <param name="displayNow">True: Calls Display();  -  False: Does not call function.</param>
        public static void MultiMessage(string[] message, Color.Colors messageColor, bool displayNow)
        {
            foreach (string input in message)
            {
                Message(input, messageColor);
            }
            if (displayNow) { Display(); }
        }
    }

    public static class Input
    {

        /// <summary>
        /// Request an int from the user. Keeps requesting until a valid int is given.
        /// </summary>
        /// <returns></returns>
        public static int RequestInt()
        {
            int intoutput = 0;
            bool passedTest = false;
            while (!passedTest)
            {
                string result = System.Console.ReadLine();
                if (int.TryParse(result, out intoutput))
                {
                    passedTest = true;
                }
                else
                {
                    Log.LogError("The given response was not a int!");
                }
            }
            return intoutput;
        }

        /// <summary>
        /// Request an int from the user. Keeps requesting until a valid int is given. Text is displayed inline.
        /// </summary>
        /// <param name="inLineString">The text displayed before the request.</param>
        /// <returns></returns>
        public static int RequestInt(string inLineString)
        {
            int intoutput = 0;
            bool passedTest = false;
            while (!passedTest)
            {
                System.Console.Write(inLineString);
                string result = System.Console.ReadLine();
                if (int.TryParse(result, out intoutput))
                {
                    passedTest = true;
                }
                else
                {
                    Log.LogError("The given response was not a int!");
                }
            }
            return intoutput;
        }

        /// <summary>
        /// Requests a string from the user.
        /// </summary>
        /// <returns></returns>
        public static string RequestString()
        {
            return System.Console.ReadLine();
        }

        /// <summary>
        /// Requests a string from the user. Text is displayed inline.
        /// </summary>
        /// <param name="inLineString">The text displayed before the request.</param>
        /// <returns></returns>
        public static string RequestString(string inLineString)
        {
            System.Console.Write(inLineString);
            return System.Console.ReadLine();
        }

        /// <summary>
        /// Requests a bool from the user. Keeps requesting until a valid bool is given.
        /// </summary>
        /// <returns></returns>
        public static bool RequestBool()
        {
            bool passedTest = false;
            bool outputBool = false;
            while (!passedTest)
            {
                string result = System.Console.ReadLine();
                if (result == "true") { passedTest = true; outputBool = true; }
                else if (result == "false") { passedTest = true; outputBool = false; }
                else
                {
                    Log.LogWarning("The given response was not a bool!");
                }
            }
            return outputBool;
        }

        /// <summary>
        /// Requests a bool from the user. Keeps requesting until a valid bool is given. Text is displayed inline.
        /// </summary>
        /// <param name="inLineString">The text displayed before the request.</param>
        /// <returns></returns>
        public static bool RequestBool(string inLineString)
        {
            bool passedTest = false;
            bool outputBool = false;
            while (!passedTest)
            {
                System.Console.Write(inLineString);
                string result = System.Console.ReadLine();
                if (result == "true") { passedTest = true; outputBool = true; }
                else if (result == "false") { passedTest = true; outputBool = false; }
                else
                {
                    Log.LogWarning("The given response was not a bool!");
                }
            }
            return outputBool;
        }
    }
}
