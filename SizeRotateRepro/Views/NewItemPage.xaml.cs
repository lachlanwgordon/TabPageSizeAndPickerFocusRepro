using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SizeRotateRepro.Models;
using System.Diagnostics;

namespace SizeRotateRepro.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public void Handle_FocusChangeRequested(object sender, FocusRequestArgs e)
        {
            Debug.WriteLine("Focus Change Requested");
        }

        public void Handle_Unfocused(object sender, FocusEventArgs e)
        {
            Debug.WriteLine("Picker UNfocused");

        }

        public void Handle_Focused(object sender, FocusEventArgs e)
        {
            Debug.WriteLine("Picker focused");
        }

        public void Handle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Picker index changed");
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Debug Clicked");
        }


        public NewItemPage()
        {
            InitializeComponent();

            VM.Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            //BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", VM.Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}