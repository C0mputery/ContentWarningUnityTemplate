using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline
{
	[Serializable]
	public class SerializedPass : ISerializationCallbackReceiver
	{
		public enum PropertyType
		{
			Color = 0,
			Vector = 1,
			Float = 2,
			Range = 3,
			TexEnv = 4
		}

		[Serializable]
		private class SerializedPropertyKeyValuePair
		{
			[SerializeField]
			public string PropertyName;

			[SerializeField]
			public SerializedPassProperty Property;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SerializedPropertyKeyValuePair()
			{
				throw null;
			}
		}

		[Serializable]
		private class SerializedPassProperty
		{
			[SerializeField]
			public Color ColorValue;

			[SerializeField]
			public float FloatValue;

			[SerializeField]
			public Vector4 VectorValue;

			[SerializeField]
			public PropertyType PropertyType;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SerializedPassProperty()
			{
				throw null;
			}
		}

		[SerializeField]
		private Shader shader;

		[SerializeField]
		private List<SerializedPropertyKeyValuePair> serializedProperties;

		private Dictionary<int, SerializedPassProperty> propertiesById;

		private Dictionary<string, SerializedPassProperty> propertiesByName;

		private Material material;

		private bool propertiesIsDirty;

		public Shader Shader
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Material Material
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasProperty(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasProperty(int hash)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector4 GetVector(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector4 GetVector(int hash)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVector(string name, Vector4 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVector(int hash, Vector4 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetFloat(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetFloat(int hash)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFloat(string name, float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFloat(int hash, float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetColor(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetColor(int hash)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(string name, Color value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(int hash, Color value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeforeSerialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAfterDeserialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializedPass()
		{

		}
	}
}
