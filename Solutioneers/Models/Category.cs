﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Solutioneers.Models
{
    /*
     * Only admins will have access to this model, so we will not create resitrctions on it for now.
     */
    public class Category
    {
        [Key]
        public int CategoryID { get; set; } //Group ID
        public string Title { get; set; } // Title of the group
        public string Description { get; set; } //Description of types of problems + solutions that will be found here.
 
        public virtual ICollection<Channel> Channels { get; set; } //entity framework manages the foriegn keys for us
    }
}