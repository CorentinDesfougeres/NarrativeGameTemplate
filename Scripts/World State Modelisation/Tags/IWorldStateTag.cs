using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public interface IWorldStateTag
		{

			WorldStateTagType Type{get;set;}
			string  Name{get;set;}

		}

		public enum WorldStateTagType
		{
			Bool,
			Int,
			String,
			Float
		}
	
	}
}