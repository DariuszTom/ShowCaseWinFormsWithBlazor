namespace ShowCaseShared.Services
{
    public class CounterService
    {
        private int _currentCount = 0;
        private bool _showCelebration = false;

        public event Action? OnStateChanged;

        public int CurrentCount => _currentCount;
        public bool ShowCelebration => _showCelebration;

        public string GetCounterMessage()
        {
            return _currentCount switch
            {
                0 => "Click the button to start counting!",
                1 => $"Great start! You've clicked {_currentCount} time",
                < 10 => $"Keep going! You've clicked {_currentCount} times",
                < 50 => $"&#x1F525; You're on fire! {_currentCount} clicks!",
                < 100 => $"&#x1F680; Amazing! {_currentCount} clicks and counting!",
                _ => $"&#x1F3C6; LEGENDARY! {_currentCount} clicks! You're a champion!"
            };
        }

        public async Task IncrementCountAsync()
        {
            _currentCount++;
            NotifyStateChanged();

            if (_currentCount % 10 == 0)
            {
                _showCelebration = true;
                NotifyStateChanged();
                await Task.Delay(1500);
                _showCelebration = false;
                NotifyStateChanged();
            }
        }

        public void Reset()
        {
            _currentCount = 0;
            _showCelebration = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnStateChanged?.Invoke();
        }
    }
}
