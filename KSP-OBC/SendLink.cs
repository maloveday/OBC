﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSP_OBC {
    interface SendLink {
        public void send(byte[] rawOut);
    }
}
