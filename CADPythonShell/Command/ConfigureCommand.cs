using CADPythonShell.App;

namespace CADPythonShell.Command
{
    /// <summary>
    /// Open the configuration dialog.
    /// </summary>

    public class ConfigureCommand : ICadCommand
    {
        
        public override void Execute()
        {
            ////load the application
            //if (!CADPythonShellApplication.applicationLoaded)
            //{
            //    CADPythonShellApplication.OnLoaded();
            //}

            //var dialog = new ConfigureCommandsForm();
            //dialog.StartPosition = FormStartPosition.CenterScreen;
            //NativeWindow nativeWindow = new NativeWindow();
            //nativeWindow.AssignHandle(Application.MainWindow.Handle);
            //dialog.ShowDialog(nativeWindow);
        }
    }
}