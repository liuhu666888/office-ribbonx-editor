﻿using System;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;

namespace OfficeRibbonXEditor.Interfaces
{
    public interface IContentDialogBase
    {
        bool Cancelled { get; }

        RelayCommand<CancelEventArgs> ClosingCommand { get; }

        event EventHandler Closed;
    }

    public interface IContentDialog<in TPayload> : IContentDialogBase
    {
        void OnLoaded(TPayload payload);
    }
}
