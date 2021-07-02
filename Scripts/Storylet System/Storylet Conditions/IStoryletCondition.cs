using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public interface IStoryletCondition
		{

			StoryletConditionType Type{get;set;}

			int Priority{get;set;}

			bool IsValid();

		}

		public enum StoryletConditionType
		{
			BooleanCheck,
			IntEqual,
			IntRange
		}
	
	}
}