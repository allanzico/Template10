﻿using Template10.Common;
using Template10.Services.NavigationService;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace Template10.Services.WindowWrapper
{
    public interface IWindowWrapper
    {
        object Content { get; }
        IDispatcherWrapper Dispatcher { get; }
        NavigationServiceList NavigationServices { get; }
        Window Window { get; }

        ApplicationView ApplicationView();
        void Close();
        DisplayInformation DisplayInformation();
        UIViewSettings UIViewSettings();
    }
}