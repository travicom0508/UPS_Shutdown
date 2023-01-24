#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
#endregion

public class resetFlags : BaseNetLogic
{

    IUAVariable resetFlag;

    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        resetFlag = Project.Current.GetVariable("Model/UPS_OnBattery_Input");
        resetFlag.Value = false;
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
