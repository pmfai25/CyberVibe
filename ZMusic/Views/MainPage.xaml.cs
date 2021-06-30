﻿using System;

using Windows.UI.Xaml.Controls;

using ZMusic.ViewModels;

namespace ZMusic.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
