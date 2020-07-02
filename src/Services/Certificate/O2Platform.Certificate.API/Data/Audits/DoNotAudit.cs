using System;

namespace O2Platform.Certificate.API.Data.Audits
{
    [AttributeUsage(AttributeTargets.Property)] 
    public class DoNotAudit : Attribute 
    { 
    }
}