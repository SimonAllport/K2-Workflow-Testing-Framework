using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace K2WorkflowMap
{
    public class TestPlan
    {

        public static List<TestPlanTest> BuildTestPlan(int TestId)
        {

            List<TestPlanTest> list = new List<TestPlanTest>();


            SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder hostServerConnectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
            hostServerConnectionString.Host = "localhost";
            hostServerConnectionString.Port = 5555;
            hostServerConnectionString.IsPrimaryLogin = true;
            hostServerConnectionString.Integrated = true;

            SourceCode.SmartObjects.Client.SmartObjectClientServer serverName = new SourceCode.SmartObjects.Client.SmartObjectClientServer();
            serverName.CreateConnection();
            serverName.Connection.Open(hostServerConnectionString.ToString());

            try
            {

                SourceCode.SmartObjects.Client.SmartObject smartObject = serverName.GetSmartObject("K2C_TST_SMO_TestRun");

                smartObject.MethodToExecute = "List_1";
                smartObject.GetMethod("List_1").Parameters["pTestId"].Value = TestId.ToString();
                // smartObject.Properties["pTestId"].Value = TestId.ToString();
                SourceCode.SmartObjects.Client.SmartObjectList smoList = serverName.ExecuteList(smartObject);
                foreach (SourceCode.SmartObjects.Client.SmartObject item in smoList.SmartObjectsList)
                {


                    var z = item.Properties["Sign"].Value;


                    int testrunid = 0;
                    //    int testtypeid = 0;
                    int parameters = 0;
                    int Milliseconds = 0;
                    int.TryParse(item.Properties["NumberOfParameters"].Value, out parameters);
                    int.TryParse(item.Properties["TestRunId"].Value, out testrunid);
                    //  int.TryParse(item.Properties["TestTypeId"].Value, out testtypeid);
                    int.TryParse(item.Properties["Milliseconds"].Value, out Milliseconds);

                    list.Add(new TestPlanTest
                    {
                        TestRunId = testrunid,

                        TestType = item.Properties["TestType"].Value,
                        ExpectedResult = item.Properties["ExpectedResult"].Value,
                        LeftParameter = item.Properties["LeftParameter"].Value,
                        MiddleParameter = item.Properties["MiddleParameter"].Value,
                        RightParameter = item.Properties["RightParameter"].Value,
                        Milliseconds = Milliseconds,
                        NumberOfParameters = parameters,
                        Sign = item.Properties["Sign"].Value

                    });
                }

            }


            catch (Exception ex)
            {
                list.Add(new TestPlanTest
                {


                });

            }
            finally
            {

                serverName.Connection.Close();
            }

            return list;



        }


        public static List<TestPlanDetails> GetTestDetails(int TestId)
        {

            List<TestPlanDetails> list = new List<TestPlanDetails>();


            SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder hostServerConnectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
            hostServerConnectionString.Host = "localhost";
            hostServerConnectionString.Port = 5555;
            hostServerConnectionString.IsPrimaryLogin = true;
            hostServerConnectionString.Integrated = true;

            SourceCode.SmartObjects.Client.SmartObjectClientServer serverName = new SourceCode.SmartObjects.Client.SmartObjectClientServer();
            serverName.CreateConnection();
            serverName.Connection.Open(hostServerConnectionString.ToString());

            try
            {

                SourceCode.SmartObjects.Client.SmartObject smartObject = serverName.GetSmartObject("K2C_TST_SMO_TestRun");
                SourceCode.SmartObjects.Client.SmartObject returnSmartObject;
                smartObject.MethodToExecute = "List_NaN_NaN";
                smartObject.GetMethod("List_NaN_NaN").Parameters["pTestId"].Value = TestId.ToString();
                //   smartObject.Properties["pTestid"].Value = TestId.ToString();

                returnSmartObject =  serverName.ExecuteScalar(smartObject);
                //SourceCode.SmartObjects.Client.SmartObjectList smoList = serverName.ExecuteList(smartObject);
                //foreach (SourceCode.SmartObjects.Client.SmartObject item in smoList.SmartObjectsList)
                //{



                    int ProcessTypeId = 0;
                    int ProcessInstanceId = 0;
                    int parameters = 0;
                    DateTime StartedDate = DateTime.Today;
                    DateTime FinishedDate = DateTime.Today;
                    int.TryParse(returnSmartObject.Properties["ProcessTypeId"].Value, out ProcessTypeId);
                    int.TryParse(returnSmartObject.Properties["ProcessInstanceId"].Value, out ProcessInstanceId);
                    DateTime.TryParse(returnSmartObject.Properties["StartedDate"].Value, out StartedDate);
                    DateTime.TryParse(returnSmartObject.Properties["FinishedDate"].Value, out FinishedDate);
                    list.Add(new TestPlanDetails
                    {
                        TestName = returnSmartObject.Properties["TestName"].Value,
                        WorkflowName = returnSmartObject.Properties["WorkflowName"].Value,
                        ProcessTypeId = ProcessTypeId,
                        ProcessInstanceId = ProcessInstanceId,
                        Folio = returnSmartObject.Properties["Folio"].Value,
                        Originator = returnSmartObject.Properties["Originator"].Value,
                        Started = returnSmartObject.Properties["Started"].Value,
                        StartedDate = StartedDate,
                        Finished = returnSmartObject.Properties["Finished"].Value,
                        FinishedDate = FinishedDate,
                        Status = returnSmartObject.Properties["Status"].Value,
                        Route = returnSmartObject.Properties["Route"].Value

                    });
                //}

            }


            catch (Exception ex)
            {
                list.Add(new TestPlanDetails
                {
                    TestName = ex.Message

                });

            }
            finally
            {

                serverName.Connection.Close();
            }

            return list;



        }

        private static void UpdateTestDetails(int TestDetailsid, int ProcessInstanceId, string Folio, string Originator, DateTime StartedDate, bool Started)
        {
            SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder hostServerConnectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
            hostServerConnectionString.Host = "localhost";
            hostServerConnectionString.Port = 5555;
            hostServerConnectionString.IsPrimaryLogin = true;
            hostServerConnectionString.Integrated = true;

            SourceCode.SmartObjects.Client.SmartObjectClientServer serverName = new SourceCode.SmartObjects.Client.SmartObjectClientServer();
            serverName.CreateConnection();
            serverName.Connection.Open(hostServerConnectionString.ToString());

            try
            {

                SourceCode.SmartObjects.Client.SmartObject smartObject = serverName.GetSmartObject("K2C_TST_SMO_TestRun");
                smartObject.MethodToExecute = "Execute_NaN_1";
                smartObject.GetMethod("Execute_NaN_1").Parameters["pTestDetailsid"].Value = TestDetailsid.ToString();
                smartObject.GetMethod("Execute_NaN_1").Parameters["pProcessInstanceId"].Value = ProcessInstanceId.ToString();
                smartObject.GetMethod("Execute_NaN_1").Parameters["pFolio"].Value = Folio.ToString();
                smartObject.GetMethod("Execute_NaN_1").Parameters["pOriginator"].Value = Originator.ToString();
                smartObject.GetMethod("Execute_NaN_1").Parameters["pStartedDate"].Value = StartedDate.ToString();
                smartObject.GetMethod("Execute_NaN_1").Parameters["pStarted"].Value = Started.ToString();
                serverName.ExecuteScalar(smartObject);
            }
            catch(Exception ex)
            {
                string x = ex.Message;
            }
            finally
            {
                serverName.Connection.Close();
            }
            }

        private static void UpdateTestDetailsEnd(int TestId)
        {
            

 SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder hostServerConnectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
            hostServerConnectionString.Host = "localhost";
            hostServerConnectionString.Port = 5555;
            hostServerConnectionString.IsPrimaryLogin = true;
            hostServerConnectionString.Integrated = true;

            SourceCode.SmartObjects.Client.SmartObjectClientServer serverName = new SourceCode.SmartObjects.Client.SmartObjectClientServer();
            serverName.CreateConnection();
            serverName.Connection.Open(hostServerConnectionString.ToString());

            try
            {

                SourceCode.SmartObjects.Client.SmartObject smartObject = serverName.GetSmartObject("K2C_TST_SMO_TestRun");
                smartObject.MethodToExecute = "Execute_NaN_NaN_1";
                smartObject.GetMethod("Execute_NaN_NaN_1").Parameters["pTestId"].Value = TestId.ToString();
                serverName.ExecuteScalar(smartObject);
            }
            catch (Exception ex)
            { string x = ex.Message;  }
            finally
            {
                serverName.Connection.Close();
            }
            }
        public static string AutoBuildTestParameters(string parametername, int TestId)
        {


            string ProcessInstanceId = "0";
            string ProcessName = string.Empty;

            string paramName = parametername.ToLower();


            string result = string.Empty;
            switch (paramName)
            {
                case "serialnumber":
                    {
                        K2WorkflowMap.WorkflowInstanceFramework workflow = new K2WorkflowMap.WorkflowInstanceFramework();
                        ProcessInstanceId = GetTestDetails(TestId)[0].ProcessInstanceId.ToString();
                        ProcessName = GetTestDetails(TestId)[0].WorkflowName;
                        var task = workflow.GetTask(ProcessInstanceId, ProcessName);
                        result = task[0].SerialNumber;

                        break;
                    }
                case "sn":
                    {
                        K2WorkflowMap.WorkflowInstanceFramework workflow = new K2WorkflowMap.WorkflowInstanceFramework();
                        ProcessInstanceId = GetTestDetails(TestId)[0].ProcessInstanceId.ToString();
                        ProcessName = GetTestDetails(TestId)[0].WorkflowName;
                        var task = workflow.GetTask(ProcessInstanceId, ProcessName);
                        result = task[0].SerialNumber;

                        break;
                    }
                case "processinstanceid":
                    {
                     //   var p = GetTestDetails(TestId);
                        result = GetTestDetails(TestId)[0].ProcessInstanceId.ToString();
                        break;
                    }
                case "activities":
                    {
                    //    var p = GetTestDetails(TestId);
                        result = GetTestDetails(TestId)[0].Route.ToString();
                        break;
                    }

                case "destinationuser":
                    {

                        break;
                    }
                default:
                    {
                        result = parametername;
                        break;
                    }

            }

            return result;
        }

        public static void RunTest(int TestId)
        {
            object Result = null;
            List<string> parameters = new List<string>();
            try
            {

                List<TestPlanTest> tests = BuildTestPlan(TestId);
                if (tests.Count >= 1)
                {

                    foreach (var test in tests)
                    {
                        var Actual = string.Empty;
                        switch (test.NumberOfParameters)
                        {
                            case 1:
                                {

                                    parameters.Add(AutoBuildTestParameters(test.LeftParameter, TestId));
                                    break;
                                }
                            case 2:
                                {
                                    parameters.Add(AutoBuildTestParameters(test.LeftParameter, TestId));
                                    parameters.Add(AutoBuildTestParameters(test.MiddleParameter, TestId));

                                    break;
                                }
                            case 3:
                                {
                                    parameters.Add(AutoBuildTestParameters(test.LeftParameter, TestId));
                                    parameters.Add(AutoBuildTestParameters(test.MiddleParameter, TestId));
                                    parameters.Add(AutoBuildTestParameters(test.RightParameter, TestId));

                                    break;
                                }

                        }


                        Result = Invoke("K2WorkflowMap.WorkflowInstanceFramework", test.TestType.ToString(), parameters, test.Milliseconds, test.NumberOfParameters);
                        if (test.TestType == "StartProcess")
                        {
                            UpdateTestDetails(TestId, (int)Result, parameters[0].ToString(), "bob", DateTime.Today, true);
                        }
                        RecordResult(test.TestRunId, Result.ToString(), test.ExpectedResult,test.Sign);

                        parameters.Clear();

                    }



                }



            }
            catch (Exception ex)
            { }

            finally
            {
                UpdateTestDetailsEnd(TestId);

            }


        }

        private static object Invoke(string typeName, string methodName, List<string> parameter, int Milliseconds, int parameters)
        {
            if (Milliseconds > 0)
            {
                Thread.Sleep(Milliseconds);
            }

            object value = null;

            try
            {
                Type type = Type.GetType(typeName);
                object instance = Activator.CreateInstance(type);
                System.Reflection.MethodInfo method = type.GetMethod(methodName);


                System.Reflection.ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
                object classobj = constructor.Invoke(new object[] { });

                switch (parameters)
                {
                    case 1:
                        {
                            value = method.Invoke(classobj, new object[] { parameter[0] });
                            break;
                        }
                    case 2:
                        {
                            value = method.Invoke(classobj, new object[] { parameter[0], parameter[1] });
                            break;
                        }
                    case 3:
                        {
                            value = method.Invoke(classobj, new object[] { parameter[0], parameter[1], parameter[2] });
                            break;
                        }

                }
                //  method.Invoke(instance, null);

                //   value = method.Invoke(classobj, new object[] { parameter.ToArray()});
            }
            catch (Exception ex)
            {

                value = ex.Message;
            }
            finally
            {
              
            }
            return value;
        }

        private static void RecordResult(int TestRunId, object Actual, string Expected,string Sign)
        {
            SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder hostServerConnectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
            hostServerConnectionString.Host = "localhost";
            hostServerConnectionString.Port = 5555;
            hostServerConnectionString.IsPrimaryLogin = true;
            hostServerConnectionString.Integrated = true;

            SourceCode.SmartObjects.Client.SmartObjectClientServer serverName = new SourceCode.SmartObjects.Client.SmartObjectClientServer();
            serverName.CreateConnection();
            serverName.Connection.Open(hostServerConnectionString.ToString());

            try
            {

                SourceCode.SmartObjects.Client.SmartObject smartObject = serverName.GetSmartObject("K2C_TST_SMO_TestRun");
                smartObject.MethodToExecute = "Execute_NaN";
                smartObject.GetMethod("Execute_NaN").Parameters["pTestRunId"].Value = TestRunId.ToString();
                smartObject.GetMethod("Execute_NaN").Parameters["pResult"].Value = Actual.ToString();
                smartObject.GetMethod("Execute_NaN").Parameters["pExpectedResult"].Value = Expected;
                smartObject.GetMethod("Execute_NaN").Parameters["pPass"].Value = Result(Actual, Expected, Sign).ToString();


                //smartObject.Properties["pTestRunId"].Value = TestRunId.ToString();
                //smartObject.Properties["pResult"].Value = Actual.ToString();
                //smartObject.Properties["pExpectedResult"].Value = Expected;
                //smartObject.Properties["pPass"].Value = Result(Actual, Expected, "").ToString();
                serverName.ExecuteScalar(smartObject);

            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }
            finally
            {
                serverName.Connection.Close();
            }


        }


        private static Boolean Result(object Actual, string Expected, string Sign)
        {
            Boolean Result = false;
            switch (Sign)
            {
                case "Equals":
                    {
                        Result = ((string)Actual == Expected);
                        break;
                    }
                case "Less Than":
                     {
                        int a = int.Parse((string)Actual);
                        int e = int.Parse(Expected);
                        Result = (a < e);
                        break;
                    }
                case "Less Than Equal":
                    {
                        int a = int.Parse((string)Actual);
                        int e = int.Parse(Expected);
                        Result = (a <= e);
                        break;
                    }

                case "Greater Than":
                    {
                        int a = int.Parse((string)Actual);
                        int e = int.Parse(Expected);
                        Result = (a > e);
                        break;
                    }
                case "Greater Than Equal":
                    {
                        int a = int.Parse((string)Actual);
                        int e = int.Parse(Expected);
                        Result = (a >= e);
                        break;
                    }
            }

            return Result;
        }

        public static List<MethodList> GetMethods()
        {
            List<MethodList> list = new List<MethodList>();
            WorkflowInstanceFramework wf = new WorkflowInstanceFramework();
            foreach (var meth in wf.GetType().GetMethods())
            {
                string Left = string.Empty;
                string Middle = string.Empty;
                string Right = string.Empty;

                switch (meth.GetParameters().Count())
                {
                    case 1:
                        {
                            Left = meth.GetParameters()[0].Name;
                            break;
                        }
                    case 2:
                            {
                            Left = meth.GetParameters()[0].Name;
                            Middle = meth.GetParameters()[1].Name;
                            break;
                        }
                    case 3:
                        {
                            Left = meth.GetParameters()[0].Name;
                            Middle = meth.GetParameters()[1].Name;
                            Right = meth.GetParameters()[2].Name;
                            break;
                        }

                }
               
                 



                list.Add(new MethodList
                {
                    MethodName = meth.Name,
                    NumberOfParameters = meth.GetParameters().Count(),
                    LeftParameter = Left,
                    RightParameter = Right,
                    MiddleParameter = Middle

   

                              
                });

            }

            return list;

        }


    }
}
