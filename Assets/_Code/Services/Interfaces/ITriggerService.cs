namespace _Code.Services.Interfaces
{
    public interface ITriggerService
    {
        void Init(ISceneService sceneService);
        void OnRestart();
    }
}