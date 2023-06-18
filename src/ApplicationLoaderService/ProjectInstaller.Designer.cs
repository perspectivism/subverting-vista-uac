namespace Toolkit
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInstaller));
            this.loaderServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.loaderServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // loaderServiceProcessInstaller
            // 
            this.loaderServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.loaderServiceProcessInstaller.Password = null;
            this.loaderServiceProcessInstaller.Username = null;
            // 
            // loaderServiceInstaller
            // 
            this.loaderServiceInstaller.Description = resources.GetString("loaderServiceInstaller.Description");
            this.loaderServiceInstaller.ServiceName = "LoaderService";
            this.loaderServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.loaderServiceProcessInstaller,
            this.loaderServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller loaderServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller loaderServiceInstaller;
    }
}