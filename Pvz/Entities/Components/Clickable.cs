﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz.Components
{
     class Clickable : Component
    {
        public bool IsClicked { get; set; }

        public override void Update()
        {
            if(IsClicked)
            {
                IsClicked = true;
            }
        }
    }
}
