// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ChartIngressNginx.Inputs
{

    public sealed class AutoscalingTemplatePodsArgs : Pulumi.ResourceArgs
    {
        [Input("metric")]
        public Input<Inputs.AutoscalingTemplatePodsMetricArgs>? Metric { get; set; }

        [Input("target")]
        public Input<Inputs.AutoscalingTemplatePodsTargetArgs>? Target { get; set; }

        public AutoscalingTemplatePodsArgs()
        {
        }
    }
}