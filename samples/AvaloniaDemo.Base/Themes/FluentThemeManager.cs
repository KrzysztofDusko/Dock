﻿using System;
using Avalonia;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;

namespace AvaloniaDemo.Themes;

public class FluentThemeManager : IThemeManager
{
    private static readonly Uri BaseUri = new("avares://AvaloniaDemo.Base/Styles");

    private static readonly FluentTheme Fluent = new(BaseUri)
    {
        Mode = FluentThemeMode.Light
    };

    private static readonly Styles DockFluent = new()
    {
        new StyleInclude(BaseUri)
        {
            Source = new Uri("avares://Dock.Avalonia/Themes/DockFluentTheme.axaml")
        }
    };

    private static readonly Styles FluentDark = new()
    {
        new StyleInclude(BaseUri)
        {
            Source = new Uri("avares://AvaloniaDemo.Base/Themes/FluentDark.axaml")
        }
    };

    private static readonly Styles FluentLight = new()
    {
        new StyleInclude(BaseUri)
        {
            Source = new Uri("avares://AvaloniaDemo.Base/Themes/FluentLight.axaml")
        }
    };

    public void Switch(int index)
    {
        if (Application.Current is null)
        {
            return;
        }

        switch (index)
        {
            // Fluent Light
            case 0:
            {
                if (Fluent.Mode != FluentThemeMode.Light)
                {
                    Fluent.Mode = FluentThemeMode.Light;
                }
                Application.Current.Styles[0] = Fluent;
                Application.Current.Styles[1] = DockFluent;
                Application.Current.Styles[2] = FluentLight;
                break;
            }
            // Fluent Dark
            case 1:
            {
                if (Fluent.Mode != FluentThemeMode.Dark)
                {
                    Fluent.Mode = FluentThemeMode.Dark;
                }
                Application.Current.Styles[0] = Fluent;
                Application.Current.Styles[1] = DockFluent;
                Application.Current.Styles[2] = FluentDark;
                break;
            }
        }
    }

    public void Initialize(Application application)
    {
        application.Styles.Insert(0, Fluent);
        application.Styles.Insert(1, DockFluent);
        application.Styles.Insert(2, FluentLight);
    }
}