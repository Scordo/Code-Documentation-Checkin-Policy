using System;

namespace CDCP.Configuration
{
  [Serializable]
  public enum Visibility
  {
    Private = 0,
    ProtectedInternal = 1,
    Internal = 2,
    Protected = 3,
    Public = 4,
  }
}