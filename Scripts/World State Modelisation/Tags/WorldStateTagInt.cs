using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public class WorldStateTagInt : IWorldStateTag
		{
			
			# region IWorldStateTag implementation

			public WorldStateTagType Type{get;set;}
			public string  Name{get;set;}
			
			#endregion

			public int Value;
		}
	
	}
}