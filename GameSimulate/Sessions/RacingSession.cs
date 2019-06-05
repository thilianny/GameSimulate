using GameSimulate.Creators;

namespace GameSimulate.Sessions
{
    public sealed class RacingSession : Session
    {
        internal RacingSession()
        {
        }

        internal override void InitializeCreators()
        {
            PlayerCreator = new PlayerCreator(this);
        }
    }
}