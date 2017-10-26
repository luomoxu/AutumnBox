﻿using AutumnBox.Basic.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutumnBox.Basic.Executer;
using AutumnBox.Basic.Function.Args;
using AutumnBox.Basic.Function.Event;

namespace AutumnBox.ConsoleTester.ObjTest
{
    public class TestModuleTest : FunctionModule
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Console.WriteLine(e.ModuleArgs is FileArgs);
        }
        protected override OutputData MainMethod()
        {
            Console.WriteLine("Execute Main Method");
            return new OutputData();
        }
        public static void StartTest()
        {
            var o = FunctionModuleProxy.Create<TestModuleTest>(new FileArgs(new Basic.Devices.DeviceBasicInfo()));
        }
    }
}
