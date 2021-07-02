using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		/*[CreateAssetMenu(menuName ="Tetri/Sally/Salience Rules/Sum" , fileName = "NewSumSalienceRule")]*/              // Does this need to be a ScriptableObject ? only if it is customizable, because only then would there be a sense in making several of them
		public class SumSalienceRule : /*SerializedScriptableObject ,*/ ISalienceRule
		{

			#region ISalienceRule Implementation

			public Storylet Pick(List<Storylet> storylets)
			{
				Sort(storylets);

				return storylets[0];
			}

			public Storylet[] Pick(List<Storylet> storylets , int number)
			{
				Storylet[] choices = new Storylet[number];

				Sort(storylets);
				
				for (int i = 0; i < number; i++)
				{
					choices[i] = storylets[i];
				}

				return choices;
			}

			public List<Storylet> Sort(List<Storylet> storylets)
			{
				foreach (Storylet storylet in storylets)
				{
					foreach (IStoryletCondition condition in storylet.Conditions)
					{
						storylet.Priority += condition.Priority;
					}
				}
				// Do the actual sorting, there probably is a C# function for that
				return storylets;
			}

			#endregion

		}
	
	}
}