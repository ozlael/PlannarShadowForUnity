# PlannarShadowForUnity
Although Planar Shadow is a kind of old school, it is very cheap and useful for mobile games.
Unity’s default shadow system use Shadowmap. It needs more power of Pixel Shader and Render Targets. That means that Shadowmap system is expensive especially on mobile devices. Not only for Unity, other engins are the same. 

Actually, the Planar Shadow is not real shadow. It is just a mesh. But, it looks like a shadow by pressing/projecting into plan using Vertex Shader. It doesn’t need much power of Pixel Shader.
It uses a little bit of math, but, simple trigonometric function. See image below : P is a point of the mesh and P' is a point of the shadow. 

![image](https://github.com/ozlael/PlannarShadowForUnity/blob/master/alittlebitmath.jpg)

```
float4 vPosWorld = mul( _Object2World, v.vertex);
float4 lightDirection = -normalize(_WorldSpaceLightPos0); 
float opposite = vPosWorld.y - _PlaneHeight;
float cosTheta = -lightDirection.y;	// = lightDirection dot (0,-1,0)
float hypotenuse = opposite / cosTheta;
float3 vPos = vPosWorld.xyz + ( lightDirection * hypotenuse );
o.pos = mul (UNITY_MATRIX_VP, float4(vPos.x, _PlaneHeight, vPos.z ,1));  
```

Detailed explain(Korean) : http://ozlael.tistory.com/10

Pros is : cheap
1. Core part is only for VS. PS handles only color and alpha (plus, Stencil)
2. You can use LOD mesh for shadows. While, Shadowmap(Unity’s shadow) have to draw original mesh twice at least.
3. Shadow doesn’t looks blocky. Mobile devices have to use blocky hard shadow because they doesn't have enough power to use soft shadows.

Cons
1. Only for planar floor.
2. Only sharp edge.
3. Use Stencil. But, It is not a big deal nowadays because mobile devices are support it.

![image](http://cfile22.uf.tistory.com/image/260EC04458CB87B32BAD70)
Sample asset : https://www.assetstore.unity3d.com/kr/#!/content/45319
