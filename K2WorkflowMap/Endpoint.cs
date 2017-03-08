using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2WorkflowMap
{
  
   


    public class Endpoint
    {

        /// <summary>
        /// Starts a workflow
        /// </summary>
        /// <param name="Folio"></param>
        /// <param name="WorkflowName"></param>
        /// <returns></returns>

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

        /// <summary>
        /// Checks the current status of a workflow and returns it's status
        /// </summary>
        /// <param name="ProcessInstanceId"></param>
        /// <returns></returns>

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

        /// <summary>
        /// Checks to see if a task exists and returns true
        /// </summary>
        /// <param name="ProcessInstanceId"></param>
        /// <param name="ProcessName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checks the number of tasks for a workflow instance and returns the number of tasks available
        /// </summary>
        /// <param name="ProcessInstanceId"></param>
        /// <param name="ProcessName"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Gets tasks details
        /// </summary>
        /// <param name="ProcessInstanceId"></param>
        /// <param name="ProcessName"></param>
        /// <returns></returns>
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
    
        /// <summary>
        /// Opens a task
        /// </summary>
        /// <param name="SN"></param>
        /// <param name="DestinationUser"></param>
        /// <returns></returns>
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

/// <summary>
/// Gets a list of actions for a task
/// </summary>
/// <param name="SN"></param>
/// <param name="DestinationUser"></param>
/// <returns></returns>
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

        /// <summary>
        /// Actions a task
        /// </summary>
        /// <param name="SN"></param>
        /// <param name="Action"></param>
        /// <param name="DestinationUser"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets a list of activities for a process instance
        /// </summary>
        /// <param name="ProcessInstanceId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets events in activity
        /// </summary>
        /// <param name="ActivityId"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Gets a  list of datafields for process instance
        /// </summary>
        /// <param name="ProcessInstanceId"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Gets a list of processes
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets lists of activities at design timne
        /// </summary>
        /// <param name="ProcId"></param>
        /// <returns></returns>
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



    

        

    }

