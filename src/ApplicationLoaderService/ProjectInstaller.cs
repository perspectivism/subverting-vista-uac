using System;
using System.ComponentModel;
using System.Configuration.Install;

namespace Toolkit
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
