
public class healthSystem
{
    private int healthMax;
    public int health;

    public healthSystem(int maxhealth)
    {
        this.healthMax = maxhealth;
        health = healthMax;
    }
    public int GetHealth()
    {
        return health;
    }
    public float HealthPercent()
    {
        return health / healthMax;
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0)
        {
            health = 0;
        }
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax)
        {
            health = healthMax;
        }
    }

}
