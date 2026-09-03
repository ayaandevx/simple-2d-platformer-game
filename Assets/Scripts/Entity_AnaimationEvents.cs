using UnityEngine;

public class Entity_AnaimationEvents : MonoBehaviour
{
    private Entity entity;

    private void Awake()
    {
        entity = GetComponentInParent<Entity>(); 
    }

    public void DamageTargets() => entity.damageTargets(); 
    private void DisableMovementAndJump()=> entity.EnableMovement(false);
    private void EnableMovementAndJump() => entity.EnableMovement(true);

}
