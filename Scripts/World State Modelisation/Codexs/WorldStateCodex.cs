using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

namespace Tetri
{
	namespace Sally
	{

		[CreateAssetMenu(menuName = "Tetri/Sally/World State", fileName = "NewWorldState")]
		public class WorldStateCodex : SerializedScriptableObject , IWorldStateCodex
		{

			#region  IWorldStateCodex implementation

			[OdinSerialize]
			public List<IWorldStateTag> Tags{get;set;}

			#endregion



		}
	
	}
}