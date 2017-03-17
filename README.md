# PlannarShadowForUnity
Planar Shadow is weak and old school But very cheap and useful for mobile games.
Unity’s default shadow system is Shadowmap. It need more Pixel Shader power and Render Targets. I means that Shadowmap system is expensive especially for old mobile devices. 
Actually, Planar Shadow is not real shadow. It is just a mesh. But, It looks like a shadow by pressing/projection into plan using Vertex Shader. It doesn’t need much power of Pixel Shader.
Detailed explain : http://ozlael.tistory.com/10

Pros is : cheap
1. Core part is only for VS. PS handles only color and alpha (plus, Stencil)
2. You can use LOD mesh for shadows. While, Shadowmap(Unity’s shadow) have to draw original mesh twice at least.
3. Shadow doesn’t looks blocky. 

Cons
Only for planar floor.
1. Only sharp edge.
2. Use Stencil. It is not a big deal nowadays because mobile devices are support it too. But, very very old devices may not support it. Anyway, these devices are not good for shadow.

![image](https://lh5.googleusercontent.com/cXh1u1JZ5_i1jZ4knLjTkhUwnbTwxZ5-su-fvdEe8fy_5Ixg-cXf0j9QQMSB1FqgH1KDJy-XzywPzmI=w1930-h912-rw)