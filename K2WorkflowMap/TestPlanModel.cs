using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2WorkflowMap
{

    //public enum TestToRun
    //{
    //    Start = 1,
    //    CheckStatus = 2,
    //    TaskExists = 3,
    //    TaskCount = 4,
    //    CheckTask = 5,
    //    OpenTaskDetails = 6,
    //    TaskActions = 7,
    //    CompleteTask = 8,
    //    GetActivities = 9

    //}


    public class TestPlanDetails
    {
        public string TestName { get; set; }
        public string WorkflowName  { get; set; }
        public int ProcessTypeId  { get; set; }
        public int ProcessInstanceId { get; set; }
        public string Folio { get; set; }
        public string Originator { get; set; }
        public string Started { get; set; }
        public DateTime StartedDate { get; set; }
        public string Finished { get; set; }
        public DateTime FinishedDate { get; set; }
        public string Status { get; set; }
        public string Route { get; set; }
    }



    public class TestPlanTest
    {
     public   int TestRunId { get; set; }
        public int TestTypeId { get; set; }
        public string TestType { get; set; }
        public string ExpectedResult { get; set; }
        public string LeftParameter { get; set; }
        public string MiddleParameter { get; set; }
        public string RightParameter { get; set; }
        public int NumberOfParameters { get; set; }
        
        public int Milliseconds { get; set; }

        public string Sign { get; set; }

    }

    public class MethodList
    {
        public string MethodName { get; set; }
        public int NumberOfParameters { get; set; }

        public string LeftParameter { get; set; }
        public string MiddleParameter { get; set; }
        public string RightParameter { get; set; }

    }
}
