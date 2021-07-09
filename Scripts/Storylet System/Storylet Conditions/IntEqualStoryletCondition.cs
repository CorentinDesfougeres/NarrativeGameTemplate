using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public class IntEqualStoryletCondition : IStoryletCondition
		{
			
			#region  IStoryletCondition implementation

			[HideInInspector]
			public StoryletConditionType Type{get;set;}

			public int Priority{get;set;}

			public bool IsValid()
			{
				return Variable.Value == Target;
			}

			#endregion

			public int Target;

			public WorldStateTagInt Variable;

			public IntEqualStoryletCondition()
			{
				Type = StoryletConditionType.IntEqual;
			}

		}
	
	}
}