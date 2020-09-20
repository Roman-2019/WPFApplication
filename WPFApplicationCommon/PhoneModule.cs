using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace WPFApplicationCommon
{
    public class PhoneModule: IModule
    {
        private IRegionManager _regionManager;
        public PhoneModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.PhoneView));
        }
    }
}
