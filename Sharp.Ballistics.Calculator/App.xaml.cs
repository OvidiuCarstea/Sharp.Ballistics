﻿using Sharp.Ballistics.Calculator.Bootstrap;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Sharp.Ballistics.Calculator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AppBootstrapper bootstrapper;
        public App()
        {
            bootstrapper = new AppBootstrapper();
            bootstrapper.Initialize();
            Exit += OnExit;
        }

        private void OnExit(object sender, ExitEventArgs e)
        {
            bootstrapper.Dispose();
        }
    }
}