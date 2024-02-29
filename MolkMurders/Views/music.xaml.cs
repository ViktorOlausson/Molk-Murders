using Microsoft.UI.Xaml;
namespace MolkMurders.Views;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core.Primitives;

public partial class music
{
    public music()
    {
        InitializeComponent();

    }


    private void doneBtn_Clicked(object sender, EventArgs e)
    {
        Close();
    }



    void OnPlayPauseButtonClicked(object sender, EventArgs args)
    {
        if (mediaElement.CurrentState == MediaElementState.Stopped ||
            mediaElement.CurrentState == MediaElementState.Paused)
        {
            mediaElement.Play();
            PlayPause.Text = "PÅ";


        }
        else if (mediaElement.CurrentState == MediaElementState.Playing)
        {
            mediaElement.Pause();
            PlayPause.Text = "AV";

        }
    }
}