﻿namespace Tornado.Player.ViewModels.Interfaces
{
    using Caliburn.Micro;

    internal interface IPlaylistViewModel : IViewModelBase
    {
        IObservableCollection<ITrackViewModel> Tracks { get; }

        int SelectedTrackIndex { get; set; }
    }
}