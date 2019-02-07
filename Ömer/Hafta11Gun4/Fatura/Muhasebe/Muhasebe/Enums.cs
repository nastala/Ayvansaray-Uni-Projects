using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    [Flags]
    public enum ColumnHide
    {
        Key = 1,
        ForeignKey = 2
    }
    public enum DatabaseUpsertType
    {
        Add,
        Update
    }
    [Flags]
    public enum EditorButtons
    {
        Add = 1,
        Update = 2,
        Delete = 4,
        None = 8
    }
}
