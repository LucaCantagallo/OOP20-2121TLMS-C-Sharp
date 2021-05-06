using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
    /// <summary>
    /// The POJO Score interface provides getter and setter methods for user name and score.
    /// </summary>
    /// <typeparam name="TName">the left element type: the user name</typeparam>
    /// <typeparam name="TScore">the right element type: the score</typeparam>
    public interface IScore<TName, TScore>
    {
        /// <summary>
        /// The User Name
        /// </summary>
        TName Name { get; set; }
        /// <summary>
        /// The Score
        /// </summary>
        TScore Score { get; set; }

    }
}
