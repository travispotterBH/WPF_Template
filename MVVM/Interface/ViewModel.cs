using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace WPF_Template.Interface
{
    public abstract class ViewModel : BaseNotifyPropertyChanged
    {
        public virtual ViewModel ParentViewModel { get; set; }
        public virtual Window OwnerView { get; set; }
        public IModel Memento { get; set; }

        public virtual Action ExecutionFinishedAction { get; set; }

        public ICommand CancelCommand { get; set; }
        public ICommand OkCommand { get; set; }

        internal abstract void OkCommandAction();

        internal abstract void CancelCommandAction();

        internal void SetupBaseCommands()
        {
            OkCommand = new RouteCommands(OkCommandAction);
            CancelCommand = new RouteCommands(CancelCommandAction);
        }
    }
}
