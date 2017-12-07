﻿using System;

namespace Template10.Strategies
{
    public static partial class Settings
    {
        public static bool EnableExtendedSessionStrategy { get; set; } = false;
    }

    public static partial class Settings
    {
        internal static DateTime LastSuspended
        {
            get => Navigation.Settings.LastSuspended;
            set => Navigation.Settings.LastSuspended = value;
        }

        /// <summary>
        /// Every time the app starts, try to resume, ignore previous state
        /// </summary>
        public static bool AppAlwaysResumes { get; set; } = false;

        public static bool EnableLifecycleStrategy { get; set; } = true;
    }
}
