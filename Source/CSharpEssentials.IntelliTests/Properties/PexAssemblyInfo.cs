// <copyright file="PexAssemblyInfo.cs">Copyright © Dustin Campbell 2015</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("CSharpEssentials")]
[assembly: PexInstrumentAssembly("Microsoft.CodeAnalysis.Workspaces")]
[assembly: PexInstrumentAssembly("System.Diagnostics.Debug")]
[assembly: PexInstrumentAssembly("System.Collections")]
[assembly: PexInstrumentAssembly("System.Linq")]
[assembly: PexInstrumentAssembly("System.Runtime.Extensions")]
[assembly: PexInstrumentAssembly("Microsoft.CodeAnalysis")]
[assembly: PexInstrumentAssembly("System.Runtime")]
[assembly: PexInstrumentAssembly("System.Collections.Immutable")]
[assembly: PexInstrumentAssembly("System.Threading.Tasks")]
[assembly: PexInstrumentAssembly("Microsoft.CodeAnalysis.CSharp")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CodeAnalysis.Workspaces")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Diagnostics.Debug")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Collections")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Linq")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Runtime.Extensions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CodeAnalysis")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Runtime")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Collections.Immutable")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Threading.Tasks")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CodeAnalysis.CSharp")]
