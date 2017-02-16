﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ReservedCharsInCSharp")]
    public partial class ReservedCharsInCSharpFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ReservedCharsInCSharp.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ReservedCharsInCSharp", "\tIn order to be able to write more expressive meaningful scenarios\r\n\tAs a scenari" +
                    "o writer\r\n\tI want to be able to use any character, including reserved words", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using reserved C# characters in column names")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public virtual void UsingReservedCCharactersInColumnNames()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using reserved C# characters in column names", new string[] {
                        "wip"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "C$harp n@me (with strange chars)"});
            table1.AddRow(new string[] {
                        "A value"});
#line 8
    testRunner.When("I create a dynamic instance from this table", ((string)(null)), table1, "When ");
#line 11
    testRunner.Then("the CharpNmeWithStrangeChars property should equal \'A value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only alfa numeric characters, plus underscore is allowed in variable names")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public virtual void OnlyAlfaNumericCharactersPlusUnderscoreIsAllowedInVariableNames()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only alfa numeric characters, plus underscore is allowed in variable names", new string[] {
                        "wip"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "My_Nice_Variable",
                        "My $$ Variable (needs clean up)"});
            table2.AddRow(new string[] {
                        "A value",
                        "Another value"});
#line 16
       testRunner.When("I create a dynamic instance from this table", ((string)(null)), table2, "When ");
#line 19
    testRunner.Then("the My_Nice_Variable property should equal \'A value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
           testRunner.And("the MyVariableNeedsCleanUp property should equal \'Another value\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using only reserved C# characters in column names")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public virtual void UsingOnlyReservedCCharactersInColumnNames()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Using only reserved C# characters in column names", new string[] {
                        "wip"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "$@()"});
            table3.AddRow(new string[] {
                        "A value"});
#line 24
    testRunner.When("I create a dynamic instance with only reserved chars", ((string)(null)), table3, "When ");
#line 27
    testRunner.Then("an exception with a nice error message about the property only containing reserve" +
                    "d chars should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion