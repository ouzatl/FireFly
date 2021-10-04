namespace FireFly.BackgroundService
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
            this.FireflyService = new System.ServiceProcess.ServiceProcessInstaller();
            this.FireFlyInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // FireflyService
            // 
            this.FireflyService.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.FireflyService.Password = null;
            this.FireflyService.Username = null;
            this.FireflyService.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
            // 
            // FireFlyInstaller
            // 
            this.FireFlyInstaller.ServiceName = "WriteCurrentTimeService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.FireflyService,
            this.FireFlyInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller FireflyService;
        private System.ServiceProcess.ServiceInstaller FireFlyInstaller;
    }
}