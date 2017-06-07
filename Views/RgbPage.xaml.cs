﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorSelectorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RgbPage : ContentPage
    {
        public RgbPage()
        {
            InitializeComponent();
        }

        int _sliderR, _sliderG, _sliderB;

        private void SliderR_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _sliderR = Convert.ToInt32(SliderR.Value);
            GenerateRgbColors(_sliderR, _sliderG, _sliderB);

            RValue.Text = _sliderR.ToString();
        }


        private void SliderG_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _sliderG = Convert.ToInt32(SliderG.Value);
            GenerateRgbColors(_sliderR, _sliderG, _sliderB);

            GValue.Text = _sliderG.ToString();
        }

        private void SliderB_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _sliderB = Convert.ToInt32(SliderB.Value);
            GenerateRgbColors(_sliderR, _sliderG, _sliderB);

            BValue.Text = _sliderB.ToString();
        }

        private void GenerateRgbColors(int sliderR, int sliderG, int sliderB)
        {
            TxtColorPreviewer.BackgroundColor = Color.FromRgb(sliderR, sliderG, sliderB);
        }
    }
}
