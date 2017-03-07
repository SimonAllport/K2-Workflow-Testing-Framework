using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2WorkflowMap
{
  
   


    public class Endpoint
    {



        public static int Start(string Folio, string WorkflowName)
        {
            int result = 0;
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            try
            {
                result = framework.StartProcess(Folio, WorkflowName);
            }
            catch (Exception ex)
            {

                result = 0;
            }
            finally {

            }

            return result;
        }


        public static string CheckWorkflowStatus(string ProcessInstanceId)
        {
            string result = string.Empty;
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();

            try
            {
                result = framework.GetWorkflowStatus(ProcessInstanceId);
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            finally
            {

            }

            return result;

        }

        public static bool TasksExist(string ProcessInstanceId, string ProcessName)
        {
            bool result = false;
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            try
            {
                result = framework.IsTaskFound(ProcessInstanceId, ProcessName);
            }
            catch (Exception ex)
            {

                result = false;
            }
            finally
            {

            }

            return result;
        }

        public static int NumberOfTasks(string ProcessInstanceId, string ProcessName)
        {
            int result = 0;
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            try
            {
                result = framework.GetTaskCount(ProcessInstanceId, ProcessName);
            }
            catch (Exception ex)
            {

                result = 0;
            }
            finally
            {

            }

            return result;
        }


        public static tasklist GetTask(string ProcessInstanceId, string ProcessName)
        {

            tasklist result = new tasklist();
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            try
            {
                result = framework.GetTask(ProcessInstanceId, ProcessName)[0];

            }
            catch (Exception ex)
            {

                result.Status = ex.Message;
            }
            finally
            {

            }

            return result;
        }
    

        public static List<TaskDetails> OpenTaskDetails(string SN, string DestinationUser)
    {

        List<TaskDetails> result = new List<TaskDetails>();
        WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
        try
        {
            result = framework.OpenTask(SN, DestinationUser);
        }
        catch (Exception ex)
        {

            result.Add(new TaskDetails
            {
                Status = ex.Message

            });
        }
        finally
        {

        }

        return result;
    }


        public static List<ActionList> TaskActions(string SN, string DestinationUser)
        {

            List<ActionList> result = new List<ActionList>();

            TaskDetails task = new TaskDetails();
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            try
            {
                task = framework.OpenTask(SN, DestinationUser)[0];

              result =  framework.WhatCanIdo(task.Actions);


            }
            catch (Exception ex)
            {

                result.Add(new ActionList
                {
                    ActionText = ex.Message

                });
            }
            finally
            {

            }

            return result;

        }

        public static bool CompleteTask(string SN, string Action, string DestinationUser)
        {

            bool result = false;
  WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            try
            {
         
                result = framework.ActionTask(Action,SN,DestinationUser);


            }
            catch (Exception ex)
            {

                result = false;
            }
            finally
            {

            }

            return result;

        }

        public static List<Activities> GetActivities(string ProcessInstanceId)
        {
           WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            List<Activities> result = new List<Activities>();


            try
            {

                result = framework.GetActivities(ProcessInstanceId);


            }
            catch (Exception ex)
            {

                result.Add(new Activities {
                    ActivityName = ex.Message.ToString()

                });
            }
            finally
            {

            }

            return result;

        }

        public static List<Events> GetEvents(string ActivityId)
        {
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            List<Events> result = new List<Events>();


            try
            {

                result = framework.GetEvents(ActivityId);


            }
            catch (Exception ex)
            {

                result.Add(new Events
                {
                    EventName = ex.Message.ToString()

                });
            }
            finally
            {

            }

            return result;


        }


        public static List<dataField> GetProcessDataFields(string ProcessInstanceId)
        {
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            List<dataField> result = new List<dataField>();


            try
            {

                result = framework.GetProcessDataFields(ProcessInstanceId);


            }
            catch (Exception ex)
            {

                result.Add(new dataField
                {
                    Name = ex.Message.ToString()

                });
            }
            finally
            {

            }

            return result;
        }



        public static List<Workflow> GetProcesses()
        {

            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            List<Workflow> result = new List<Workflow>();


            try
            {

                result = framework.GetProcesses();


            }
            catch (Exception ex)
            {

                result.Add(new Workflow
                {
                    Name = ex.Message.ToString()

                });
            }
            finally
            {

            }

            return result;

        }


        public static List<ActivityDesign> ActivityDesign(int ProcId)
        {
            WorkflowInstanceFramework framework = new WorkflowInstanceFramework();
            List<ActivityDesign> result = new List<ActivityDesign>();
        

                  try
            {

                result = framework.GetWorkflowActivities(ProcId);


            }
            catch (Exception ex)
            {

                result.Add(new ActivityDesign
                {
                    Name = ex.Message.ToString()

                });
            }
            finally
            {

            }

            return result;
        }

}




    public class Test
    {
        public static void BuildTestPattern()
        {




        } 


    }

        

    }

