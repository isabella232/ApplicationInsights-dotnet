
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.4.1.0
//   File : AvailabilityData_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    
    
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.4.1.0")]
    internal partial class AvailabilityData
        : Domain
    {
        
        
        public int ver { get; set; }

        
        
        
        
        public string id { get; set; }

        
        
        
        
        public string name { get; set; }

        
        
        
        public System.TimeSpan duration { get; set; }

        
        
        
        public bool success { get; set; }

        
        
        
        public string runLocation { get; set; }

        
        
        
        public string message { get; set; }

        
        
        
        
        public IDictionary<string, string> properties { get; set; }

        
        
        
        public IDictionary<string, double> measurements { get; set; }

        public AvailabilityData()
            : this("AI.AvailabilityData", "AvailabilityData")
        {}

        protected AvailabilityData(string fullName, string name)
        {
            ver = 2;
            id = "";
            this.name = "";
            duration = System.TimeSpan.Zero;
            runLocation = "";
            message = "";
            properties = new ConcurrentDictionary<string, string>();
            measurements = new ConcurrentDictionary<string, double>();
        }
    }
} // AI
