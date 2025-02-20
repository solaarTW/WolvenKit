using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPrefabProxyMeshNode : worldMeshNode
	{
		[Ordinal(16)] 
		[RED("nearAutoHideDistance")] 
		public CFloat NearAutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("nbNodesUnderProxy")] 
		public CUInt32 NbNodesUnderProxy
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldPrefabProxyMeshNode()
		{
			MeshAppearance = "default";
			OccluderAutohideDistanceScale = 255;
			CastShadows = true;
			CastLocalShadows = true;
			CastRayTracedLocalShadows = true;
			WindImpulseEnabled = true;
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			LodLevelScales = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
