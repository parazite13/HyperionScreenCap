﻿using HyperionScreenCap.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HyperionScreenCap.Model
{
    [Serializable]
    public class HyperionServer
    {
        public HyperionServerProtocol Protocol { get; set; }
        public String Host { get; set; }
        public int Port { get; set; }
        public int Priority { get; set; }
        public int MessageDuration { get; set; }

        public static HyperionServer BuildUsingDefaultProtoSettings()
        {
            return new HyperionServer()
            {
                Protocol = HyperionServerProtocol.PROTOCOL_BUFFERS,
                Host = "0.0.0.0",
                Port = 19445,
                Priority = 110,
                MessageDuration = 1500
            };
        }

        public static HyperionServer BuildUsingDefaultFbsSettings()
        {
            return new HyperionServer()
            {
                Protocol = HyperionServerProtocol.FLAT_BUFFERS,
                Host = "0.0.0.0",
                Port = 19400,
                Priority = 110,
                MessageDuration = 1500
            };
        }

        public HyperionServer DeepCopy()
        {
            var copy = (HyperionServer)MemberwiseClone();
            copy.Host = String.Copy(Host);
            return copy;
        }
    }
}
