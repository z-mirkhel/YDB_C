using Newtonsoft.Json;
using Ydb.Sdk.Services.Table;
using Ydb.Sdk;

namespace YDBwithForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}