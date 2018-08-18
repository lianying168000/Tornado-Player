﻿namespace Tornado.Player.ViewModels.Interfaces
{
    using Caliburn.Micro;

    internal interface IPlaylistViewModel : IViewModelBase
    {
        IObservableCollection<ITrackViewModel> Tracks { get; }

        int SelectedTrack { get; set; }
    }
}