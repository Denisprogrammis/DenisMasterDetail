﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterAUTO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class audi : ContentPage
    {
        public audi()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}