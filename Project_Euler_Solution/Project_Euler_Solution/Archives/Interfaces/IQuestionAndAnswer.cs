using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler_Solution.Archives.Interfaces

{
    internal interface IQuestionAndAnswer
    {
        #region Question

        string QuestionHeader { get; }

        string Question { get; }

        #endregion Question

        #region Solution

        dynamic Solution();

        #endregion Solution
    }
}