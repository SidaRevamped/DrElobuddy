﻿using System;
using System.Drawing;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Garen
{
    public static class Program
    {
        // Change this line to the champion you want to make the addon for,
        // watch out for the case being correct!
        public const string ChampName = "Garen";
        private static Text Text { get; set; }

        public static void Main(string[] args)
        {
            // Wait till the loading screen has passed
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            // Verify the champion we made this addon for
            if (Player.Instance.ChampionName != ChampName)
            {
                // Champion is not the one we made this addon for,
                // therefore we return
                return;
            }

            // Initialize the classes that we need
            Events.Initialize();
            Config.Initialize();
            SpellManager.Initialize();
            ModeManager.Initialize();
            WelcomeMsg();
        }

        private static void WelcomeMsg()
        {
            Chat.Print("Doctor{0} Loaded.", System.Drawing.Color.LightBlue, ChampName);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Doctor{0} Loaded. Good Luck!", ChampName);
            Console.ResetColor();
        }
    }
}
