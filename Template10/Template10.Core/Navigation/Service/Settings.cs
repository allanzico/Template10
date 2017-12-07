﻿using System;
using Template10.Common;
using Template10.Extensions;
using Template10.Common;
using Template10.Services.Serialization;
using Template10.Strategies;
using Windows.UI.Xaml;
using Windows.Storage;
using System.Reflection;

namespace Template10.Navigation
{

    public static partial class Settings
    {
        public static bool RequireSerializableParameters { get; set; } = true;

        public static NavigationMethods NavigationMethod { get; set; } = NavigationMethods.Any;

        public static TimeSpan CacheMaxDuration
        {
            get => Windows.Storage.ApplicationData.Current.LocalSettings
                .TryRead<TimeSpan>(nameof(CacheMaxDuration), out var value) ? value : TimeSpan.FromDays(2);
            set => Windows.Storage.ApplicationData.Current.LocalSettings
                .TryWrite(nameof(CacheMaxDuration), value);
        }

        public static ElementTheme DefaultTheme { get; set; } = ElementTheme.Light;

        public static DateTime LastSuspended
        {
            get => ApplicationData.Current.LocalSettings.TryRead<DateTime>(nameof(LastSuspended), out var value) ? value : DateTime.MaxValue;
            set => ApplicationData.Current.LocalSettings.TryWrite(nameof(LastSuspended), value);
        }

        public static PageKeyRegistry PageKeyRegistry { get; } = new PageKeyRegistry();
    }
}

