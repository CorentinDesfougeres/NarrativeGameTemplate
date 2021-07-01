using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public interface IStoryletTable
		{

			[TableList]
			List<Storylet> Storylets{get;set;}
			
		}
	
	}
}