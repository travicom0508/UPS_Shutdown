#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using System.Runtime.Serialization;
using System.Diagnostics;
#endregion

public class netShutdownPC : BaseNetLogic
{
    IUAVariable feedback;
    IUAVariable shutdReq;
    IUAVariable ProgCmd;
    IUAVariable ProgPars;


    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        feedback = LogicObject.GetVariable("varFeedback");
        shutdReq = LogicObject.GetVariable("varShutdReq");
        ProgCmd = LogicObject.GetVariable("varProgStr");
        ProgPars = LogicObject.GetVariable("varProgPars");

    }


    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void LaunchCmd()
    {
        // Insert code to be executed by the method
        if (shutdReq.Value == 1)
        {
            feedback.Value = 1;
            ProcessStartInfo startInfo = new ProcessStartInfo(ProgCmd.Value, ProgPars.Value);
            Process.Start(startInfo);

        }
    }
}
