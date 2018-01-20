using System;
using System.Collections.Generic;
using System.Text;

namespace Casparcg.Core.Device
{
    public interface ICGComponentData
    {
        void ToAMCPEscapedXml(StringBuilder sb);
        void ToXml(StringBuilder sb);
    }
}
