using UnityEngine;
using System.Collections;

public class KittyUIController : MonoBehaviour
{
	public GameObject m_kitten;
	private TangoPointCloud m_pointCloud;

	void Start()
	{
		m_pointCloud = FindObjectOfType<TangoPointCloud>();
	}

	void Update ()
	{
		
	}


}
