xof 0303txt 0032

template FVFData {
 <b6e70a0e-8ef9-4e83-94ad-ecc8b0c04897>
 DWORD dwFVF;
 DWORD nDWords;
 array DWORD data[nDWords];
}


Frame Scene_Root {
 

 FrameTransformMatrix {
  1.0,0.0,0.0,0.0,
  0.0,1.0,0.0,0.0,
  0.0,0.0,1.0,0.0,
  0.0,0.0,0.0,1.0;;
 }

 Frame Skybox {
  

  FrameTransformMatrix {
   100.0,0.0,0.0,0.0,
   0.0,100.0,0.0,0.0,
   0.0,0.0,100.0,0.0,
   0.0,0.0,0.0,1.0;;
  }

  Mesh {
   24;
   -1.0;-1.0;-1.0;,
    1.0;-1.0;-1.0;,
   -1.0;-1.0; 1.0;,
    1.0;-1.0; 1.0;,
   -1.0; 1.0;-1.0;,
    1.0; 1.0;-1.0;,
   -1.0; 1.0; 1.0;,
    1.0; 1.0; 1.0;,
    1.0;-1.0;-1.0;,
   -1.0;-1.0;-1.0;,
    1.0; 1.0;-1.0;,
   -1.0; 1.0;-1.0;,
    1.0;-1.0; 1.0;,
    1.0;-1.0;-1.0;,
    1.0; 1.0; 1.0;,
    1.0; 1.0;-1.0;,
   -1.0;-1.0; 1.0;,
    1.0;-1.0; 1.0;,
   -1.0; 1.0; 1.0;,
    1.0; 1.0; 1.0;,
   -1.0;-1.0;-1.0;,
   -1.0;-1.0; 1.0;,
   -1.0; 1.0;-1.0;,
   -1.0; 1.0; 1.0;;
   12;
   3;2,3,0;,
   3;1,0,3;,
   3;5,7,4;,
   3;6,4,7;,
   3;8,10,9;,
   3;11,9,10;,
   3;12,14,13;,
   3;15,13,14;,
   3;16,18,17;,
   3;19,17,18;,
   3;20,22,21;,
   3;23,21,22;;

   MeshMaterialList {
    1;
    12;
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0;

    Material {
     1.0;1.0;1.0;1.0;;
     0.0;
     1.0;1.0;1.0;;
     0.0;0.0;0.0;;
     TextureFilename { "skybox02.dds"; }

     EffectInstance {
     "skybox01.fx";
        EffectParamString{ "Texture0@Name"; "skybox02.dds"; }
     }
    }
   }

   FVFData {
    65792;
    72;
    3212836864,3212836864,3212836864,
    1065353216,3212836864,3212836864,
    3212836864,3212836864,1065353216,
    1065353216,3212836864,1065353216,
    3212836864,1065353216,3212836864,
    1065353216,1065353216,3212836864,
    3212836864,1065353216,1065353216,
    1065353216,1065353216,1065353216,
    1065353216,3212836864,3212836864,
    3212836864,3212836864,3212836864,
    1065353216,1065353216,3212836864,
    3212836864,1065353216,3212836864,
    1065353216,3212836864,1065353216,
    1065353216,3212836864,3212836864,
    1065353216,1065353216,1065353216,
    1065353216,1065353216,3212836864,
    3212836864,3212836864,1065353216,
    1065353216,3212836864,1065353216,
    3212836864,1065353216,1065353216,
    1065353216,1065353216,1065353216,
    3212836864,3212836864,3212836864,
    3212836864,3212836864,1065353216,
    3212836864,1065353216,3212836864,
    3212836864,1065353216,1065353216;
   }
  }
 }
}