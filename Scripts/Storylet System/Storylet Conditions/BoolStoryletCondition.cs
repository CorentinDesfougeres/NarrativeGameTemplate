using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public class BoolStoryletCondition : IStoryletCondition
		{

			#region  IStoryletCondition implementation

			[HideInInspector]
			public StoryletConditionType Type{get;set;}

			public int Priority{get;set;}

			public bool IsValid()
			{
				return Variable == WantTrue;
			}

			#endregion


			public bool Variable;

			public bool WantTrue;

			public BoolStoryletCondition()
			{
				Type = StoryletConditionType.BooleanCheck;
			}

		}
	
	}
}