using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FoodEater : MonoBehaviour
{

    [SerializeField] private XRSocketInteractor socketInteractor;
    [SerializeField] private AudioSource audioSourceEating;

    public void EatFood()
    {
        var currentFood = socketInteractor.interactablesHovered[0];

        audioSourceEating.transform.position = socketInteractor.transform.position;
        audioSourceEating.Play();

        Destroy(currentFood.transform.gameObject);
    }
}
