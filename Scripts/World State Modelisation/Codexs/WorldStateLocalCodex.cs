using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public class WorldStateLocalCodex : MonoBehaviour , IWorldStateCodex
		{

			#region  IWorldStateCodex implementation

			[TableList]
			public List<IWorldStateTag> Tags{get;set;}

			#endregion

		}
	
	}
}