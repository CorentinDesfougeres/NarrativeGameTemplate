using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace Tetri
{
	namespace Sally
	{

		public interface ISalienceRule
		{
			Storylet Pick(List<Storylet> storylets);
			Storylet[] Pick(List<Storylet> storylets , int number);
			List<Storylet> Sort(List<Storylet> storylets);
		}
	
	}
}