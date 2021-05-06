using System;
using System.Collections.Generic;
using System.Text;

namespace Morlino.src.model.score
{
	/// <summary>
	/// Interface that provides methods to create easier a Score.
	/// </summary>
	/// <typeparam name="TName">the user name</typeparam>
	/// <typeparam name="TScore">the score</typeparam>
	interface IScoreBuilder<TName, TScore>
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name">A string with the user name</param>
		/// <returns>The ScoreBuilder builder with user name</returns>
		IScoreBuilder<TName, TScore> NameFromString(string name);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="score"> The integer score of the game</param>
		/// <returns>The ScoreBuilder builder with score</returns>
		IScoreBuilder<TName, TScore> Score(int score);

		/// <summary>
		/// 
		/// </summary>
		/// <returns>A Score</returns>
		IScore<TName, TScore> Build();
	}
}
