using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    GameObject[,] map;
    Mesh mesh;


    private static float Sqrt3 = Mathf.Sqrt(3);
    private static Vector3[] Vertices =
    {
      new Vector3(0, 0, 1f/2),//up
      new Vector3(Sqrt3/4, 0, 1f/4),//up right
      new Vector3(Sqrt3/4, 0, -1f/4),//down right
      new Vector3(0, 0, -1f/2),//down
      new Vector3(-Sqrt3/4, 0, -1f/4),//down left
      new Vector3(-Sqrt3/4, 0, 1f/4)//up left
   };

    private static readonly int[] Triangles =
    {
      0, 1, 5,
      1, 4, 5,
      1, 2, 4,
      2, 3, 4
   };

    private void Start()
    {
        mesh = new Mesh();
        mesh.vertices = Vertices;
        mesh.triangles = Triangles;
        mesh.RecalculateNormals();
    }

    // Use this for initialization
    public void GenerateMap(int width, int height)
    {
        if (map != null)
        {
            Kill();
        }
        map = new GameObject[width, height];

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                map[x, y] = new GameObject();
                map[x, y].AddComponent<MeshRenderer>().material.color = Color.Lerp(Color.green , Color.red, (x * map.GetLength(1) + y) / (float) (map.GetLength(0) * map.GetLength(1)));
                map[x, y].transform.position = new Vector3((x * Sqrt3 + y % 2f * Sqrt3 / 2f) / 2, 0, y * 1.5f / 2);
                map[x, y].AddComponent<MeshFilter>().mesh = mesh;
                map[x, y].AddComponent<MeshCollider>().sharedMesh = mesh;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Kill()
    {
        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                Destroy(map[x, y]);
            }
        }
    }
}
