using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;

namespace Tetri
{
	namespace Sally
	{

		public class DrawSelected<T> where T : ScriptableObject
		{
			
			[InlineEditor(InlineEditorObjectFieldModes.CompletelyHidden)]
			public T selected;

			[LabelWidth(100f)]
			[PropertyOrder(-1f)]
			[HorizontalGroup("CreateNew")]
			public string NameForNew = "";

			private string path;

			[HorizontalGroup("CreateNew")]
			[GUIColor(0.7f,0.7f,1f)]
			[Button]
			public void CreateNew()
			{
				if(NameForNew == "")
				{
					return;
				}

				T newItem = ScriptableObject.CreateInstance<T>();
				newItem.name = "New" + typeof(T).ToString();

				if (path == "")
				{
					path = "Assets/";
				}

				AssetDatabase.CreateAsset(newItem, path + "\\" + NameForNew + ".asset");
				AssetDatabase.SaveAssets();

				NameForNew = "";
			}

			[HorizontalGroup("CreateNew")]
			[GUIColor(1f,0.7f,0.7f)]
			[Button]
			public void DeleteSelected()
			{
				if (selected != null)
				{
					string _path = AssetDatabase.GetAssetPath(selected);
					AssetDatabase.DeleteAsset(_path);
					AssetDatabase.SaveAssets();
				}
			}

			public void SetSelected(object item)
			{
				var attempt = item as T;
				if (attempt != null)
				{
					this.selected = attempt;
				}
			}

			public void SetPath(string path)
			{
				this.path = path;
			}

		}
	
	}
}