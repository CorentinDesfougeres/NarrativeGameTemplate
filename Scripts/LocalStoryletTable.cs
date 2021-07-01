using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public class LocalStoryletTable : SerializedMonoBehaviour , IStoryletTable
		{

			[TableList]
			public List<Storylet> Storylets{get;set;}
			
		}
	
	}
}