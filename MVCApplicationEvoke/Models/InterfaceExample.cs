namespace MVCApplicationForEvoke.Models
{
    public interface IronMan
    {
        string DisplayHeroName(string name, decimal series);

        string MissionName(string name);

        int NumberOfTeam(int team);
        
    }

    public interface ShieldOperations
    {
        int NumberOfOperations(int operations);
    }

    public interface Multiverse
    {
        string PowerStones(string power);
    }

    public interface Dialogue
    {
        string EndDialogue(string message);
    }

    public class Jarvis : IronMan,ShieldOperations
    {
        public string DisplayHeroName(string name, decimal series)
        {
            throw new NotImplementedException();
        }

        public string MissionName(string name)
        {
            throw new NotImplementedException();
        }

        public int NumberOfOperations(int operations)
        {
            throw new NotImplementedException();
        }

        public int NumberOfTeam(int team)
        {
            throw new NotImplementedException();
        }
    }
}
