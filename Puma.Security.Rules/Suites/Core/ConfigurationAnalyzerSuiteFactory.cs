/* 
 * Copyright(c) 2016 - 2019 Puma Security, LLC (https://www.pumascan.com)
 * 
 * Project Leader: Eric Johnson (eric.johnson@pumascan.com)
 * Lead Developer: Eric Mead (eric.mead@pumascan.com)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */

using System.Collections.Immutable;

using Puma.Security.Rules.Analyzer;
using Puma.Security.Rules.Analyzer.Configuration.Compilation;
using Puma.Security.Rules.Analyzer.Configuration.Cors;
using Puma.Security.Rules.Analyzer.Configuration.CustomErrors;
using Puma.Security.Rules.Analyzer.Configuration.MachineKey;

namespace Puma.Security.Rules.Suites.Core
{
    public class ConfigurationAnalyzerSuiteFactory : IAnalyzerSuiteFactory
    {
        public ImmutableArray<ICompilationAnalyzer> Create()
        {
            return new ICompilationAnalyzer[]
            {
                new CompilationAnalyzer(),
                new CustomErrorsAnalyzer(),
                new MachineKeyAnalyzer(),
                new CorsAllowAnyOriginAnalyzer(),
            }.ToImmutableArray();
        }
    }
}