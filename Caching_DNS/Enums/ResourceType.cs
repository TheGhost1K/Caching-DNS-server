using System;
using System.ComponentModel;

namespace Caching_DNS.Enums
{
    [Serializable]
    public enum ResourceType : ushort
    {
        [Description("A")] A = 0x0001, //name->IP
        [Description("NS")] NS = 0x0002, //authoritive name server
    }
}