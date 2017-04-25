using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float LaunchSpeed;

    Rigidbody m_rigidBody;
    AudioSource m_audioSource;

    void Awake()
    {
        m_rigidBody = GetComponent<Rigidbody>();
        m_audioSource = GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start ()
    {
        Launch();
    }

    public void Launch()
    {
        m_rigidBody.velocity = Vector3.forward * LaunchSpeed;
        m_audioSource.Play();
    }
}
