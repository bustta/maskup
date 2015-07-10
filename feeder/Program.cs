﻿using feeder.Service;
using Microsoft.Azure.WebJobs;
using System;

namespace feeder
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    internal class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        private static void Main()
        {
            var host = new JobHost();
            // The following code will invoke a function called ManualTrigger and
            // pass in data (value in this case) to the function
            host.Call(typeof(Functions).GetMethod("ManualTrigger"), new { value = 20 });
        }
    }
}