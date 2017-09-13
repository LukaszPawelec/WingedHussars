
public interface IAbility
{
    bool IsAvailableBasedOn(Resources resources);
    void create(Resources resource, Province province);
}