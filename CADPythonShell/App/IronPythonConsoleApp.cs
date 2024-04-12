using CADPythonShell.Command;


using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;
using Aveva.Core.PMLNet;

namespace CADPythonShell.App
{
    public class IronPythonConsoleApp : IAddin
    {
        //обьявляем переменные
        public static ServiceManager ServicManag;
        public static CommandManager CommadManag;
        public static CommandBarManager CommandBarManag;
        public static CommandBar MyToolBar;

        public string Name
        { get { return "Aveva_e3d_PythonConsole"; } }

        public string Description { get { return "Python plugin for AVEVA e3D"; } }

        public void Start(ServiceManager serviceManager)
        {
            ServicManag = serviceManager;
            CommadManag = (CommandManager)ServicManag.GetService(typeof(CommandManager));
            //CommandBarManag = (CommandBarManager)ServicManag.GetService(typeof(CommandBarManager));

            DockedWindowCmd doc2 = new DockedWindowCmd();

            CommadManag.Commands.Add(doc2);
            //CommadManag.Commands.Add(new CommandFilter("IronPythonConsoleCommand"));
            //CommadManag.Commands.Add(new CommandFilter("ConfigureCommand"));
            //////////////////////
            //panel

            //MyToolBar = CommandBarManag.CommandBars.AddCommandBar("Панелька");
            ////buttons
            //CommandBarManag.RootTools.AddButtonTool("key1", "IronPythonConsoleCommand", null, new CommandFilter("IronPythonConsoleCommand"));
            //MyToolBar.Tools.AddTool("key1");
            //CommandBarManag.RootTools.AddButtonTool("key2", "ConfigureCommand", null, new CommandFilter("ConfigureCommand"));
            //MyToolBar.Tools.AddTool("key2");
        }

        public void Stop()
        {
            
        }
    }
    public class DockedWindowCmd : Aveva.ApplicationFramework.Presentation.Command
    {
        DockedWindow _myWindow;
        public DockedWindowCmd ()
        {
            base.Key = "IronPythonConsoleAddin.Form";

            
        }
        public override void Execute()
        {
            new IronPythonConsoleCommand().Execute();
        }
    }
    //panel button check
    //[PMLNetCallable()]
    public class CommandFilter : Aveva.ApplicationFramework.Presentation.Command
    {

        public CommandFilter()
        {
        }

        public CommandFilter(string key)
        {
            this.Value = key;
        }
        [PMLNetCallable()]
        public override void Execute()
        {
            string tester = (string)this.Value;
            try
            {
                switch (tester)
                {

                    case "IronPythonConsoleCommand":
                        {
                            new IronPythonConsoleCommand().Execute();
                        }
                        break;
                    case "IronPythonConsoleAddin.ConfigureCommand":
                        {
                            new ConfigureCommand().Execute();
                        }
                        break;
                }
            }
            catch { }
        }
    }
}