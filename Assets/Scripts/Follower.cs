using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
	[SerializeField]
	private PathCreator pathCreator;
	[SerializeField]
	private float speed = 5;
	private float distanceTraveled;

	private void Update() {
		distanceTraveled += speed * Time.deltaTime;
		transform.position = pathCreator.path.GetPointAtDistance(distanceTraveled);
	}
}
