// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Proxmox.VM.Inputs
{

    public sealed class VirtualMachineDiskArgs : Pulumi.ResourceArgs
    {
        [Input("datastoreId")]
        public Input<string>? DatastoreId { get; set; }

        [Input("fileFormat")]
        public Input<string>? FileFormat { get; set; }

        [Input("fileId")]
        public Input<string>? FileId { get; set; }

        [Input("interface", required: true)]
        public Input<string> Interface { get; set; } = null!;

        [Input("size")]
        public Input<int>? Size { get; set; }

        [Input("speed")]
        public Input<Inputs.VirtualMachineDiskSpeedArgs>? Speed { get; set; }

        public VirtualMachineDiskArgs()
        {
        }
    }
}
