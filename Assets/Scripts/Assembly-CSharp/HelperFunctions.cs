using System.Runtime.CompilerServices;
using UnityEngine;

public class HelperFunctions : MonoBehaviour
{
	public enum LayerType
	{
		Terrain = 0,
		TerrainProp = 1,
		Prop = 2,
		All = 3,
		Interactable = 4,
		Tangible = 5
	}

	public static LayerMask terrainMask;

	public static LayerMask terrainPropMask;

	public static LayerMask AllMask;

	public static LayerMask tangibleMask;

	public static LayerMask PropMask;

	public static LayerMask InteractableMask;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Terrain GetTerrain(Vector3 center)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LayerMask GetMask(LayerType layerType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLayer(LayerType layerType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 GetGroundPos(Vector3 from, LayerType layerType, float radius = 0f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RaycastHit GetGroundPosRaycast(Vector3 from, LayerType layerType, float radius = 0f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GameObject InstantiatePrefab(GameObject sourceObj, Transform transform)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RaycastHit GetGroundPosRaycast(Vector3 from, LayerType layerType, Vector3 gravityDir, float radius = 0f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RaycastHit LineCheck(Vector3 from, Vector3 to, LayerType layerType, float radius = 0f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static RaycastHit[] LineCheckAll(Vector3 from, Vector3 to, LayerType layerType, float radius = 0f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConfigurableJoint AttachPositionJoint(Rigidbody rig1, Rigidbody rig2, bool useCustomConnection = false, Vector3 customConnectionPoint = default(Vector3))
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Joint AttachFixedJoint(Rigidbody rig1, Rigidbody rig2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 RandomOnFlatCircle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyAll(Object[] objects)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 EulerToLook(Vector2 euler)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 LookToEuler(Vector2 lookRotationValues)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 LookToDirection(Vector3 look, Vector3 targetDir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 EulerToDirection(Vector3 euler, Vector3 targetDir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 DirectionToEuler(Vector3 dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 DirectionToLook(Vector3 dir)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 GroundDirection(Vector3 planeNormal, Vector3 sideDirection)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 SeparateClamps(Vector3 rotationError, float clamp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float FlatDistance(Vector3 from, Vector3 to)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IgnoreConnect(Rigidbody rig1, Rigidbody rig2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RaycastHit[] SortRaycastResults(RaycastHit[] hitsToSort)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int RaycastHitComparer(RaycastHit x, RaycastHit y)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Quaternion GetRandomRotationWithUp(Vector3 normal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Bounds GetTotalBounds(GameObject gameObject)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float FlatAngle(Vector3 dir1, Vector3 dir2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetChildCollidersLayer(Transform root, int layerID)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float GetCameraDistanceMultiplier(Vector3 position, float range)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetJointDrive(ConfigurableJoint joint, float spring, float damper, Rigidbody rig)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Transform FindChildRecursive(string targetName, Transform root)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PhysicsRotateTowards(Rigidbody rig, Vector3 from, Vector3 to, float force)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 MultiplyVectors(Vector3 v1, Vector3 v2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 CubicBezier(Vector3 Start, Vector3 _P1, Vector3 _P2, Vector3 end, float _t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 QuadraticBezier(Vector3 start, Vector3 _P1, Vector3 end, float _t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 LinearBezier(Vector3 start, Vector3 end, float _t)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Vector3 GetRandomPositionInBounds(Bounds bounds)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SpawnPrefab(GameObject gameObject, Vector3 position, Quaternion rotation, Transform transform)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Quaternion GetRotationWithUp(Vector3 forward, Vector3 up)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float BoxDistance(Vector3 pos1, Vector3 pos2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IsMine(GameObject target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CanSee(Transform looker, Vector3 pos, float maxAngle = 70f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InBoxRange(Vector3 position1, Vector3 position2, int range)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Random.State SetRandomSeedFromWorldPos(Vector3 position, int seed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HelperFunctions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFunctions()
	{
		throw null;
	}
}
