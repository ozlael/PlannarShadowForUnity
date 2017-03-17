# PlannarShadowForUnity
Planar Shadow is weak and old school but very cheap and useful for mobile games.
Unity’s default shadow system is Shadowmap. It needs more Pixel Shader power and Render Targets. It means that Shadowmap system is expensive especially for mobile devices. It is not only for Unity. Other engins are the same. 

Actually, Planar Shadow is not real shadow. It is just a mesh. But, it looks like a shadow by pressing/projection into plan using Vertex Shader. It doesn’t need much power of Pixel Shader.
Detailed explain : http://ozlael.tistory.com/10

Pros is : cheap
1. Core part is only for VS. PS handles only color and alpha (plus, Stencil)
2. You can use LOD mesh for shadows. While, Shadowmap(Unity’s shadow) have to draw original mesh twice at least.
3. Shadow doesn’t looks blocky. Mobile devices have to use blocky hard shadow because they doesn't have enough power to use soft shadows.

Cons
1. Only for planar floor.
2. Only sharp edge.
3. Use Stencil. But, It is not a big deal nowadays because mobile devices are support it.

![image](http://cfile22.uf.tistory.com/image/260EC04458CB87B32BAD70)