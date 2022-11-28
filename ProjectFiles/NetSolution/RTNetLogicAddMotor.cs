#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.WebUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.DataLogger;
using FTOptix.CommunicationDriver;
using FTOptix.EventLogger;
using FTOptix.ODBCStore;
#endregion

public class RTNetLogicAddMotor : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void AddNewMotor()
    {
        var motors = Project.Current.Get("Model/Instances/Motors");
        string newMotorName = "Motor" + (motors.Children.Count + 1);
        var newMotor = InformationModel.MakeObject<MotorType>(newMotorName);
        motors.Children.Add(newMotor);
    }
}
