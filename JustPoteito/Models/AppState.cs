namespace JustPoteito.Models
{
    public class AppState
    {
        public Action Action { get; set; }
        public Action<Dictionary<string, object>> ActionWithParameters { get; set; }
    }
}
