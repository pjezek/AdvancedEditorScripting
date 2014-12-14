using UnityEngine;
using System.Collections;

public class GizmoDrawer : MonoBehaviour {

	public Transform cube, sphere;
	public float yOffset = 1.0f, size = 0.5f;
	public bool drawWireframe = false;

	void Update ()
	{
		if (cube)
		{
			cube.Rotate(new Vector3(0.0f, -15.0f * Time.deltaTime, 0.0f));
		}
	}

	void OnDrawGizmosSelected()
	{
	}

	void OnDrawGizmos()
	{
		Vector3 spherePos, cubePos;

		if (sphere && cube)
		{
			Gizmos.color = Color.green;
			spherePos = new Vector3(
				sphere.transform.position.x, 
				sphere.transform.position.y + yOffset,
				sphere.transform.position.z
			);
			if (drawWireframe)
			{
				Gizmos.DrawWireSphere(spherePos, size / 2.0f);
			}
			else
			{
				Gizmos.DrawSphere(spherePos, size / 2.0f);
			}

			Gizmos.color = Color.red;
			cubePos = new Vector3(
				cube.transform.position.x, 
				cube.transform.position.y + yOffset,
				cube.transform.position.z
			);
			if (drawWireframe)
			{
				Gizmos.DrawWireCube(cubePos, new Vector3(size, size, size));
			}
			else
			{
				Gizmos.DrawCube(cubePos, new Vector3(size, size, size));
			}

			Gizmos.color = Color.yellow;
			Gizmos.DrawLine(spherePos, cubePos);

			Gizmos.color = Color.blue;
			Gizmos.DrawRay(spherePos, Vector3.down * 2.0f);
			Gizmos.DrawRay(cubePos, Vector3.down* 2.0f);
		}
	}

}
