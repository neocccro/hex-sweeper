using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMesh : MonoBehaviour
{

    private MeshFilter meshFilter;
    private Mesh mesh;

    private Color colors;

    private static float Sqrt3 = Mathf.Sqrt(3);
    //private static Vector3[] Vertices =
    //{
    //    new Vector3(0, 0, 1f/2),//up
    //    new Vector3(Sqrt3/4, 0, 1f/4),//up right
    //    new Vector3(Sqrt3/4, 0, -1f/4),//down right
    //    new Vector3(0, 0, -1f/2),//down
    //    new Vector3(-Sqrt3/4, 0, -1f/4),//down left
    //    new Vector3(-Sqrt3/4, 0, 1f/4)//up left
    //    Vector3.zero
    //};

    // private static readonly int[] Triangles =
    // {
    //   6, 0, 1,
    //   6, 1, 2,
    //   6, 2, 3,
    //   6, 3, 4,
    //   6, 4, 5,
    //   6, 5, 0
    //};

    public void construct(Mesh mesh)
    {
        gameObject.AddComponent<MeshFilter>().mesh = mesh;
    }
}
