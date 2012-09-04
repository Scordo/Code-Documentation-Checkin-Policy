using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
    [Serializable]
    public class EnumConfig : ConfigBase
    {
        public static EnumConfig GetDefault()
        {
            return new EnumConfig
            {
                VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
                SummaryDocumentationRequired = true
            };
        }
    }
}