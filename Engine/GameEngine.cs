namespace HzCheat.Engine
{
    public class GameEngine
    {
        private bool isRunning = false;

        public void Initialize()
        {
            isRunning = true;
        }

        public void Update()
        {
            if (!isRunning) return;
            
            // Основной loop
        }

        public void Shutdown()
        {
            isRunning = false;
        }
    }
}
