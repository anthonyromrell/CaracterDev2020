using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
    public GameAction destinationAction, playerAction;
    private NavMeshAgent agent;
    public Transform player, destination;
    private void Start()
    {
        destination = player;
        agent = GetComponent<NavMeshAgent>();
        
        destinationAction.raiseNoArgs += DestinationSelfSet;
        playerAction.raiseNoArgs += DestinationPlayerSet;
    }
    
    private void Update()
    { 
        agent.destination = destination.position;
        destination = player;
     }

    private void DestinationSelfSet()
    {
        agent.destination = destination.position;
    }

    private void DestinationPlayerSet()
    {
        agent.destination = destination.position;
        destination = player;
    }
}