using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inside_Colider : MonoBehaviour {


public GameObject coll_o;

public GameObject tri_o;


Collider coll;

// Collider trig;
 Mesh trig_mesh;
Vector3[] vertices;

public bool inside = false;
//  MeshCollider coll_mesh;



// bool ColliderContainsPoint(Transform ColliderTransform, Vector3 Point, bool Enabled)
//     {
//         //Vector3 localPos = ColliderTransform.InverseTransformPoint(Point);
// 		Vector3 localPos = Point;
//         if (Enabled && Mathf.Abs(localPos.x) < 0.5f && Mathf.Abs(localPos.y) < 0.5f && Mathf.Abs(localPos.z) < 0.5f)
//             return true;
//         else
//             return false;
//     }

public void Start()
{
	trig_mesh =  tri_o.GetComponent<MeshFilter>().mesh;
	vertices = trig_mesh.vertices;
	coll = coll_o.GetComponent<MeshCollider>();
}

public void Update()
{
	
	foreach(Vector3 tmp  in vertices)
	{
		// Vector3 p = tmp;
		// p.Scale( tri_o.transform.lossyScale);
		// p = p + tri_o.transform.position;//transform.parent.position;
		Vector3 p = tri_o.transform.TransformPoint(tmp);
		// print(p);
			Debug.DrawLine(p,Vector3.zero);

			// Debug.DrawLine(coll.GetComponent<MeshFilter>().mesh.vertices[0]+ coll.transform.position,Vector3.zero,Color.red);
			// Debug.DrawLine(coll.GetComponent<MeshFilter>().mesh.vertices[0]+ coll.transform.position,Vector3.zero,Color.red);
			//  Matrix 4x4 localToWorld = transform.localToWorldMatrix;
			Vector3 plop = coll.transform.TransformPoint( coll.GetComponent<MeshFilter>().mesh.vertices[0]);
			Debug.DrawLine(plop,Vector3.zero,Color.yellow);

		if(coll.bounds.Contains(p) == false)//if(ColliderContainsPoint(coll_o.transform,p,true))//if(coll.bounds.Contains(p) == false)
		{
			// Debug.DrawLine(p,Vector3.zero);
			//print("not in this cheat");
			inside =  false;
			return;
		}
	}
//	print("win");
	inside =  true;
	// coll.bounds.Contains(gameO)
	//  if (coll_mesh.bounds.Intersects(trig_mesh.bounds);
	//  	print("Win swqw");
}

}
