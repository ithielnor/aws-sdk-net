﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.CodeAnalysis
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CodeAnalysisProjectFile : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""15.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <MinimumVisualStudioVersion>15.0</MinimumVisualStudioVersion>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 14 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ProjectGuid"]));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 17 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["RootNamespace"]));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 18 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@"</AssemblyName>
    <ProjectTypeGuids>{786C830F-07A1-408B-BD7F-6EE04809D6DB};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <TargetFrameworkProfile>Profile7</TargetFrameworkProfile>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <ItemGroup>
");
            
            #line 44 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"

    foreach(string subDirectory in ((IList<string>)this.Session["SourceDirectories"]))
    {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 48 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subDirectory));
            
            #line default
            #line hidden
            this.Write("\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 51 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n    <None Include=\"packages.config\" />\r\n  </ItemGr" +
                    "oup>\r\n  <ItemGroup>\r\n    <Analyzer Include=\"..\\..\\..\\packages\\Microsoft.CodeAnal" +
                    "ysis.Analyzers.1.0.0\\analyzers\\dotnet\\cs\\Microsoft.CodeAnalysis.Analyzers.dll\" /" +
                    ">\r\n    <Analyzer Include=\"..\\..\\..\\packages\\Microsoft.CodeAnalysis.Analyzers.1.0" +
                    ".0\\analyzers\\dotnet\\cs\\Microsoft.CodeAnalysis.CSharp.Analyzers.dll\" />\r\n  </Item" +
                    "Group>\r\n  <ItemGroup>\r\n    <Reference Include=\"Microsoft.CodeAnalysis, Version=1" +
                    ".0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=" +
                    "MSIL\">\r\n      <HintPath>..\\..\\..\\packages\\Microsoft.CodeAnalysis.Common.1.0.0\\li" +
                    "b\\portable-net45+win8\\Microsoft.CodeAnalysis.dll</HintPath>\r\n      <Private>Fals" +
                    "e</Private>\r\n    </Reference>\r\n    <Reference Include=\"Microsoft.CodeAnalysis.CS" +
                    "harp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, process" +
                    "orArchitecture=MSIL\">\r\n      <HintPath>..\\..\\..\\packages\\Microsoft.CodeAnalysis." +
                    "CSharp.1.0.0\\lib\\portable-net45+win8\\Microsoft.CodeAnalysis.CSharp.dll</HintPath" +
                    ">\r\n      <Private>False</Private>\r\n    </Reference>\r\n    <Reference Include=\"Mic" +
                    "rosoft.CodeAnalysis.CSharp.Workspaces, Version=1.0.0.0, Culture=neutral, PublicK" +
                    "eyToken=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <HintPath>..\\..\\.." +
                    "\\packages\\Microsoft.CodeAnalysis.CSharp.Workspaces.1.0.0\\lib\\portable-net45+win8" +
                    "\\Microsoft.CodeAnalysis.CSharp.Workspaces.dll</HintPath>\r\n      <Private>False</" +
                    "Private>\r\n    </Reference>\r\n    <Reference Include=\"Microsoft.CodeAnalysis.Works" +
                    "paces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, proces" +
                    "sorArchitecture=MSIL\">\r\n      <HintPath>..\\..\\..\\packages\\Microsoft.CodeAnalysis" +
                    ".Workspaces.Common.1.0.0\\lib\\portable-net45+win8\\Microsoft.CodeAnalysis.Workspac" +
                    "es.dll</HintPath>\r\n      <Private>False</Private>\r\n    </Reference>\r\n    <Refere" +
                    "nce Include=\"System.Collections.Immutable, Version=1.1.36.0, Culture=neutral, Pu" +
                    "blicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n      <HintPath>..\\" +
                    "..\\..\\packages\\System.Collections.Immutable.1.1.36\\lib\\portable-net45+win8+wp8+w" +
                    "pa81\\System.Collections.Immutable.dll</HintPath>\r\n      <Private>False</Private>" +
                    "\r\n    </Reference>\r\n    <Reference Include=\"System.Composition.AttributedModel, " +
                    "Version=1.0.27.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArc" +
                    "hitecture=MSIL\">\r\n      <HintPath>..\\..\\..\\packages\\Microsoft.Composition.1.0.27" +
                    "\\lib\\portable-net45+win8+wp8+wpa81\\System.Composition.AttributedModel.dll</HintP" +
                    "ath>\r\n      <Private>False</Private>\r\n    </Reference>\r\n    <Reference Include=\"" +
                    "System.Composition.Convention, Version=1.0.27.0, Culture=neutral, PublicKeyToken" +
                    "=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n      <HintPath>..\\..\\..\\packag" +
                    "es\\Microsoft.Composition.1.0.27\\lib\\portable-net45+win8+wp8+wpa81\\System.Composi" +
                    "tion.Convention.dll</HintPath>\r\n      <Private>False</Private>\r\n    </Reference>" +
                    "\r\n    <Reference Include=\"System.Composition.Hosting, Version=1.0.27.0, Culture=" +
                    "neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n      <H" +
                    "intPath>..\\..\\..\\packages\\Microsoft.Composition.1.0.27\\lib\\portable-net45+win8+w" +
                    "p8+wpa81\\System.Composition.Hosting.dll</HintPath>\r\n      <Private>False</Privat" +
                    "e>\r\n    </Reference>\r\n    <Reference Include=\"System.Composition.Runtime, Versio" +
                    "n=1.0.27.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitect" +
                    "ure=MSIL\">\r\n      <HintPath>..\\..\\..\\packages\\Microsoft.Composition.1.0.27\\lib\\p" +
                    "ortable-net45+win8+wp8+wpa81\\System.Composition.Runtime.dll</HintPath>\r\n      <P" +
                    "rivate>False</Private>\r\n    </Reference>\r\n    <Reference Include=\"System.Composi" +
                    "tion.TypedParts, Version=1.0.27.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50" +
                    "a3a, processorArchitecture=MSIL\">\r\n      <HintPath>..\\..\\..\\packages\\Microsoft.C" +
                    "omposition.1.0.27\\lib\\portable-net45+win8+wp8+wpa81\\System.Composition.TypedPart" +
                    "s.dll</HintPath>\r\n      <Private>False</Private>\r\n    </Reference>\r\n    <Referen" +
                    "ce Include=\"System.Reflection.Metadata, Version=1.0.21.0, Culture=neutral, Publi" +
                    "cKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL\">\r\n      <HintPath>..\\..\\" +
                    "..\\packages\\System.Reflection.Metadata.1.0.21\\lib\\portable-net45+win8\\System.Ref" +
                    "lection.Metadata.dll</HintPath>\r\n      <Private>False</Private>\r\n    </Reference" +
                    ">\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n    <EmbeddedResource Include=\"Generated\\Prope" +
                    "rtyValueRules.xml\" />\r\n");
            
            #line 110 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"

    foreach(string resource in ((IList<string>)this.Session["EmbeddedResources"]))
    {

            
            #line default
            #line hidden
            this.Write("\t<EmbeddedResource Include=\"");
            
            #line 114 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resource));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 115 "C:\projects\aws\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\CodeAnalysisProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <Import Project=\"..\\..\\SharedAnalysisCode\\SharedAnalysisCode.pr" +
                    "ojitems\" Label=\"Shared\" />\r\n  <Import Project=\"$(MSBuildExtensionsPath32)\\Micros" +
                    "oft\\Portable\\v4.6\\Microsoft.Portable.CSharp.targets\" />\r\n</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
