//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SKASP.DOMAIN.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Theme
    {
        public Theme()
        {
            this.Topics = new HashSet<Topic>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public System.DateTime Created_on { get; set; }
        public string Subgroup { get; set; }
    
        public virtual Usr_lg_data Usr_lg_data { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
