using UnityEngine;

public class CamFollow : MonoBehaviour
{
	private Vector3 startingPosition;
	public Transform followTarget;
	private Vector3 targetPos;
	public float moveSpeed;


    private void Awake()
    {
    }
    void Start()
	{
		startingPosition = transform.position;
		//followTarget = GameObject.FindGameObjectWithTag("Player").transform ;
	}

	void Update()
	{
		if (followTarget != null)
		{
			targetPos = new Vector3(followTarget.position.x, followTarget.position.y, transform.position.z);
			Vector3 velocity = (targetPos - transform.position) * moveSpeed;
			transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, 1.0f, Time.deltaTime);
		}
	}
}