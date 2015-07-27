﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

namespace CommandLine.Tests.Fakes
{
    public class FakeOptionsWithSwitches
    {
        [Option("--input")]
        public string InputFile { get; set; }

        [Option('o')]
        public string OutputFile { get; set; }

        [Option('v')]
        public bool Verbose { get; set; }

        [Option('h')]
        public bool HumanReadable { get; set; }

        [Option('i')]
        public bool IgnoreWarnings { get; set; }
    }
}
