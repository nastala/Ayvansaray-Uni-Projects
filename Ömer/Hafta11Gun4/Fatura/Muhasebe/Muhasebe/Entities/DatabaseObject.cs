using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class DatabaseObject
    {
        [Key]
        [Display(Name = "Kod")]
        public virtual int Id { get; set; }

        public void CloneToExceptId(DatabaseObject dbObject)
        {
            var properties = GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                if (property.Name == nameof(Id)) continue;

                if (property.CanWrite == false) continue;
                var value = property.GetValue(this);
                property.SetValue(dbObject, value);
            }
        }
    }
}
