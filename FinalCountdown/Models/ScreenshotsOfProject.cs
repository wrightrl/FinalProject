//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalCountdown.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScreenshotsOfProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScreenshotsOfProject()
        {
            this.Project_ID = new HashSet<Project_ID>();
        }
    
        public int ScreenshotID { get; set; }
        public string ScreenshotsOfProject1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_ID> Project_ID { get; set; }
    }
}
