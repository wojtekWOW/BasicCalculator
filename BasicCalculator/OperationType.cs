using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Type of operation calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds to values toghrther
        /// </summary>
        Add,

        /// <summary>
        /// Takes second value from first
        /// </summary>
        Minus,

        /// <summary>
        /// Multiplies to values
        /// </summary>
        Multiply,

        /// <summary>
        /// Divides first value by second
        /// </summary>
        Divide,

    }
}
