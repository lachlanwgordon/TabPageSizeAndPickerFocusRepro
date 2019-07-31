using System;
using System.Diagnostics;
using System.Windows.Input;
using SizeRotateRepro.Models;
using Xamarin.Forms;
using System.Collections;
using System.Collections.Generic;

namespace SizeRotateRepro.ViewModels
{
    public class NewItemViewModel
    {
        public List<string> Items
        {
            get;
            set;
        } = new List<string> { "Hello", "Goodbye", "Chicken" };

        public Item Item { get; set; }

        public ICommand DebugCommand
        {
            get
            {
                return new Command(() =>
                {
                    Debug.WriteLine("Go Command");
                });
            }
        }
    }
}