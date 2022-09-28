﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GrupoWebBackend.Tests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AdoptionsRequestsServiceTests")]
    public partial class AdoptionsRequestsServiceTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "AdoptionsRequestsServiceTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "AdoptionsRequestsServiceTests", "As a Developer\r\nI want to add new Adoption Requests through API\r\nSo that it is av" +
                    "ailable when the user make a adoption requests", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
 #line hidden
#line 6
  testRunner.Given("The Endpoint https://localhost:5001/api/v1/AdoptionsRequests is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Type",
                        "UserNick",
                        "Ruc",
                        "Dni",
                        "Phone",
                        "Email",
                        "Name",
                        "LastName",
                        "Pass"});
            table4.AddRow(new string[] {
                        "1",
                        "VET",
                        "Frank",
                        "A12345",
                        "70258688",
                        "946401234",
                        "frank@outlook.com",
                        "Francisco",
                        "Voularte",
                        "123456"});
#line 7
  testRunner.And("A User is already stored for AdoptionsRequests", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Type",
                        "UserNick",
                        "Ruc",
                        "Dni",
                        "Phone",
                        "Email",
                        "Name",
                        "LastName",
                        "Pass"});
            table5.AddRow(new string[] {
                        "2",
                        "VET",
                        "Hector",
                        "",
                        "",
                        "",
                        "Hector@outlook.com",
                        "Hector",
                        "Voularte",
                        "123456"});
#line 10
  testRunner.And("A Second User is already stored for AdoptionsRequests", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Type",
                        "UserNick",
                        "Ruc",
                        "Dni",
                        "Phone",
                        "Email",
                        "Name",
                        "LastName",
                        "Pass"});
            table6.AddRow(new string[] {
                        "3",
                        "VET",
                        "Pablin",
                        "A12345",
                        "70258688",
                        "946401234",
                        "pablin@outlook.com",
                        "Pablo",
                        "Marmol",
                        "123456"});
#line 13
  testRunner.And("A Third User is already stored for AdoptionsRequests", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserId",
                        "Type",
                        "Description",
                        "DateTime"});
            table7.AddRow(new string[] {
                        "3",
                        "Acoso",
                        "Testing",
                        "14/09/2022 11:35"});
#line 16
  testRunner.And("A Report already stored for AdoptionsRequests", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Type",
                        "Name",
                        "Attention",
                        "Race",
                        "Age",
                        "isAdopted",
                        "UserId",
                        "PublicationId"});
            table8.AddRow(new string[] {
                        "101",
                        "Cat",
                        "Lolo",
                        "Required",
                        "Catitus",
                        "2",
                        "false",
                        "1",
                        "1"});
#line 19
  testRunner.And("A Pet already stored for AdoptionsRequests", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "UserId",
                        "DateTime",
                        "PetId",
                        "Comment"});
            table9.AddRow(new string[] {
                        "1",
                        "2",
                        "29/09/2021",
                        "101",
                        "Comentario"});
#line 22
  testRunner.And("A Publication already stored for AdoptionsRequests", ((string)(null)), table9, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A AdoptionsRequests is sent from not Authenticated User")]
        [NUnit.Framework.CategoryAttribute("adoptionsrequests-adding")]
        public void AAdoptionsRequestsIsSentFromNotAuthenticatedUser()
        {
            string[] tagsOfScenario = new string[] {
                    "adoptionsrequests-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A AdoptionsRequests is sent from not Authenticated User", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserIdAt",
                            "PublicationId"});
                table10.AddRow(new string[] {
                            "hello",
                            "pending",
                            "2",
                            "1",
                            "1"});
#line 28
  testRunner.When("A adoption request is sent from not Authenticated User", ((string)(null)), table10, "When ");
#line hidden
#line 31
  testRunner.Then("A Response with Message \"This user is not authenticated.\" and Status 400 is recei" +
                        "ved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A AdoptionsRequests is sent from Reported User")]
        public void AAdoptionsRequestsIsSentFromReportedUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A AdoptionsRequests is sent from Reported User", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserIdAt",
                            "PublicationId"});
                table11.AddRow(new string[] {
                            "hello",
                            "pending",
                            "3",
                            "1",
                            "1"});
#line 33
  testRunner.When("A adoption request is sent from Reported User", ((string)(null)), table11, "When ");
#line hidden
#line 36
  testRunner.Then("A Response with Message \"This user has at least one report.\" and Status 400 is re" +
                        "ceived", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A AdoptionsRequests is sent from Authenticated and not Reported User")]
        public void AAdoptionsRequestsIsSentFromAuthenticatedAndNotReportedUser()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A AdoptionsRequests is sent from Authenticated and not Reported User", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserIdAt",
                            "PublicationId"});
                table12.AddRow(new string[] {
                            "hello",
                            "pending",
                            "1",
                            "2",
                            "1"});
#line 38
  testRunner.When("A adoption request is sent", ((string)(null)), table12, "When ");
#line hidden
#line 41
  testRunner.Then("A Response with Status 200 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A AdoptionsRequests is sent from Authenticated and not Reported User another time" +
            "")]
        public void AAdoptionsRequestsIsSentFromAuthenticatedAndNotReportedUserAnotherTime()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A AdoptionsRequests is sent from Authenticated and not Reported User another time" +
                    "", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message",
                            "Status",
                            "UserIdFrom",
                            "UserIdAt",
                            "PublicationId"});
                table13.AddRow(new string[] {
                            "hello",
                            "pending",
                            "1",
                            "2",
                            "1"});
#line 43
  testRunner.When("A adoption request is sent", ((string)(null)), table13, "When ");
#line hidden
#line 46
  testRunner.Then("A Response with Message \"This user already has an existing adoption request.\" and" +
                        " Status 400 is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
