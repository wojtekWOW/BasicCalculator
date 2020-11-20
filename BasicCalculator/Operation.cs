using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about single calculator operation
    /// </summary>
    public class Operation
    {
        #region Public Properties
        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string leftSide { get; set; }

        /// <summary>
        /// The right side of the operation
        /// </summary>
        public string rightSide { get; set; }

        /// <summary>
        /// Type of opertion to pefrorm
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Sequence of operations
        /// </summary>
        public Operation InnerOperation { get; set; }
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            //Creating empty strings instead of nulls
            leftSide = string.Empty;
            rightSide = string.Empty;
        }
    }
}
