using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public int size = 20;

    Vector3[] newVertices;
    Vector2[] newUV;
    int[] newTriangles;

    private MeshFilter meshFilter;
    private Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time);
        }

       mesh.vertices = vertices;
    }
}
