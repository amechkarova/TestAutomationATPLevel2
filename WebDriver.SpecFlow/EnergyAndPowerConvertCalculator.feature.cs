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
namespace WebDriver.SpecFlow
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ConvertMetricsForNuclearScienceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = new string[] {
                "﻿",
                "firefox"};
        
#line 1 "EnergyAndPowerConvertCalculator.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Convert Metrics for Nuclear Science", "\tTo do my nuclear-related job\r\n\tAs a Nuclear Engineer \r\n\tI want to be able to con" +
                    "vert different metrics.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Convert Metrics for Nuclear Science")))
            {
                global::WebDriver.SpecFlow.ConvertMetricsForNuclearScienceFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Kilowatt-hours to Newton-meters")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        public void SuccessfullyConvertKilowatt_HoursToNewton_Meters()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully Convert Kilowatt-hours to Newton-meters", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 8
 testRunner.When("I navigate to Metric Conversions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And("navigate to Energy and power section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("navigate to Kilowatt-hours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("choose conversions to Newton-meters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("type \"30\" kWh", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.Then("assert that 1.080000e+8 Nm are displayed as answer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Kilowatt-hours to Newton-meters in Fractions format")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        public void SuccessfullyConvertKilowatt_HoursToNewton_MetersInFractionsFormat()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully Convert Kilowatt-hours to Newton-meters in Fractions format", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.When("I navigate to Metric Conversions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.And("navigate to Energy and power section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("navigate to Kilowatt-hours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("choose conversions to Newton-meters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("type 30 kWh in Fractions format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("assert that 1079999999⁄64 Nm are displayed as answer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Seconds to Minutes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        public void SuccessfullyConvertSecondsToMinutes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully Convert Seconds to Minutes", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 24
 testRunner.When("I navigate to Seconds to Minutes Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And("type seconds for 1 day, 1 hour, 1 minute, 1 second", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then("assert that 1501 minutes are displayed as answer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Seconds to Minutes No Minutes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        public void SuccessfullyConvertSecondsToMinutesNoMinutes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully Convert Seconds to Minutes No Minutes", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
 testRunner.When("I navigate to Seconds to Minutes Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.And("type seconds for 1 day, 1 hour, 1 second", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.Then("assert that 1500 minutes are displayed as answer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void SuccessfullyConvertSecondsToMinutesTable(string seconds, string minutes, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("seconds", seconds);
            argumentsOfScenario.Add("minutes", minutes);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully Convert Seconds to Minutes Table", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
 testRunner.When("I navigate to Seconds to Minutes Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And(string.Format("type seconds for {0}", seconds), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then(string.Format("assert that {0} minutes are displayed as answer", minutes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Seconds to Minutes Table: 1 day, 1 hour, 1 second")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "1 day, 1 hour, 1 second")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:seconds", "1 day, 1 hour, 1 second")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:minutes", "1500")]
        public void SuccessfullyConvertSecondsToMinutesTable_1Day1Hour1Second()
        {
#line 33
this.SuccessfullyConvertSecondsToMinutesTable("1 day, 1 hour, 1 second", "1500", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Seconds to Minutes Table: 5 days, 3 minutes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "5 days, 3 minutes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:seconds", "5 days, 3 minutes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:minutes", "7203")]
        public void SuccessfullyConvertSecondsToMinutesTable_5Days3Minutes()
        {
#line 33
this.SuccessfullyConvertSecondsToMinutesTable("5 days, 3 minutes", "7203", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Seconds to Minutes Table: 4 hours")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "4 hours")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:seconds", "4 hours")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:minutes", "240")]
        public void SuccessfullyConvertSecondsToMinutesTable_4Hours()
        {
#line 33
this.SuccessfullyConvertSecondsToMinutesTable("4 hours", "240", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully Convert Seconds to Minutes Table: 180 seconds")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "180 seconds")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:seconds", "180 seconds")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:minutes", "3")]
        public void SuccessfullyConvertSecondsToMinutesTable_180Seconds()
        {
#line 33
this.SuccessfullyConvertSecondsToMinutesTable("180 seconds", "3", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Amazon Products with Affiliate Codes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Convert Metrics for Nuclear Science")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("﻿")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("firefox")]
        public void AddAmazonProductsWithAffiliateCodes()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Amazon Products with Affiliate Codes", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Url",
                            "AffilicateCode"});
                table1.AddRow(new string[] {
                            "/dp/B00TSUGXKE/ref=ods_gw_d_h1_tab_fd_c3",
                            "affiliate3"});
                table1.AddRow(new string[] {
                            "/dp/B00KC6I06S/ref=fs_ods_fs_tab_al",
                            "affiliate4"});
                table1.AddRow(new string[] {
                            "/dp/B0189XYY0Q/ref=fs_ods_fs_tab_ts",
                            "affiliate5"});
                table1.AddRow(new string[] {
                            "/dp/B018Y22C2Y/ref=fs_ods_fs_tab_fk",
                            "affiliate6"});
#line 46
 testRunner.When("add products", ((string)(null)), table1, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
