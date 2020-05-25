using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeApp.Infraestructure
{
    using ViewModels;

    class InstanceLocator
    {

        #region properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
