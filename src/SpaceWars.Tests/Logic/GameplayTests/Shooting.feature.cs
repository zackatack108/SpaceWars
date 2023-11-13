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
namespace SpaceWars.Tests.Logic.GameplayTests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ShootingFeature : object, Xunit.IClassFixture<ShootingFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Shooting.feature"
#line hidden
        
        public ShootingFeature(ShootingFeature.FixtureData fixtureData, SpaceWars_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Logic/GameplayTests", "Shooting", "How ships can shoot each other", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
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
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Shoot a ship directly in front of you within range three times")]
        [Xunit.TraitAttribute("FeatureTitle", "Shooting")]
        [Xunit.TraitAttribute("Description", "Shoot a ship directly in front of you within range three times")]
        public void ShootAShipDirectlyInFrontOfYouWithinRangeThreeTimes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shoot a ship directly in front of you within range three times", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
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
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Heading",
                            "Shield",
                            "Health"});
                table1.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "0",
                            "100",
                            "100"});
                table1.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "90",
                            "100",
                            "100"});
#line 8
 testRunner.Given("the following game state", ((string)(null)), table1, "Given ");
#line hidden
#line 12
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Heading",
                            "Shield",
                            "Health"});
                table2.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "0",
                            "100",
                            "100"});
                table2.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "90",
                            "0",
                            "50"});
#line 15
 testRunner.Then("I have the following game state", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Shoot a ship directly in front of you within range")]
        [Xunit.TraitAttribute("FeatureTitle", "Shooting")]
        [Xunit.TraitAttribute("Description", "Shoot a ship directly in front of you within range")]
        [Xunit.TraitAttribute("Category", "tag1")]
        public void ShootAShipDirectlyInFrontOfYouWithinRange()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shoot a ship directly in front of you within range", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
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
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Heading",
                            "Shield",
                            "Health"});
                table3.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "0",
                            "100",
                            "100"});
                table3.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "90",
                            "100",
                            "100"});
#line 24
 testRunner.Given("the following game state", ((string)(null)), table3, "Given ");
#line hidden
#line 28
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Shield",
                            "Health"});
                table4.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "100",
                            "100"});
                table4.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "50",
                            "100"});
#line 29
 testRunner.Then("I have the following game state", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="shoot twice")]
        [Xunit.TraitAttribute("FeatureTitle", "Shooting")]
        [Xunit.TraitAttribute("Description", "shoot twice")]
        public void ShootTwice()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("shoot twice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 34
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
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Heading",
                            "Shield",
                            "Health"});
                table5.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "0",
                            "100",
                            "100"});
                table5.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "90",
                            "100",
                            "100"});
#line 35
 testRunner.Given("the following game state", ((string)(null)), table5, "Given ");
#line hidden
#line 39
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Heading",
                            "Shield",
                            "Health"});
                table6.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "0",
                            "100",
                            "100"});
                table6.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "90",
                            "50",
                            "100"});
#line 40
 testRunner.Then("I have the following game state", ((string)(null)), table6, "Then ");
#line hidden
#line 44
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Shield",
                            "Health"});
                table7.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "100",
                            "100"});
                table7.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "0",
                            "100"});
#line 45
 testRunner.Then("I have the following game state", ((string)(null)), table7, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="shoot thrice")]
        [Xunit.TraitAttribute("FeatureTitle", "Shooting")]
        [Xunit.TraitAttribute("Description", "shoot thrice")]
        public void ShootThrice()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("shoot thrice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
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
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Heading",
                            "Shield",
                            "Health"});
                table8.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "0",
                            "100",
                            "100"});
                table8.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "90",
                            "100",
                            "100"});
#line 51
 testRunner.Given("the following game state", ((string)(null)), table8, "Given ");
#line hidden
#line 55
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Shield",
                            "Health"});
                table9.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "100",
                            "100"});
                table9.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "50",
                            "100"});
#line 56
 testRunner.Then("I have the following game state", ((string)(null)), table9, "Then ");
#line hidden
#line 60
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Shield",
                            "Health"});
                table10.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "100",
                            "100"});
                table10.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "0",
                            "100"});
#line 61
 testRunner.Then("I have the following game state", ((string)(null)), table10, "Then ");
#line hidden
#line 65
 testRunner.When("Player 1 shoots the Basic Cannon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Player Name",
                            "X",
                            "Y",
                            "Shield",
                            "Health"});
                table11.AddRow(new string[] {
                            "Player 1",
                            "0",
                            "0",
                            "100",
                            "100"});
                table11.AddRow(new string[] {
                            "Player 2",
                            "0",
                            "3",
                            "0",
                            "50"});
#line 66
 testRunner.Then("I have the following game state", ((string)(null)), table11, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ShootingFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ShootingFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
