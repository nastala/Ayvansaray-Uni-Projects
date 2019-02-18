// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MVC_Northwind_Uygulama.Models
{

    // CustomerDemographics
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class CustomerDemographic
    {
        public string CustomerTypeId { get; set; } // CustomerTypeID (Primary key) (length: 10)
        public string CustomerDesc { get; set; } // CustomerDesc (length: 1073741823)

        // Reverse navigation

        /// <summary>
        /// Child Customers (Many-to-Many) mapped by table [CustomerCustomerDemo]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Customer> Customers { get; set; } // Many to many mapping

        public CustomerDemographic()
        {
            Customers = new System.Collections.Generic.List<Customer>();
        }
    }

}
// </auto-generated>
