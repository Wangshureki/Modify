using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{

	public Transform player;
	public float playerDistance;
	public float awareAI = 10f;
	public float AIMoveSpeed;
	public float damping = 6.0f;

	public Transform[] navPoint;
	public UnityEngine.AI.NavMeshAgent agent;
	public int destPoint = 0;

	public Transform goal;
	public LayerMask whatIsGround, whatIsPlayer;
	public float sightRange, attackRange;
	public bool playerInSightRange, playerInAttackRange;
	bool alreadyAttacked;
	public float timeBetweenAttacks;
	public GameObject Animation_Robot_P;
	public GameObject Camera;


	void Start()
	{
	
		UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.destination = goal.position;

		agent.autoBraking = false;

	}

	private void Update()
	{
		
		playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
		playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

		
		if (playerInSightRange && !playerInAttackRange) ChasePlayer();
		if (playerInAttackRange && playerInSightRange) AttackPlayer();
		if (Input.GetKeyDown(KeyCode.E))
        {
			Animation_Robot_P.GetComponent<Animator>().Play("Robot_turnoff");
			Invoke("RobotTurnon", 5.0f);

		}
				playerDistance = Vector3.Distance (player.position, transform.position);
		if (playerDistance < awareAI)
		{
			LookAtPlayer();
			Debug.Log("Seen");
		}

		if (playerDistance < awareAI)
		{
			if (playerDistance < 2f)
			{
				ChasePlayer(); AttackPlayer();
			}
			else
				GotoNextPoint();
		}


		if (agent.remainingDistance < 0.2f)
			GotoNextPoint();

	}

	void LookAtPlayer()
	{
		transform.LookAt(player);
	}


	void GotoNextPoint()
	{
		if (navPoint.Length == 0)
			return;
		agent.destination = navPoint[destPoint].position;
		destPoint = (destPoint + 1) % navPoint.Length;
		
	}


	private void ChasePlayer()
	{
		transform.Translate(Vector3.forward * AIMoveSpeed * Time.deltaTime);
	}

	private void AttackPlayer()
	{
		//Make sure enemy doesn't move
		agent.SetDestination(transform.position);

		transform.LookAt(player);

		if (!alreadyAttacked)
		{

			Animation_Robot_P.GetComponent<Animator>().Play("Attack");
			Camera.GetComponent<Animator>().Play("Fall");

			alreadyAttacked = true;
			Invoke(nameof(ResetAttack), timeBetweenAttacks);
		}
	}
	private void ResetAttack()
	{
		alreadyAttacked = false;
	}
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, attackRange);
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, sightRange);
	}
	private void RobotTurnon()
	{
		Animation_Robot_P.GetComponent<Animator>().Play("Robot_turnon");
	}
}