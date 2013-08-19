using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
    [Serializable]
    public class FieldConfig : ConfigBase
    {
        public static FieldConfig GetDefault()
        {
            return new FieldConfig
            {
                VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
                SummaryDocumentationRequired = true,
            };
        }
    }
}