using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public class WorldStateTagBool : IWorldStateTag
		{

			# region IWorldStateTag implementation

			public WorldStateTagType Type{get;set;}
			public string  Name{get;set;}
			
			#endregion

			public bool isTrue;
		}
	
	}
}