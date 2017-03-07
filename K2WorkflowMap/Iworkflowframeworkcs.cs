using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2WorkflowMap
{
    interface Iworkflowframeworkcs
    {

        int StartProcess(string Folio, string ProcessName);
        Boolean IsTaskFound(string ProcessInstanceId, string ProcessName);
        int GetTaskCount(string ProcessInstanceId, string ProcessName);

        List<tasklist> GetTask(string ProcessInstanceId, string ProcessName);
        List<TaskDetails> OpenTask(string serialnumber, string destination);

        List<ActionList> WhatCanIdo(SourceCode.Workflow.Client.Actions actions);

        Boolean ActionTask(string action, string serialnumber, string destinationuser);

        Boolean IsTaskComplete(string ProcInst, int Count, string processname);

        Boolean IsTaskComplete(string action, string serialnumber, string destinationuser);

        string GetWorkflowStatus(string processinstanceId);

        List<dataField> GetProcessDataFields(string processinstanceId);

        List<Activities> GetActivities(string processinstanceId);

        List<Events> GetEvents(string activityid);

        List<ActivityDesign> GetWorkflowActivities(int ProcId);

        List<Workflow> GetProcesses();

    }
}
