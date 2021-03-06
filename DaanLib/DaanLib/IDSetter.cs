﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanLib {
    /// <summary>
    /// Gives an easy way of giving objects an ID
    /// </summary>
    public sealed class IDSetter {
        private int nextValidId = 0;
        /// <summary>
        /// Gets the next valid ID
        /// </summary>
        public int getNextValidId {
            get => ++nextValidId;
            set {
                if (nextValidId < value)
                    nextValidId = value;
            }
        }
    }
}
