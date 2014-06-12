using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyWatch
{
    class ShellViewModel : BindableBase
    {
        public string RibbonRegionName
        {
            get
            {
                return ConfigurationManager.AppSettings["RibbonRegionName"] as string;
            }
        }

        public string WorkspaceRegionName
        {
            get
            {
                return ConfigurationManager.AppSettings["WorkspaceRegionName"] as string;
            }
        }
    }
}
