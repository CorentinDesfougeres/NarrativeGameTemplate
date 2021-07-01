using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		[CreateAssetMenu(menuName = "Tetri/Sally/Storylet Table", fileName = "NewStoryletTable")]
		public class GlobalStoryletTable : SerializedScriptableObject , IStoryletTable
		{

			[TableList]
			public List<Storylet> Storylets{get;set;}
			
		}
	
	}
}