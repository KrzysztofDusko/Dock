﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DockMvvmSample.Views.Tools;

public partial class Tool2View : UserControl
{
    public Tool2View()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
