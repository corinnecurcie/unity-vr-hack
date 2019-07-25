using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace OculusSampleFramework
{
	public class InstantiationExample : MonoBehaviour
	{
		// Reference to the Prefab. Drag a Prefab into this field in the Inspector.
		public GameObject myPrefab;

		// This script will simply instantiate the Prefab when the game starts.
		void Start()
		{
		}

		private void Update()
		{
			if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
			{
				DistanceGrabberModified[] grabbers = FindObjectsOfType<DistanceGrabberModified>();
				Vector3 point = new Vector3(0, 0, 0);
				if (grabbers.Length == 1)
				{
					point = grabbers[0].transform.position;
				}
				else if (grabbers.Length == 2)
				{
					point = Vector3.Lerp(grabbers[0].transform.position, grabbers[1].transform.position, 0.5f);
				}

				Vector3 newPosition = point + grabbers[0].transform.forward;
				Instantiate(myPrefab, newPosition, Quaternion.identity);
			}
		}
	}
}