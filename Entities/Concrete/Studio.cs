﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackBone.Entities;

namespace Entities.Concrete
{
   public class Studio:IEntity
    {
        public int StudioId { get; set; }
        public string StudioName { get; set; }
    }
}
